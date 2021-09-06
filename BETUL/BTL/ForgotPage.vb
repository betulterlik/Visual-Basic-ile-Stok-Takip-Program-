Imports System.Text.RegularExpressions

Public Class ForgotPage
    Public LocalDB As New SQLiteTools("C:\Users\Betül TERLİK\Source\Repos\Personel\Personel.db", True)
    Dim rs As New Resizer
    Dim ini As New INIfile(IO.Directory.GetCurrentDirectory() & "\elopar.ini")
    Public language As String = CInt(ini.ReadValue("SYSTEM", "Lang"))

    Private Sub ForgotPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rs.FindAllControls(Me)

        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)


        LoginPage.SetWindowRgn(btn_update.Handle, LoginPage.CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 35, 55), True)

        LoginPage.SetWindowRgn(txt_email.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_email.Width, txt_email.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_password.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_password.Width, txt_password.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_repassword.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_repassword.Width, txt_repassword.Height, 35, 55), True)

      
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        If txt_email.Text <> String.Empty Then
            If txt_password.Text <> String.Empty Then
                If txt_repassword.Text <> String.Empty And txt_password.Text = txt_repassword.Text Then

                    If Not LocalDB.isThere("Select * from LOGIN where Email = '" & txt_email.Text & "' ") Then

                        LocalDB.ExecuteNonQuery("UPDATE LOGIN SET Password='" & txt_password.Text.ToString & "', RePassword='" & txt_repassword.Text.ToString & "' where  Email = '" & txt_email.Text & "' ")


                        MsgBox("Updated !")

                        Clear()
                    Else

                        '    'LocalDB.ExecuteNonQuery("INSERT INTO LOGIN VALUES ('" & txt_email.Text & "','" & txt_password.Text & "','" & txt_repassword.Text & "') ")

                    End If
                Else
                    ' MsgBox("Password couldn't be paired !")
                    CreateObject("WScript.Shell").Popup(fff("Password could not be paired!"), 1, "Password could not be paired", 64)
                    Clear()
                End If
            End If
        End If

    End Sub

    Public Function fff(ByVal s As String) As String
        If CStr(LocalDB.GetSingleValue("select * from MESSAGES where (lng = " & language & ") and (key = '" & s & "') ", "Value")) <> String.Empty Then
            Return LocalDB.GetSingleValue("select * from MESSAGES where (lng = " & language & ") and (key = '" & s & "') ", "Value")
        Else
            Return LocalDB.GetSingleValue("select * from MESSAGES where (lng = 0) and (key = '" & s & "') ", "Value")
        End If
    End Function

    Private Sub lbl_create_Click(sender As Object, e As EventArgs) Handles lbl_create.Click
        LoginPage.Activate()
        LoginPage.Show()
        Me.Hide()
    End Sub

    Public Sub Clear()
        'txt_email.Text = String.Empty
        txt_password.Text = String.Empty
        txt_repassword.Text = String.Empty

    End Sub

    Private Sub btn_Cancel_Login_Click(sender As Object, e As EventArgs) Handles btn_Cancel_Login.Click
        'Me.DialogResult = DialogResult.Cancel
        LoginPage.Activate()
        LoginPage.Show()
        Me.Close()

    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(txt_email.Text.Trim)
        If Not isValid Then
            lbl_msg.Text = ("Invalid Email.")
        Else
            lbl_msg.Text = (" ")
        End If
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        Dim MatchNumberPattern As String = "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$"
        '(?=.*\d) =1 rakam 

        If txt_password.Text.Trim <> "" Then
            If Not Regex.IsMatch(txt_password.Text, MatchNumberPattern) Then

                lbl_msg.Text = ("Password is not valid")
            Else
                lbl_msg.Text = (" ")
            End If
        End If

    End Sub

    Private Sub txt_repassword_TextChanged(sender As Object, e As EventArgs) Handles txt_repassword.TextChanged
        Dim MatchNumberPattern As String = "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$"
        '(?=.*\d) =1 rakam 

        If txt_repassword.Text.Trim <> "" Then
            If Not Regex.IsMatch(txt_repassword.Text, MatchNumberPattern) Then

                lbl_msg.Text = ("Password is not valid")
            Else
                lbl_msg.Text = (" ")
            End If
        End If
    End Sub
End Class