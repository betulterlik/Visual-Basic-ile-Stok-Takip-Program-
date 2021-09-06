Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Drawing.Color

Public Class TEST
    Public Property Membership As Object
    Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
    Private Declare Function CreateRoundRectRgn Lib "gdi32" Alias "CreateRoundRectRgn" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer

#Region " windows mesajı"
    Const TEST_ET As Integer = &H84
    Const YAKALA As Integer = &H1
    Const BASLIK As Integer = &H2
#End Region

    Private Sub btn_guid_Click(sender As Object, e As EventArgs) Handles btn_guid.Click
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        ' MessageBox.Show(sGUID)
        lbl_pass.Text = sGUID
    End Sub

    Private Sub btn_ramdonsayi_Click(sender As Object, e As EventArgs) Handles btn_ramdonsayi.Click

#Region "Random Sayı Üretme"
        'Dim tempPassword As String = Membership.GeneratePassword(15, 0)
        'tempPassword = Regex.Replace(tempPassword, "[^a-zA-Z0-9]", Function(m) "9")
        'MessageBox.Show(tempPassword)


        'Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghiklmnoprstuvyz!@#$%^&*()"
        'Dim r As New Random
        'Dim sb As New StringBuilder
        'For i As Integer = 1 To 8
        '    Dim idx As Integer = r.Next(0, 63)
        '    sb.Append(s.Substring(idx, 1))
        'Next
        'lbl_pass.Text = "Password : " + sb.ToString()
#End Region
       
        Dim passedLength As Integer
        Dim myLowercase As String = "abcdefghijklmnopqrstuvwxyz"
        Dim myUppercase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim myNumbers As String = "0123456789"
        Dim mySymbols As String = "~!@#$^*()_-+={}[]:;<>,.?/"
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
        lbl_pass.Text = myPassword

    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case TEST_ET
                MyBase.WndProc(m)
                If m.Result = YAKALA Then m.Result = BASLIK
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    'FORMU YUVARLAK YAPMAK
    'Private Sub TEST_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim Tempshape As New System.Drawing.Drawing2D.GraphicsPath()
    '    Tempshape.AddEllipse(0, 0, Me.Width, Me.Height)
    '    Me.Region = New System.Drawing.Region(Tempshape)
    'End Sub

    Private Sub TEST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetWindowRgn(Me.Handle, CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 55, 55), True)

        SetWindowRgn(Button2.Handle, CreateRoundRectRgn(0, 0, Button2.Width, Button2.Height, 25, 55), True)
    End Sub



    Private Function Control() As Color
        Throw New NotImplementedException
    End Function

    Private Sub Button1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.Close()
        Else
            If Me.BackColor = Color.Red Then
                Me.BackColor = Color.RoyalBlue
            Else

                Me.BackColor = Violet
            End If

        End If
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Dim tooltip As New ToolTip()
        tooltip.SetToolTip(Button1, "Kapatmak için sağ fare tuşunu kullan")
    End Sub

    Private Sub TEST_DoubleClick(sender As System.Object, e As System.EventArgs) Handles MyBase.DoubleClick
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        'MessageBox.Show(sGUID)
        lbl_pass.Text = sGUID
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

