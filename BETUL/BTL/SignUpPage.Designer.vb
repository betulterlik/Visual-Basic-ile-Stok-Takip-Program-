<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpPage))
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.txt_level = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Cancel_Login = New System.Windows.Forms.Button()
        Me.btn_sign = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_repassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.PanelLeft.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelRight.SuspendLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(226, 538)
        Me.PanelLeft.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 153)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "  Welcome "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      to"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Sign Up Page"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.PanelRight.Controls.Add(Me.cmb_level)
        Me.PanelRight.Controls.Add(Me.lbl_msg)
        Me.PanelRight.Controls.Add(Me.txt_level)
        Me.PanelRight.Controls.Add(Me.Label8)
        Me.PanelRight.Controls.Add(Me.btn_Cancel_Login)
        Me.PanelRight.Controls.Add(Me.btn_sign)
        Me.PanelRight.Controls.Add(Me.PictureBox2)
        Me.PanelRight.Controls.Add(Me.txt_email)
        Me.PanelRight.Controls.Add(Me.txt_repassword)
        Me.PanelRight.Controls.Add(Me.txt_password)
        Me.PanelRight.Controls.Add(Me.txt_username)
        Me.PanelRight.Controls.Add(Me.Label7)
        Me.PanelRight.Controls.Add(Me.Label6)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.Label4)
        Me.PanelRight.Controls.Add(Me.Label2)
        Me.PanelRight.Controls.Add(Me.Label3)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(226, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(388, 538)
        Me.PanelRight.TabIndex = 1
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = true
        Me.lbl_msg.Font = New System.Drawing.Font("Segoe Print", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_msg.Location = New System.Drawing.Point(210, 469)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(0, 21)
        Me.lbl_msg.TabIndex = 25
        '
        'txt_level
        '
        Me.txt_level.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_level.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_level.Location = New System.Drawing.Point(71, 304)
        Me.txt_level.Name = "txt_level"
        Me.txt_level.Size = New System.Drawing.Size(40, 34)
        Me.txt_level.TabIndex = 24
        Me.txt_level.Visible = false
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 28)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Role"
        '
        'btn_Cancel_Login
        '
        Me.btn_Cancel_Login.BackgroundImage = CType(resources.GetObject("btn_Cancel_Login.BackgroundImage"),System.Drawing.Image)
        Me.btn_Cancel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Cancel_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancel_Login.FlatAppearance.BorderSize = 0
        Me.btn_Cancel_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.btn_Cancel_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel_Login.Location = New System.Drawing.Point(352, 9)
        Me.btn_Cancel_Login.Name = "btn_Cancel_Login"
        Me.btn_Cancel_Login.Size = New System.Drawing.Size(24, 26)
        Me.btn_Cancel_Login.TabIndex = 22
        '
        'btn_sign
        '
        Me.btn_sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_sign.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btn_sign.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_sign.Location = New System.Drawing.Point(118, 404)
        Me.btn_sign.Name = "btn_sign"
        Me.btn_sign.Size = New System.Drawing.Size(235, 49)
        Me.btn_sign.TabIndex = 13
        Me.btn_sign.Text = "Sign Up"
        Me.btn_sign.UseVisualStyleBackColor = false
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 357)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = false
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_email.Location = New System.Drawing.Point(118, 242)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(235, 34)
        Me.txt_email.TabIndex = 11
        '
        'txt_repassword
        '
        Me.txt_repassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_repassword.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_repassword.Location = New System.Drawing.Point(118, 179)
        Me.txt_repassword.Name = "txt_repassword"
        Me.txt_repassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repassword.Size = New System.Drawing.Size(235, 34)
        Me.txt_repassword.TabIndex = 10
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_password.Location = New System.Drawing.Point(118, 116)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(235, 34)
        Me.txt_password.TabIndex = 9
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.txt_username.Location = New System.Drawing.Point(118, 55)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(235, 34)
        Me.txt_username.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label7.Location = New System.Drawing.Point(59, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(310, 33)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "I Agree Terms and Conditions"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email "
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 56)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Return"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Password "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password "
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sign Up"
        '
        'cmb_level
        '
        Me.cmb_level.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.cmb_level.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.cmb_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.cmb_level.FormattingEnabled = true
        Me.cmb_level.Location = New System.Drawing.Point(118, 304)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(235, 34)
        Me.cmb_level.TabIndex = 26
        '
        'SignUpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(614, 538)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "SignUpPage"
        Me.Text = "BasicDesign"
        Me.PanelLeft.ResumeLayout(false)
        Me.PanelLeft.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelRight.ResumeLayout(false)
        Me.PanelRight.PerformLayout
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_repassword As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_sign As Button
    Friend WithEvents btn_Cancel_Login As Button
    Friend WithEvents txt_level As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_msg As Label
    Friend WithEvents cmb_level As ComboBox
End Class
