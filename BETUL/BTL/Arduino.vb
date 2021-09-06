Imports System.IO.Ports

Public Class Arduino

    Public logger As New LogFile(IO.Directory.GetCurrentDirectory() & "\Logs")
    Dim ini As New INIfile(IO.Directory.GetCurrentDirectory() & "\elopar.ini")
    Public LocalDB As New SQLiteTools("C:\Users\Betül TERLİK\AppData\Roaming\ELOPAR\BetulDB\BetulDB.db", True)

    Dim delayTime As Integer = 25
    Dim startTime As DateTime
    Dim endTime As DateTime
    Dim elapsed As TimeSpan

    ' Serial port
    Private serialPort As New CommManager()
    Dim portName As String
    Dim waitForArduino = False

    Dim messageSent As Boolean = False
    Dim data As String


    Dim counter As Integer
    Dim pins As String = String.Empty
    Dim leds As Integer

    Public Enum CaseSteps
        clearall = 0
        InputControl  'Q
        OutputControl 'L
        InputControl2  'Q
        OutputControl2 'L

    End Enum

    Private Sub btn_calis_Click(sender As Object, e As EventArgs) Handles btn_calis.Click
        'txt_data.Text = String.Empty
        serialPort.WriteData(">" & txt_command.Text.ToString() & "<")
        tmr_process.Enabled = True
        txt_data.Enabled = False
    End Sub

    Private Sub Arduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        counter = CaseSteps.clearall
       'tmr_process.Enabled = True

        delayTime = CInt(ini.ReadValue("System", "Delay"))

        'serialPort.PortName = ini.ReadValue("System", "Port") '1.Yol
        serialPort.PortName = My.Settings.ARDUINO_Port.ToString
        'MessageBox.Show("Port name: " & serialPort.PortName)
        serialPort.BaudRate = 115200
        serialPort.Parity = Parity.None
        serialPort.StopBits = StopBits.One
        serialPort.DataBits = 8
        serialPort.STX = ">"
        serialPort.ETX = "<"

        serialPort.comPort.DtrEnable = True
        serialPort.comPort.RtsEnable = False
        serialPort.comPort.DiscardNull = True

        serialPort.CurrentTransmissionType = CommManager.TransmissionType.Text
        '' Received data written to textbox
        serialPort.DisplayWindow = txt_data

        If serialPort.OpenPort() = False Then
            MessageBox.Show("Can not open serial port.", "EBox Error")
            logger.WriteLog("Can not open serial port.")
            logger.WriteLog("")
            serialPort.ClosePort()
            'MsgBox(fff("The Port ") & serialPort.PortName & fff(" does NOT exist !!"), MsgBoxStyle.OkOnly, "ARDUINO SETUP")
            Me.Close()
        Else
            ' Info label

            'messageSent = String.Empty

            logger.WriteLog(vbCrLf)
            logger.WriteLog("Application started.")
            logger.WriteLog("----------------------------------------------------------------------")
            logger.WriteLog("Serial port opened.")

            Me.CenterToScreen()
        End If
        txt_data.Text = String.Empty
        'serialPort.WriteData(">" & txt_command.Text.ToString() & "<")

    End Sub

    Private Sub tmr_process_Tick(sender As Object, e As EventArgs) Handles tmr_process.Tick

#Region "Potansiyometre için mesaj gönderme, ölçüm sonucu verme"
        pins = txt_command.Text

        If Not messageSent Then

            serialPort.WriteData(pins)
            logger.WriteLog("S:" & pins)
            startTime = Now
            messageSent = True
            txt_command.Text = String.Empty
            txt_data.Text = String.Empty
        End If

        If txt_data.Text <> String.Empty Then
            If txt_data.Text.Replace(vbCrLf, "") = pins Then
                logger.WriteLog("R:" & txt_data.Text)
            Else
                logger.WriteLog("R:" & txt_data.Text)
                tmr_process.Enabled = False
                LocalDB.ExecuteNonQuery("INSERT INTO Potentiometer VALUES ('" & txt_data.Text & "','" & txt_command.Text & "' ,'" & My.Settings.ARDUINO_Port.ToString & "','" & startTime & "') ")
                txt_command.Text = String.Empty
                txt_data.Text = String.Empty
            End If
            messageSent = False
            txt_data.Text = String.Empty
        Else
            endTime = Now
            elapsed = endTime.Subtract(startTime)
            If elapsed.TotalSeconds > delayTime Then
                messageSent = False
                txt_data.Text = String.Empty
                txt_command.Text = String.Empty
            End If
        End If
#End Region

