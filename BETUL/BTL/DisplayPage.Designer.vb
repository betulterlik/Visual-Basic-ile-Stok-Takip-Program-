<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayPage))
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.cmb_picture = New System.Windows.Forms.ComboBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.pic_camera = New System.Windows.Forms.PictureBox()
        Me.btn_take = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.PanelRight.SuspendLayout
        CType(Me.pic_camera,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.PanelRight.Controls.Add(Me.btn_select)
        Me.PanelRight.Controls.Add(Me.cmb_picture)
        Me.PanelRight.Controls.Add(Me.btn_save)
        Me.PanelRight.Controls.Add(Me.pic_camera)
        Me.PanelRight.Controls.Add(Me.btn_take)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(615, 473)
        Me.PanelRight.TabIndex = 2
        '
        'btn_select
        '
        Me.btn_select.AutoSize = true
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_select.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_select.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_select.Location = New System.Drawing.Point(386, 12)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(135, 33)
        Me.btn_select.TabIndex = 13
        Me.btn_select.Text = "Select Picture"
        Me.btn_select.UseVisualStyleBackColor = false
        '
        'cmb_picture
        '
        Me.cmb_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.cmb_picture.Font = New System.Drawing.Font("Segoe Print", 11.25!)
        Me.cmb_picture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.cmb_picture.FormattingEnabled = true
        Me.cmb_picture.Location = New System.Drawing.Point(171, 12)
        Me.cmb_picture.Name = "cmb_picture"
        Me.cmb_picture.Size = New System.Drawing.Size(177, 34)
        Me.cmb_picture.TabIndex = 12
        '
        'btn_save
        '
        Me.btn_save.AutoSize = true
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_save.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_save.Location = New System.Drawing.Point(171, 78)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(135, 33)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save a Picture"
        Me.btn_save.UseVisualStyleBackColor = false
        '
        'pic_camera
        '
        Me.pic_camera.Location = New System.Drawing.Point(22, 170)
        Me.pic_camera.Name = "pic_camera"
        Me.pic_camera.Size = New System.Drawing.Size(471, 200)
        Me.pic_camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_camera.TabIndex = 10
        Me.pic_camera.TabStop = false
        '
        'btn_take
        '
        Me.btn_take.AutoSize = true
        Me.btn_take.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_take.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_take.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_take.Location = New System.Drawing.Point(22, 12)
        Me.btn_take.Name = "btn_take"
        Me.btn_take.Size = New System.Drawing.Size(135, 33)
        Me.btn_take.TabIndex = 9
        Me.btn_take.Text = "Take a Picture"
        Me.btn_take.UseVisualStyleBackColor = false
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PanelRight)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 473)
        Me.Panel2.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 473)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 129)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "  Welcome "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"      to"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Form Page"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'openFD
        '
        Me.openFD.FileName = "Picture"
        '
        'DisplayPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 473)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DisplayPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DisplayPage"
        Me.PanelRight.ResumeLayout(false)
        Me.PanelRight.PerformLayout
        CType(Me.pic_camera,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PanelRight As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_save As Button
    Friend WithEvents pic_camera As PictureBox
    Friend WithEvents btn_take As Button
    Friend WithEvents cmb_picture As ComboBox
    Friend WithEvents btn_select As Button
    Friend WithEvents openFD As OpenFileDialog
End Class
