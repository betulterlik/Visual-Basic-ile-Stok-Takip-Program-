Public Class DisplayPage

    Private Sub btn_take_Click(sender As Object, e As EventArgs) Handles btn_take.Click

        Dim bounds As Rectangle

        Dim screenshot As System.Drawing.Bitmap

        Dim graph As Graphics

        bounds = Screen.PrimaryScreen.Bounds

        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        graph = Graphics.FromImage(screenshot)

        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)

        pic_camera.Image = screenshot
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim savefiledialog1 As New SaveFileDialog
        Try
            savefiledialog1.Title = "Save File"
            savefiledialog1.FileName = "*.jpeg"
            savefiledialog1.Filter = "JPEG |*.jpeg"
            If savefiledialog1.ShowDialog() = DialogResult.OK Then
                pic_camera.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
        Catch ex As Exception 'Do Nothing
        End Try

    End Sub

    Private Sub DisplayPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (cmb_picture.Items.Count = 0) Then
            cmb_picture.Items.Add("Select type picture")
            cmb_picture.Items.Add(".jpg")
            cmb_picture.Items.Add(".png")
            cmb_picture.Items.Add(".gif")
            cmb_picture.Items.Add(".bmp")
            cmb_picture.SelectedIndex = 0

        End If

        'If cmb_picture.SelectedIndex = 0 Then

        '    btn_select.Visible = False
        '    btn_select.BackColor = Color.LightGray
        'ElseIf cmb_picture.SelectedIndex = 1 Then
        '    btn_select.Visible = True
        '    btn_select.BackColor = Color.LightCyan
        'ElseIf cmb_picture.SelectedIndex = 2 Then
        '    btn_select.Visible = True
        '    btn_select.BackColor = Color.LightCyan
        'ElseIf cmb_picture.SelectedIndex = 3 Then
        '    btn_select.Visible = True
        '    btn_select.BackColor = Color.LightCyan
        'ElseIf cmb_picture.SelectedIndex = 4 Then
        '    btn_select.Visible = True
        '    btn_select.BackColor = Color.LightCyan
        'Else

        'End If

    End Sub


    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        openFD.InitialDirectory = "C:\"
        openFD.Title = "Open a Text File"
        openFD.ShowDialog()
    
    End Sub

    Private Sub cmb_picture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_picture.SelectedIndexChanged

        If cmb_picture.SelectedIndex = 0 Then

            btn_select.Visible = False
            btn_select.BackColor = Color.LightGray
        ElseIf cmb_picture.SelectedIndex = 1 Then
            btn_select.Visible = True
            btn_select.BackColor = Color.LightCyan
        ElseIf cmb_picture.SelectedIndex = 2 Then
            btn_select.Visible = True
            btn_select.BackColor = Color.LightCyan
        ElseIf cmb_picture.SelectedIndex = 3 Then
            btn_select.Visible = True
            btn_select.BackColor = Color.LightCyan
        ElseIf cmb_picture.SelectedIndex = 4 Then
            btn_select.Visible = True
            btn_select.BackColor = Color.LightCyan
        Else

        End If
    End Sub
End Class