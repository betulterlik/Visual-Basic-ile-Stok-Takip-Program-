Public Class BarcodePrinterCopy
    Private Sub BarcodePrinterCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '^XA
        '^FO100,100
        '^BQN,2,7
        '^FDMM,ABETUL^FS

        '^FO500,100
        '^BQN,2,7
        '^FDMM,ABETUL^FS

        '^CF0,50
        '^BY4,2,170
        '^FO100,290^FD Test^FS^BY3,5,200

        '^FO300,290^FD02/02/2020 0930^FS
        '^XZ
    End Sub

    Public Sub CreateBarcode(ByVal BarcodeNumber1 As String, ByVal BarcodeNumber2 As String, ByVal ProductName As String, ByVal DateTime As String)
        Dim strFile As String = "barcode1.txt"
        Dim sw As IO.StreamWriter

        If IO.File.Exists(strFile) = False Then
            sw = IO.File.CreateText(strFile)
        Else
            IO.File.Delete(strFile)
            sw = IO.File.CreateText(strFile)
        End If
        sw.WriteLine("^XA")
        ' Part number
        Dim No1 As String = "Nr :" & BarcodeNumber1
        sw.WriteLine("^FO100,100")
        sw.WriteLine("^BQN,2,7")
        sw.WriteLine("^FDMM,A" & No1 & "^FS ")

        Dim No2 As String = "Nr :" & BarcodeNumber2
        sw.WriteLine("^FO500,100")
        sw.WriteLine("^BQN,2,7")
        sw.WriteLine("^FDMM,A" & No2 & "^FS ")

        ' Product - Datetime
        sw.WriteLine("^CF0,40")
        sw.WriteLine("^BY4,2,170")
        sw.WriteLine("^FO100,290^FD" & ProductName & "^FS^BY3,5,200")

        sw.WriteLine("^FO400,290^FD" & DateTime & "^FS")

        sw.WriteLine("^XZ")
        sw.Close()
    End Sub

    ' Print Barcode
    Public Sub PrintBarcode(ByVal printerName As String)
        Dim proc As New System.Diagnostics.Process
        With proc.StartInfo
            .UseShellExecute = True
            .FileName = "cmd.exe"
            .Arguments = "/C copy barcode1.txt ""\\127.0.0.1\" & printerName & ""
            .WindowStyle = ProcessWindowStyle.Hidden
        End With
        proc.Start()
        Do
        Loop While Not proc.WaitForExit(100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strPrinterName As String = "ZDesigner GC420t (EPL)"
        CreateBarcode(txt_barcode1.Text, txt_barcode2.Text, txt_product.Text, txt_date.Text)
        PrintBarcode(strPrinterName)

    End Sub

    Private Sub Barcode_Click(sender As Object, e As EventArgs) Handles Barcode.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_barcode2_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode2.TextChanged

    End Sub

    Private Sub txt_date_TextChanged(sender As Object, e As EventArgs) Handles txt_date.TextChanged

    End Sub

    Private Sub txt_product_TextChanged(sender As Object, e As EventArgs) Handles txt_product.TextChanged

    End Sub

    Private Sub txt_barcode1_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class