Public Class BarcodePrinter
    Private Sub BarcodePrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub CreateBarcode(ByVal BarcodeNumber As String, ByVal OperatorName As String, ByVal DateTime As String)
        Dim strFile As String = "barcode.txt"
        Dim sw As IO.StreamWriter

        If IO.File.Exists(strFile) = False Then
            sw = IO.File.CreateText(strFile)
        Else
            IO.File.Delete(strFile)
            sw = IO.File.CreateText(strFile)
        End If
        sw.WriteLine("^XA")
        sw.WriteLine("^CFA,30")
        sw.WriteLine("^FX")
        sw.WriteLine("^BY4,2,170")
        ' Part number
        Dim No As String = "Nr :" & BarcodeNumber
        sw.WriteLine("^FO150,50^BC^FD" & No & "^FS ")

        sw.WriteLine("^FO75,560^GB200,160,3^FS")
        sw.WriteLine("^FO275,560^GB200,160,3^FS")
        sw.WriteLine("^FO475,560^GB200,160,3^FS")
        sw.WriteLine("^FO475,400^GB200,160,3^FS")
        sw.WriteLine("^FO275,400^GB200,160,3^FS")
        sw.WriteLine("^FO75,400^GB200,160,3^FS")
        sw.WriteLine("^FO475,720^GB200,160,3^FS")
        sw.WriteLine("^FO275,720^GB200,160,3^FS")
        sw.WriteLine("^FO75,720^GB200,160,3^FS")
        sw.WriteLine("^FO150,415^FDop.1^FS^FO150,575^FDop.2^FS^FO150,735^FDop.3^FS^FO350,415^FDop.4^FS^FO350,575^FDop.5^FS^FO350,735^FDop.6^FS^FO550,415^FDop.7^FS^FO550,575^FDop.8^FS^FO550,735^FDop.9^FS")
        sw.WriteLine("^FO75,450^GB600,1,3^FS^FO75,615^GB600,1,3^FS^FO75,770^GB600,1,3^FS")

        sw.WriteLine("^CF0,50")
        ' Operator - Datetime
        OperatorName = "Operator:" & OperatorName
        sw.WriteLine("^FO40,300^FD" & OperatorName & "^FS^BY3,5,200")

        sw.WriteLine("^FO40,950^FD" & DateTime & "^FS")


        '----------------------------

        sw.WriteLine("^FWI")
        sw.WriteLine("^BY4,2,170")
        ' Part number
        sw.WriteLine("^FO150,1900^BC^FD" & No & "^FS ")

        sw.WriteLine("^CF0,50")
        ' Operator - Datetime

        sw.WriteLine("^FO450,1750^FD" & OperatorName & "^FS^BY3,5,200")
        sw.WriteLine("^FO450,1050^FD" & DateTime & "^FS")

        sw.WriteLine("^CFA,30")

        sw.WriteLine("^FO575,1560^GB200,160,3^FS")
        sw.WriteLine("^FO375,1560^GB200,160,3^FS")
        sw.WriteLine("^FO180,1560^GB200,160,3^FS")
        sw.WriteLine("^FO575,1400^GB200,160,3^FS")
        sw.WriteLine("^FO375,1400^GB200,160,3^FS")
        sw.WriteLine("^FO180,1400^GB200,160,3^FS")
        sw.WriteLine("^FO575,1240^GB200,160,3^FS")
        sw.WriteLine("^FO375,1240^GB200,160,3^FS")
        sw.WriteLine("^FO180,1240^GB200,160,3^FS")
        sw.WriteLine("^FO650,1680^FDop.1^FS^FO650,1520^FDop.2^FS^FO650,1360^FDop.3^FS^FO450,1680^FDop.4^FS^FO450,1520^FDop.5^FS^FO450,1360^FDop.6^FS^FO250,1680^FDop.7^FS^FO250,1520^FDop.8^FS^FO250,1360^FDop.9^FS")
        sw.WriteLine("^FO175,1670^GB600,1,3^FS^FO175,1500^GB600,1,3^FS^FO175,1340^GB600,1,3^FS")


        sw.WriteLine("^XZ")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strPrinterName As String = "ZDesigner GC420t (EPL)"
        CreateBarcode(txt_barcode.Text, txt_operator.Text, txt_date.Text)
        PrintBarcode(strPrinterName)

    End Sub
End Class