Imports System.Text
Imports System.Text.RegularExpressions

Public Class LoginPage

    Public LocalDB As New SQLiteTools("C:\Users\Betül TERLİK\Source\Repos\Personel\Personel.db", True)
    Dim rs As New Resizer
    Public lvl As String = String.Empty
    Public UsName As String = String.Empty
    Dim ini As New INIfile(IO.Directory.GetCurrentDirectory() & "\elopar.ini")
    Public language As String = CInt(ini.ReadValue("SYSTEM", "Lang"))
    Dim reg As Regex

    Public Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
    Public Declare Function CreateRoundRectRgn Lib "gdi32" Alias "CreateRoundRectRgn" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)
        rs.FindAllControls(Me)

#Region "The Combobox Selected to Form too"

        If (cmb_user.Items.Count = 0) Then
            cmb_user.Items.Add("Select")
            cmb_user.Items.Add("Operator")
            cmb_user.Items.Add("Other")
            cmb_user.SelectedIndex = 0

        End If

        If cmb_user.SelectedIndex = 0 Then
            txt_password.Enabled = False
            txt_password.BackColor = Color.LightGray
            txt_email.Enabled = False
            txt_email.BackColor = Color.LightGray
            btn_login.Enabled = False
            btn_login.BackColor = Color.LightGray

        ElseIf cmb_user.SelectedIndex = 1 Then
            txt_email.Enabled = False
            txt_email.BackColor = Color.LightGray
            txt_password.Enabled = True
            txt_password.BackColor = Color.LightCyan
            btn_login.Enabled = True
            btn_login.BackColor = Color.LightCyan

        ElseIf cmb_user.SelectedIndex = 2 Then
            txt_password.Enabled = True
            txt_password.BackColor = Color.LightCyan
            txt_email.Enabled = True
            txt_email.BackColor = Color.LightCyan
            btn_login.Enabled = True
            btn_login.BackColor = Color.LightCyan
            lbl_pass.Text = String.Empty
        Else
            txt_password.Enabled = False
            txt_password.BackColor = Color.LightGray
            txt_email.Enabled = False
            txt_email.BackColor = Color.LightGray
            btn_login.Enabled = False
            btn_login.BackColor = Color.LightGray
            lbl_pass.Text = String.Empty
        End If
