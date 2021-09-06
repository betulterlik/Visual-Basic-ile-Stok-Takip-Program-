<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.btn_Cancel_Login = New System.Windows.Forms.Button()
        Me.lbl_create = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_repassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.lbl_msg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelRight.SuspendLayout
        Me.PanelLeft.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 153)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "  Welcome "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      to"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&" Forgot Page"
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
        Me.PanelRight.Controls.Add(Me.lbl_msg)
        Me.PanelRight.Controls.Add(Me.btn_Cancel_Login)
        Me.PanelRight.Controls.Add(Me.lbl_create)
        Me.PanelRight.Controls.Add(Me.Label2)
        Me.PanelRight.Controls.Add(Me.btn_update)
        Me.PanelRight.Controls.Add(Me.txt_email)
        Me.PanelRight.Controls.Add(Me.txt_repassword)
        Me.PanelRight.Controls.Add(Me.txt_password)
        Me.PanelRight.Controls.Add(Me.Label6)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.Label4)
        Me.PanelRight.Controls.Add(Me.Label3)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(226, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(374, 450)
        Me.PanelRight.TabIndex = 3
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
        Me.btn_Cancel_Login.Location = New System.Drawing.Point(332, 9)
        Me.btn_Cancel_Login.Name = "btn_Cancel_Login"
        Me.btn_Cancel_Login.Size = New System.Drawing.Size(30, 32)
        Me.btn_Cancel_Login.TabIndex = 21
        '
        'lbl_create
        '
        Me.lbl_create.AutoSize = true
        Me.lbl_create.Font = New System.Drawing.Font("Segoe Print", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.lbl_create.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_create.Location = New System.Drawing.Point(251, 378)
        Me.lbl_create.Name = "lbl_create"
        Me.lbl_create.Size = New System.Drawing.Size(93, 23)
        Me.lbl_create.TabIndex = 18
        Me.lbl_create.Text = "Login Page ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 17
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_update.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_update.Location = New System.Drawing.Point(14, 312)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(330, 49)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Password Refresh"
        Me.btn_update.UseVisualStyleBackColor = false
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_email.Location = New System.Drawing.Point(14, 91)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(330, 34)
        Me.txt_email.TabIndex = 11
        '
        'txt_repassword
        '
        Me.txt_repassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_repassword.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_repassword.Location = New System.Drawing.Point(14, 239)
        Me.txt_repassword.Name = "txt_repassword"
        Me.txt_repassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repassword.Size = New System.Drawing.Size(330, 34)
        Me.txt_repassword.TabIndex = 10
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.txt_password.Location = New System.Drawing.Point(14, 164)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(330, 34)
        Me.txt_password.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email "
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Re-Enter Password "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 128)
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
        Me.Label3.Size = New System.Drawing.Size(183, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Forgot Page"
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(226, 450)
        Me.PanelLeft.TabIndex = 2
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = true
        Me.lbl_msg.Font = New System.Drawing.Font("Segoe Print", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_msg.Location = New System.Drawing.Point(77, 396)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(0, 21)
        Me.lbl_msg.TabIndex = 23
        '
        'ForgotPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPage"
        Me.Text = "ForgotPage"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelRight.ResumeLayout(false)
        Me.PanelRight.PerformLayout
        Me.PanelLeft.ResumeLayout(false)
        Me.PanelLeft.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRight As Panel
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_repassword As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents lbl_create As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Cancel_Login As Button
    Friend WithEvents lbl_msg As Label
End Class
