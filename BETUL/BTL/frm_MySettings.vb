Public Class frm_MySettings

    Dim ports As String()
    Private Sub frm_MySettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ARDUINO
        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)
        ports = IO.Ports.SerialPort.GetPortNames()

        Dim port As String
        cmb_Port.Items.Add("Select item")
        'cmb_Port.SelectedIndex = 0
        For Each port In ports
            cmb_Port.Items.Add(port)
        Next port
        For i = 0 To cmb_Port.Items.Count - 1
            If ports.Any Then
                If My.Settings.ARDUINO_Port = "" Or My.Settings.ARDUINO_Port <> cmb_Port.Items(i) Then
                    cmb_Port.SelectedIndex = 0
                Else
                    cmb_Port.SelectedItem = My.Settings.ARDUINO_Port
                    Exit For
                End If
                'cmb_Port.Enabled = True
            Else
                MsgBox(("NO Com Port !!"), MsgBoxStyle.OkOnly)
                'btn_SetPort.Enabled = False
            End If
        Next
        cmb_Port.Enabled = True

        ' Display Baudrate
        cmb_BaudRate.Items.Add(9600)
        cmb_BaudRate.Items.Add(19200)
        cmb_BaudRate.Items.Add(38400)
        cmb_BaudRate.Items.Add(57600)
        cmb_BaudRate.Items.Add(115200) ' <--
        cmb_BaudRate.SelectedIndex = 4

        ' Parity bits
        cmb_ParityBits.Items.Add(System.IO.Ports.Parity.Even)
        cmb_ParityBits.Items.Add(System.IO.Ports.Parity.Mark)
        cmb_ParityBits.Items.Add(System.IO.Ports.Parity.None) ' <--
        cmb_ParityBits.Items.Add(System.IO.Ports.Parity.Odd)
        cmb_ParityBits.Items.Add(System.IO.Ports.Parity.Space)
        cmb_ParityBits.SelectedIndex = 2

        ' Stop bits
        cmb_StopBits.Items.Add(System.IO.Ports.StopBits.None)
        cmb_StopBits.Items.Add(System.IO.Ports.StopBits.One) ' <--
        cmb_StopBits.Items.Add(System.IO.Ports.StopBits.OnePointFive)
        cmb_StopBits.Items.Add(System.IO.Ports.StopBits.Two)
        cmb_StopBits.SelectedIndex = 1

        ' Data bits
        cmb_DataBits.Items.Add(5)
        cmb_DataBits.Items.Add(6)
        cmb_DataBits.Items.Add(7)
        cmb_DataBits.Items.Add(8) ' <--
        cmb_DataBits.SelectedIndex = 3

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        If cmb_Port.SelectedIndex > 0 Then

            If (cmb_Port.SelectedText <> String.Empty) And (cmb_Port.SelectedText <> "") Then

                Save_Settings()
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
                'frm_main.tmr_Process.Enabled = True
                Me.Close()


            Else
                Save_Settings()
                MsgBox("Saved.")
                Arduino.Show()
            End If
        Else
            MsgBox("Please select Com Port!")
        End If

    End Sub

    Private Sub Save_Settings()

        Try
            'ARDUINO
            My.Settings.ARDUINO_Port = cmb_Port.SelectedItem
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Settings cant save ! - " & ex.ToString())
            End Try

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        If cmb_Port.SelectedItem <> My.Settings.ARDUINO_Port Then

            If (MsgBox("Values are changed. Do you want to save them?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then

                If cmb_Port.SelectedIndex > 0 Then
                    Save_Settings()
                Else
                    MsgBox("Please select Com Port!")
                End If

            End If
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.No
        'frm_main.tmr_Process.Enabled = True
        Me.Close()

    End Sub
End Class