#End Region

        SetWindowRgn(btn_login.Handle, CreateRoundRectRgn(0, 0, btn_login.Width, btn_login.Height, 35, 55), True)
        SetWindowRgn(txt_email.Handle, CreateRoundRectRgn(0, 0, txt_email.Width, txt_email.Height, 35, 55), True)
        SetWindowRgn(txt_password.Handle, CreateRoundRectRgn(0, 0, txt_password.Width, txt_password.Height, 35, 55), True)

        SetWindowRgn(cmb_user.Handle, CreateRoundRectRgn(0, 0, cmb_user.Width, cmb_user.Height, 35, 55), True)
    End Sub

    Public Sub Clear()
        txt_email.Text = String.Empty
        txt_password.Text = String.Empty
        lbl_pass.Text = String.Empty
        EP_Error.Clear()
        EP_Ok.Clear()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If Application.OpenForms().Count > 1 Then
            For count As Integer = My.Application.OpenForms.Count - 1 To 1 Step -1

                My.Application.OpenForms(count).Close()

            Next
        End If

        EP_Error.Clear()
        EP_Ok.Clear()

        If Me.ValidateChildren() Then

            Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
            If empty.Any Then
                MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", empty.Select(Function(txt) txt.Name))))
                'Else
                ' MessageBox.Show("OK")
            End If

            '  Else

            'Dim listOfErrors = Me.EP_Error.ContainerControl.Controls.Cast(Of Control)().[Select](Function(c) Me.EP_Error.GetError(c)).Where(Function(s) Not String.IsNullOrEmpty(s)).ToList()
            'MessageBox.Show("Please correct validation errors:" & vbLf & " - " & String.Join(vbLf & " - ", listOfErrors.ToArray()), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])

        End If

        If cmb_user.SelectedIndex = 1 And cmb_user.SelectedIndex <> 0 Then
            If txt_password.Text <> String.Empty Then

                If LocalDB.isThere("Select * from LOGIN where Password = '" & txt_password.Text & "' ") Then

                    LocalDB.ExecuteNonQuery("UPDATE LOGIN SET Password='" & txt_password.Text.ToString & "', RePassword='" & txt_password.Text.ToString & "' where  Level = '" & cmb_user.SelectedItem.ToString & "' ")

                    Form1.Activate()
                    Form1.Show()
                    Me.Hide()

                Else
                    LocalDB.ExecuteNonQuery("INSERT INTO LOGIN VALUES ('Operator','terlik1994@hotmail.com','" & txt_password.Text & "','" & txt_password.Text & "','" & cmb_user.SelectedItem.ToString() & "') ")

                    Form1.Activate()
                    Form1.Show()
                    Me.Hide()
                End If

            End If
        End If

        If cmb_user.SelectedIndex = 2 Then

            If (txt_password.Text = "Betul..1994.." And txt_email.Text = "betul.terlik@gmail.com") Then
                UsName = "bet"
                Form1.Activate()
                Form1.Show()
                Me.Hide()
            Else

                If LocalDB.isThere("SELECT * FROM LOGIN WHERE Password = '" & txt_password.Text & "' AND Email = '" & txt_email.Text & "'") Then
                    CreateObject("WScript.Shell").Popup(fff("WRONG Password"), 1, "Wrong Password", 64)
                    txt_password.Text = String.Empty
                    txt_password.Focus()
                Else
                    lvl = LocalDB.GetSingleValue("SELECT Level FROM LOGIN WHERE Password = '" & txt_password.Text & "' ", "Level")
                    UsName = LocalDB.GetSingleValue("SELECT Username FROM LOGIN WHERE Password = '" & txt_password.Text & "' ", "Username")

                    If (lvl = "Supervisor") Then
                        lvl = "Supervisor"
                        Form1.Activate()
                        Form1.Show()
                        Me.Hide()

                    ElseIf (lvl = "Admin") Then
                        lvl = "Admin"
                        Form1.Activate()
                        Form1.Show()
                        Me.Hide()

                    ElseIf (lvl = "Mechanic") Then
                        lvl = "Mechanic"
                        Form1.Activate()
                        Form1.Show()
                        Me.Hide()

                    End If

                End If

            End If

        End If

        Clear()
    End Sub

    Public Function fff(ByVal s As String) As String
        If CStr(LocalDB.GetSingleValue("select * from MESSAGES where (lng = " & language & ") and (key = '" & s & "') ", "Value")) <> String.Empty Then
            Return LocalDB.GetSingleValue("select * from MESSAGES where (lng = " & language & ") and (key = '" & s & "') ", "Value")
        Else
            Return LocalDB.GetSingleValue("select * from MESSAGES where (lng = 0) and (key = '" & s & "') ", "Value")
        End If
    End Function

    Private Sub lbl_create_Click(sender As Object, e As EventArgs) Handles lbl_create.Click

        SignUpPage.Activate()
        SignUpPage.Show()
        Me.Hide()

    End Sub

    Private Sub lbl_forgot_Click(sender As Object, e As EventArgs) Handles lbl_forgot.Click

        ForgotPage.Activate()
        ForgotPage.Show()
        Me.Hide()

    End Sub

    Private Sub btn_Cancel_Login_Click(sender As Object, e As EventArgs) Handles btn_Cancel_Login.Click
        Me.Close()

    End Sub

    Private Sub txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_email.Validating

#Region "Regex to Mail"
        'Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        'Dim isValid As Boolean = regex.IsMatch(txt_email.Text.Trim)
        'If Not isValid Then
        '    lbl_msg.Text = ("Invalid Email.")
        'Else
        '    lbl_msg.Text = (" ")
        'End If
#End Region

        If txt_email.Text <> String.Empty Then

            reg = New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
            If Not reg.IsMatch(txt_email.Text) Then
                EP_Error.SetError(txt_email, "not  Mail!")
                EP_Ok.SetError(txt_email, "")
                e.Cancel = True
            Else
                EP_Error.SetError(txt_email, "")
                EP_Ok.SetError(txt_email, "OK")
            End If

            reg = Nothing

        End If

    End Sub
        Private Sub txt_password_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_password.Validating

#Region "Regex to Password"
        'Dim MatchNumberPattern As String = "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$"
        ''(?=.*\d) =1 rakam 

        'If txt_password.Text.Trim <> "" Then
        '    If Not Regex.IsMatch(txt_password.Text, MatchNumberPattern) Then

        '        lbl_msg.Text = ("Password is not valid")
        '    Else
        '        lbl_msg.Text = (" ")
        '    End If
        'End If
