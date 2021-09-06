
Imports System.Text.RegularExpressions

Public Class SignUpPage

    Public LocalDB As New SQLiteTools("C:\Users\Betül TERLİK\Source\Repos\Personel\Personel.db", True)
    Dim rs As New Resizer
    Dim ini As New INIfile(IO.Directory.GetCurrentDirectory() & "\elopar.ini")
    Public language As String = CInt(ini.ReadValue("SYSTEM", "Lang"))

    Private Sub SignUpPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rs.FindAllControls(Me)

        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)

        LoginPage.SetWindowRgn(btn_sign.Handle, LoginPage.CreateRoundRectRgn(0, 0, btn_sign.Width, btn_sign.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_email.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_email.Width, txt_email.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_password.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_password.Width, txt_password.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_repassword.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_repassword.Width, txt_repassword.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_level.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_level.Width, txt_level.Height, 35, 55), True)
        LoginPage.SetWindowRgn(txt_username.Handle, LoginPage.CreateRoundRectRgn(0, 0, txt_username.Width, txt_username.Height, 35, 55), True)

        LoginPage.SetWindowRgn(cmb_level.Handle, LoginPage.CreateRoundRectRgn(0, 0, cmb_level.Width, cmb_level.Height, 35, 55), True)

        If (cmb_level.Items.Count = 0) Then
            cmb_level.Items.Add("Select")
            cmb_level.Items.Add("Admin")
            cmb_level.Items.Add("Mechanic")
            cmb_level.SelectedIndex = 0

        End If
    End Sub

    Private Sub btn_Cancel_Login_Click(sender As Object, e As EventArgs) Handles btn_Cancel_Login.Click
        LoginPage.Activate()
        LoginPage.Show()
        Me.Close()
    End Sub

    Private Sub btn_sign_Click(sender As Object, e As EventArgs) Handles btn_sign.Click

        If txt_username.Text <> String.Empty Then
            If txt_email.Text <> String.Empty Then
                If txt_password.Text <> String.Empty Then
                    If txt_repassword.Text <> String.Empty Then
                        If cmb_level.SelectedIndex = 2 And cmb_level.SelectedIndex <> 0 Then
                            LocalDB.ExecuteNonQuery("INSERT INTO LOGIN VALUES ('" & txt_username.Text & "','" & txt_email.Text & "','" & txt_password.Text & "','" & txt_repassword.Text & "','" & cmb_level.SelectedItem.ToString() & "') ")
                             MsgBox("Inserted !")
                        End If
                    End If
                End If

            End If
        End If

       
        Clear()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Public Sub Clear()
        txt_username.Text = String.Empty
        txt_email.Text = String.Empty
        txt_password.Text = String.Empty
        txt_repassword.Text = String.Empty
        txt_level.Text = String.Empty
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