#Region "Dip Switch için mesaj gönderip alma"
        'Select Case counter

        '    Case CaseSteps.clearall

        '        If Not messageSent Then
        '            'pins = String.Empty
        '            pins = ">T<"
        '            'pins = txt_command.Text
        '            serialPort.WriteData(pins)
        '            logger.WriteLog("S:" & pins)
        '            startTime = Now
        '            messageSent = True
        '        End If


        '        If txt_data.Text <> String.Empty Then
        '            If txt_data.Text.Replace(vbCrLf, "") = ">T<" Then
        '                logger.WriteLog("R:" & txt_data.Text)
        '                counter += 1
        '            Else
        '                logger.WriteLog("R:" & txt_data.Text)
        '            End If
        '            messageSent = False
        '            txt_data.Text = String.Empty
        '        Else
        '            endTime = Now
        '            elapsed = endTime.Subtract(startTime)
        '            If elapsed.TotalSeconds > delayTime Then
        '                messageSent = False
        '                txt_data.Text = String.Empty
        '            End If
        '        End If


        '    Case CaseSteps.InputControl

        '        If Not messageSent Then
        '            'pins = String.Empty
        '            pins = ">Q<"
        '            'pins = txt_command.Text
        '            serialPort.WriteData(pins)
        '            logger.WriteLog("S:" & pins)
        '            startTime = Now
        '            messageSent = True
        '        End If

        '        If txt_data.Text <> String.Empty Then
        '            If txt_data.Text.Replace(vbCrLf, "").Contains("11") Then
        '                logger.WriteLog("R:" & txt_data.Text)
        '                counter += 1
        '            Else
        '                logger.WriteLog("R:" & txt_data.Text)
        '            End If
        '            messageSent = False
        '            txt_data.Text = String.Empty
        '        Else
        '            endTime = Now
        '            elapsed = endTime.Subtract(startTime)
        '            If elapsed.TotalSeconds > delayTime Then
        '                messageSent = False
        '                txt_data.Text = String.Empty
        '            End If
        '        End If

        '    Case CaseSteps.OutputControl

        '        If Not messageSent Then
        '            'pins = String.Empty
        '            pins = ">L02<"
        '            'pins = txt_command.Text
        '            serialPort.WriteData(pins)
        '            logger.WriteLog("S:" & pins)
        '            startTime = Now
        '            messageSent = True
        '        End If

        '        If txt_data.Text <> String.Empty Then
        '            If txt_data.Text.Replace(vbCrLf, "") = ">L02<" Then
        '                logger.WriteLog("R:" & txt_data.Text)
        '                counter += 1
        '                ' tmr_process.Enabled = False
        '            Else
        '                logger.WriteLog("R:" & txt_data.Text)
        '            End If
        '            messageSent = False
        '            txt_data.Text = String.Empty
        '        Else
        '            endTime = Now
        '            elapsed = endTime.Subtract(startTime)
        '            If elapsed.TotalSeconds > delayTime Then
        '                messageSent = False
        '                txt_data.Text = String.Empty
        '            End If
        '        End If

        '    Case CaseSteps.InputControl2

        '        If Not messageSent Then
        '            'pins = String.Empty
        '            pins = ">Q<"
        '            'pins = txt_command.Text
        '            serialPort.WriteData(pins)
        '            logger.WriteLog("S:" & pins)
        '            startTime = Now
        '            messageSent = True
        '        End If

        '        If txt_data.Text <> String.Empty Then
        '            If txt_data.Text.Replace(vbCrLf, "").Contains("12") Then
        '                logger.WriteLog("R:" & txt_data.Text)
        '                counter += 1
        '            Else
        '                logger.WriteLog("R:" & txt_data.Text)
        '            End If
        '            messageSent = False
        '            txt_data.Text = String.Empty
        '        Else
        '            endTime = Now
        '            elapsed = endTime.Subtract(startTime)
        '            If elapsed.TotalSeconds > delayTime Then
        '                messageSent = False
        '                txt_data.Text = String.Empty
        '            End If
        '        End If

        '    Case CaseSteps.OutputControl2

        '        If Not messageSent Then
        '            'pins = String.Empty
        '            pins = ">L03<"
        '            'pins = txt_command.Text
        '            serialPort.WriteData(pins)
        '            logger.WriteLog("S:" & pins)
        '            startTime = Now
        '            messageSent = True
        '        End If

        '        If txt_data.Text <> String.Empty Then
        '            If txt_data.Text.Replace(vbCrLf, "") = ">L03<" Then
        '                logger.WriteLog("R:" & txt_data.Text)
        '                counter = CaseSteps.clearall
        '                tmr_process.Enabled = False
        '            Else
        '                logger.WriteLog("R:" & txt_data.Text)
        '            End If
        '            messageSent = False
        '            txt_data.Text = String.Empty
        '        Else
        '            endTime = Now
        '            elapsed = endTime.Subtract(startTime)
        '            If elapsed.TotalSeconds > delayTime Then
        '                messageSent = False
        '                txt_data.Text = String.Empty
        '            End If
        '        End If

        'End Select
#End Region

    End Sub


    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        'change text box to the value of the scrollbar
        Label1.Text = "value: " + VScrollBar1.Value.ToString
        'sends the startbyte, location byte & value of scroll bar
        serialPort.WriteData(Chr(32) & Chr(0) & Chr(VScrollBar1.Value))
    End Sub
End Class