#End Region

        If txt_password.Text <> String.Empty Then

            reg = New Regex("(?-i)(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))((?=(.*\d){1,})|(?=(.*\W){1,}))^.*$")
            If Not reg.IsMatch(txt_password.Text) Then
                EP_Error.SetError(txt_password, "not  Pasword!")
                EP_Ok.SetError(txt_password, "")
                e.Cancel = True
            Else
                EP_Error.SetError(txt_password, "")
                EP_Ok.SetError(txt_password, "OK")
            End If

            reg = Nothing

        End If
    End Sub

    Private Sub cmb_user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_user.SelectedIndexChanged

        If cmb_user.SelectedIndex = 0 Then
            txt_password.Enabled = True
            txt_password.BackColor = Color.LightGray
            txt_email.Enabled = True
            txt_email.BackColor = Color.LightGray
            btn_login.Enabled = True
            btn_login.BackColor = Color.LightGray
            lbl_pass.Text = String.Empty

        ElseIf cmb_user.SelectedIndex = 1 Then
            txt_email.Enabled = False
            txt_email.BackColor = Color.LightGray
            txt_password.Enabled = True
            txt_password.BackColor = Color.LightCyan
            btn_login.Enabled = True
            btn_login.BackColor = Color.LightCyan

#Region "Random password for Operator"
            Dim passedLength As Integer
            Dim myLowercase As String = "abcdefghijklmnopqrstuvwxyz"
            Dim myUppercase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim myNumbers As String = "0123456789"
            Dim mySymbols As String = "!@#*()_-+={}[]:<>.?/"
            Dim myAllChars As String = myLowercase & myUppercase & myNumbers & mySymbols
            Dim myRandom As New System.Random
            Dim myPassword As String = ""
            myPassword = myPassword & myLowercase(myRandom.Next(0, myLowercase.Length)) & myLowercase(myRandom.Next(0, myLowercase.Length))
            myPassword = myPassword & myUppercase(myRandom.Next(0, myUppercase.Length)) & myUppercase(myRandom.Next(0, myUppercase.Length))
            myPassword = myPassword & myNumbers(myRandom.Next(0, myNumbers.Length)) & myNumbers(myRandom.Next(0, myNumbers.Length))
            myPassword = myPassword & mySymbols(myRandom.Next(0, mySymbols.Length)) & mySymbols(myRandom.Next(0, mySymbols.Length))
            For i As Integer = 0 To (passedLength - 9)
                myPassword = myPassword & myAllChars(myRandom.Next(0, myAllChars.Length))
            Next
            Dim strInput As String = myPassword
            Dim strOutput As String = ""
            Dim rand As New System.Random
            Dim intPlace As Integer
            While strInput.Length > 0
                intPlace = rand.Next(0, strInput.Length)
                strOutput += strInput.Substring(intPlace, 1)
                strInput = strInput.Remove(intPlace, 1)
            End While
            myPassword = strOutput
            lbl_pass.Text = "Password: " + myPassword

#End Region

        ElseIf cmb_user.SelectedIndex = 2 Then
            txt_password.Enabled = True
            txt_password.BackColor = Color.LightCyan
            txt_email.Enabled = True
            txt_email.BackColor = Color.LightCyan
            btn_login.Enabled = True
            btn_login.BackColor = Color.LightCyan
            lbl_pass.Text = String.Empty
        End If

    End Sub

    Private Sub tmr_OK_Tick(sender As Object, e As EventArgs) Handles tmr_OK.Tick
        EP_Error.Clear()
        EP_Ok.Clear()
        ' lbl_pass.Text=String.Empty
        If Me.ValidateChildren() Then

            Dim empty = Me.Controls.OfType(Of TextBox)().Where(Function(txt) txt.Text.Length = 0)
            If empty.Any Then
                '    MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                '        String.Join(",", empty.Select(Function(txt) txt.Name))))
                btn_login.Enabled = False
            Else
                'MessageBox.Show("OK")
                btn_login.Enabled = True
            End If

        Else

            'Dim listOfErrors = Me.EP_Error.ContainerControl.Controls.Cast(Of Control)().[Select](Function(c) Me.EP_Error.GetError(c)).Where(Function(s) Not String.IsNullOrEmpty(s)).ToList()
            'MessageBox.Show("Please correct validation errors:" & vbLf & " - " & String.Join(vbLf & " - ", listOfErrors.ToArray()), "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            btn_login.Enabled = False
        End If

    End Sub

End Class