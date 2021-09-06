<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_user = New System.Windows.Forms.ComboBox()
        Me.btn_Cancel_Login = New System.Windows.Forms.Button()
        Me.lbl_create = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_forgot = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EP_Error = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EP_Ok = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmr_OK = New System.Windows.Forms.Timer(Me.components)
        Me.PanelRight.SuspendLayout
        Me.PanelLeft.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EP_Error,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EP_Ok,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.PanelRight.Controls.Add(Me.lbl_pass)
        Me.PanelRight.Controls.Add(Me.Label2)
        Me.PanelRight.Controls.Add(Me.cmb_user)
        Me.PanelRight.Controls.Add(Me.btn_Cancel_Login)
        Me.PanelRight.Controls.Add(Me.lbl_create)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.lbl_forgot)
        Me.PanelRight.Controls.Add(Me.btn_login)
        Me.PanelRight.Controls.Add(Me.txt_email)
        Me.PanelRight.Controls.Add(Me.txt_password)
        Me.PanelRight.Controls.Add(Me.Label6)
        Me.PanelRight.Controls.Add(Me.Label4)
        Me.PanelRight.Controls.Add(Me.Label3)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(226, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(374, 513)
        Me.PanelRight.TabIndex = 3
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = true
        Me.lbl_pass.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.lbl_pass.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_pass.Location = New System.Drawing.Point(31, 385)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(0, 26)
        Me.lbl_pass.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 33)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "User Type"
        '
        'cmb_user
        '
        Me.cmb_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.cmb_user.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.cmb_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.cmb_user.FormattingEnabled = true
        Me.cmb_user.Location = New System.Drawing.Point(124, 91)
        Me.cmb_user.Name = "cmb_user"
        Me.cmb_user.Size = New System.Drawing.Size(208, 34)
        Me.cmb_user.TabIndex = 0
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
        Me.btn_Cancel_Login.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Cancel_Login.Location = New System.Drawing.Point(314, 22)
        Me.btn_Cancel_Login.Name = "btn_Cancel_Login"
        Me.btn_Cancel_Login.Size = New System.Drawing.Size(30, 32)
        Me.btn_Cancel_Login.TabIndex = 21
        '
        'lbl_create
        '
        Me.lbl_create.AutoSize = true
        Me.lbl_create.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.lbl_create.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_create.Location = New System.Drawing.Point(192, 426)
        Me.lbl_create.Name = "lbl_create"
        Me.lbl_create.Size = New System.Drawing.Size(85, 23)
        Me.lbl_create.TabIndex = 4
        Me.lbl_create.Text = "Create One"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Don't have an account ? "
        '
        'lbl_forgot
        '
        Me.lbl_forgot.AutoSize = true
        Me.lbl_forgot.Font = New System.Drawing.Font("Segoe Print", 9!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.lbl_forgot.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_forgot.Location = New System.Drawing.Point(214, 226)
        Me.lbl_forgot.Name = "lbl_forgot"
        Me.lbl_forgot.Size = New System.Drawing.Size(128, 21)
        Me.lbl_forgot.TabIndex = 5
        Me.lbl_forgot.Text = "Forgot Password ? "
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_login.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_login.Location = New System.Drawing.Point(12, 327)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(330, 49)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = false
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.txt_email.Location = New System.Drawing.Point(12, 171)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(330, 34)
        Me.txt_email.TabIndex = 1
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.txt_password.Location = New System.Drawing.Point(12, 253)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(330, 34)
        Me.txt_password.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 33)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Password "
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login Page"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(226, 513)
        Me.PanelLeft.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 153)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Welcome "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      to "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Login Page"
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
        'EP_Error
        '
        Me.EP_Error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP_Error.ContainerControl = Me
        Me.EP_Error.Icon = CType(resources.GetObject("EP_Error.Icon"),System.Drawing.Icon)
        '
        'EP_Ok
        '
        Me.EP_Ok.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP_Ok.ContainerControl = Me
        Me.EP_Ok.Icon = CType(resources.GetObject("EP_Ok.Icon"),System.Drawing.Icon)
        '
        'tmr_OK
        '
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(600, 513)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.Text = "LoginPage"
        Me.PanelRight.ResumeLayout(false)
        Me.PanelRight.PerformLayout
        Me.PanelLeft.ResumeLayout(false)
        Me.PanelLeft.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EP_Error,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EP_Ok,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PanelRight As Panel
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_create As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_forgot As Label
    Friend WithEvents btn_Cancel_Login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_user As ComboBox
    Friend WithEvents EP_Error As ErrorProvider
    Friend WithEvents EP_Ok As ErrorProvider
    Friend WithEvents tmr_OK As Timer
    Friend WithEvents lbl_pass As Label
End Class
