Public Class BarcodeCreate
    Private Sub BarcodeCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim OrderNumber As String = txt_ord.Text
        Dim StationId As String = txt_sta.Text
        Dim OpId As String = txt_operator.Text
        Dim DateTime As String = txt_date.Text

    End Sub

    Public Sub CreateBarcode(ByVal OrderNumber As String, ByVal StationId As String, ByVal OpId As String, ByVal DateTime As String)
        Dim strFile As String = "barcode.txt"
        Dim sw As IO.StreamWriter

        If IO.File.Exists(strFile) = False Then
            sw = IO.File.CreateText(strFile)
        Else
            IO.File.Delete(strFile)
            sw = IO.File.CreateText(strFile)
        End If
        sw.WriteLine("N")

        ' Part number
        Dim partNo As String = "Part Nr :" & OrderNumber
        sw.WriteLine("A50,5,0,4,1,1,N,""" & partNo & """")

        ' Station id
        StationId = "Station :" & StationId
        sw.WriteLine("A50,50,0,4,1,1,N,""" & StationId & """")

        ' Operator Id
        OpId = "Operator:" & OpId
        sw.WriteLine("A50,100,0,4,1,1,N,""" & OpId & """")

        ' Datetime
        sw.WriteLine("A50,150,0,4,1,1,N,""" & DateTime & """")

        ' Barcode
        sw.WriteLine("B50,200,0,1,3,5,150,B,""" & OrderNumber & """")

        sw.WriteLine("P1")
        sw.Close()
    End Sub

    ' Print Barcode
    Public Sub PrintBarcode(ByVal printerName As String)
        Dim proc As New System.Diagnostics.Process
        With proc.StartInfo
            .UseShellExecute = True
            .FileName = "cmd.exe"
            .Arguments = "/C copy barcode.txt ""\\127.0.0.1\" & printerName & ""
            .WindowStyle = ProcessWindowStyle.Hidden
        End With
        proc.Start()
        Do
        Loop While Not proc.WaitForExit(100)
    End Sub

    Private Sub btn_barcode_Click(sender As Object, e As EventArgs) Handles btn_barcode.Click
        Dim strPrinterName As String = "ZDesigner GC420t (EPL)"
        CreateBarcode(txt_ord.Text, txt_sta.Text, txt_operator.Text, txt_date.Text)
        PrintBarcode(strPrinterName)
    End Sub
End Class