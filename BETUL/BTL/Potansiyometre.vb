Imports System.IO.Ports

Public Class Potansiyometre
    'Private SerialPort1 As New CommManager()

    Private Sub Potansiyometre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim str As String
            str = "a"
            SerialPort1.Write(str)
            Dim receiveddata As Integer = SerialPort1.ReadLine()
            TextBox1.Text = receiveddata
            ProgressBar1.Value = receiveddata
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            MsgBox("Bağlantı Koptu")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Try
            SerialPort1.BaudRate = 115200
            SerialPort1.Parity = Parity.None
            SerialPort1.DataBits = 8
            SerialPort1.PortName = TextBox1.Text
            If Not (SerialPort1.IsOpen) Then SerialPort1.Open()
            MsgBox("Bağlandi")
        Catch ex As Exception
            MsgBox("Bağlantı Koptu")
        End Try
    End Sub
End Class