<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_guncelle = New System.Windows.Forms.Button()
        Me.btn_ekle = New System.Windows.Forms.Button()
        Me.btn_sil = New System.Windows.Forms.Button()
        Me.cmb_cinsiyet = New System.Windows.Forms.ComboBox()
        Me.btn_ara = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadBtn_csv = New System.Windows.Forms.RadioButton()
        Me.RadBtn_xlsx = New System.Windows.Forms.RadioButton()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.grd_personel = New System.Windows.Forms.DataGridView()
        Me.txt_dogumyeri = New System.Windows.Forms.TextBox()
        Me.txt_meslek = New System.Windows.Forms.TextBox()
        Me.txt_adsoyad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.PanelRight.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.grd_personel,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btn_guncelle
        '
        Me.btn_guncelle.AutoSize = true
        Me.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_guncelle.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_guncelle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_guncelle.Location = New System.Drawing.Point(383, 56)
        Me.btn_guncelle.Name = "btn_guncelle"
        Me.btn_guncelle.Size = New System.Drawing.Size(129, 33)
        Me.btn_guncelle.TabIndex = 5
        Me.btn_guncelle.Text = "Güncelle"
        Me.btn_guncelle.UseVisualStyleBackColor = false
        '
        'btn_ekle
        '
        Me.btn_ekle.AutoSize = true
        Me.btn_ekle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_ekle.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_ekle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_ekle.Location = New System.Drawing.Point(383, 12)
        Me.btn_ekle.Name = "btn_ekle"
        Me.btn_ekle.Size = New System.Drawing.Size(129, 33)
        Me.btn_ekle.TabIndex = 7
        Me.btn_ekle.Text = "Ekle"
        Me.btn_ekle.UseVisualStyleBackColor = false
        '
        'btn_sil
        '
        Me.btn_sil.AutoSize = true
        Me.btn_sil.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_sil.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_sil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_sil.Location = New System.Drawing.Point(385, 100)
        Me.btn_sil.Name = "btn_sil"
        Me.btn_sil.Size = New System.Drawing.Size(127, 33)
        Me.btn_sil.TabIndex = 8
        Me.btn_sil.Text = "Sil"
        Me.btn_sil.UseVisualStyleBackColor = false
        '
        'cmb_cinsiyet
        '
        Me.cmb_cinsiyet.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.cmb_cinsiyet.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.cmb_cinsiyet.FormattingEnabled = true
        Me.cmb_cinsiyet.Location = New System.Drawing.Point(121, 144)
        Me.cmb_cinsiyet.Name = "cmb_cinsiyet"
        Me.cmb_cinsiyet.Size = New System.Drawing.Size(246, 31)
        Me.cmb_cinsiyet.TabIndex = 16
        '
        'btn_ara
        '
        Me.btn_ara.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_ara.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.btn_ara.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.btn_ara.Location = New System.Drawing.Point(121, 201)
        Me.btn_ara.Name = "btn_ara"
        Me.btn_ara.Size = New System.Drawing.Size(95, 34)
        Me.btn_ara.TabIndex = 17
        Me.btn_ara.Text = "Filtrele"
        Me.btn_ara.UseVisualStyleBackColor = false
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.Button1.Location = New System.Drawing.Point(278, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Temizle"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 462)
        Me.Panel1.TabIndex = 22
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PanelRight)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 462)
        Me.Panel2.TabIndex = 23
        '
        'PanelRight
        '
        Me.PanelRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(52,Byte),Integer), CType(CType(81,Byte),Integer), CType(CType(114,Byte),Integer))
        Me.PanelRight.Controls.Add(Me.GroupBox1)
        Me.PanelRight.Controls.Add(Me.grd_personel)
        Me.PanelRight.Controls.Add(Me.Button1)
        Me.PanelRight.Controls.Add(Me.txt_dogumyeri)
        Me.PanelRight.Controls.Add(Me.btn_ara)
        Me.PanelRight.Controls.Add(Me.cmb_cinsiyet)
        Me.PanelRight.Controls.Add(Me.btn_sil)
        Me.PanelRight.Controls.Add(Me.btn_guncelle)
        Me.PanelRight.Controls.Add(Me.txt_meslek)
        Me.PanelRight.Controls.Add(Me.btn_ekle)
        Me.PanelRight.Controls.Add(Me.txt_adsoyad)
        Me.PanelRight.Controls.Add(Me.Label6)
        Me.PanelRight.Controls.Add(Me.Label5)
        Me.PanelRight.Controls.Add(Me.Label4)
        Me.PanelRight.Controls.Add(Me.Label8)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(522, 462)
        Me.PanelRight.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox1.Controls.Add(Me.RadBtn_csv)
        Me.GroupBox1.Controls.Add(Me.RadBtn_xlsx)
        Me.GroupBox1.Controls.Add(Me.btn_excel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(383, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 90)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "SAVE"
        '
        'RadBtn_csv
        '
        Me.RadBtn_csv.AutoSize = true
        Me.RadBtn_csv.Checked = true
        Me.RadBtn_csv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadBtn_csv.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.RadBtn_csv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.RadBtn_csv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadBtn_csv.Location = New System.Drawing.Point(16, 57)
        Me.RadBtn_csv.Name = "RadBtn_csv"
        Me.RadBtn_csv.Size = New System.Drawing.Size(51, 27)
        Me.RadBtn_csv.TabIndex = 35
        Me.RadBtn_csv.TabStop = true
        Me.RadBtn_csv.Text = ".csv"
        Me.RadBtn_csv.UseVisualStyleBackColor = true
        '
        'RadBtn_xlsx
        '
        Me.RadBtn_xlsx.AutoSize = true
        Me.RadBtn_xlsx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadBtn_xlsx.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        Me.RadBtn_xlsx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.RadBtn_xlsx.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadBtn_xlsx.Location = New System.Drawing.Point(16, 27)
        Me.RadBtn_xlsx.Name = "RadBtn_xlsx"
        Me.RadBtn_xlsx.Size = New System.Drawing.Size(55, 27)
        Me.RadBtn_xlsx.TabIndex = 36
        Me.RadBtn_xlsx.TabStop = true
        Me.RadBtn_xlsx.Text = ".xlsx"
        Me.RadBtn_xlsx.UseVisualStyleBackColor = true
        '
        'btn_excel
        '
        Me.btn_excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_excel.BackgroundImage = CType(resources.GetObject("btn_excel.BackgroundImage"),System.Drawing.Image)
        Me.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_excel.FlatAppearance.BorderSize = 0
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_excel.Location = New System.Drawing.Point(73, 37)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(48, 47)
        Me.btn_excel.TabIndex = 9
        Me.btn_excel.UseVisualStyleBackColor = true
        '
        'grd_personel
        '
        Me.grd_personel.AllowUserToAddRows = false
        Me.grd_personel.AllowUserToDeleteRows = false
        Me.grd_personel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.grd_personel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_personel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe Print", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_personel.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_personel.Location = New System.Drawing.Point(20, 290)
        Me.grd_personel.MultiSelect = false
        Me.grd_personel.Name = "grd_personel"
        Me.grd_personel.ReadOnly = true
        Me.grd_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_personel.Size = New System.Drawing.Size(492, 142)
        Me.grd_personel.TabIndex = 22
        '
        'txt_dogumyeri
        '
        Me.txt_dogumyeri.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_dogumyeri.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.txt_dogumyeri.Location = New System.Drawing.Point(121, 102)
        Me.txt_dogumyeri.Name = "txt_dogumyeri"
        Me.txt_dogumyeri.Size = New System.Drawing.Size(246, 30)
        Me.txt_dogumyeri.TabIndex = 10
        '
        'txt_meslek
        '
        Me.txt_meslek.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_meslek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_meslek.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.txt_meslek.Location = New System.Drawing.Point(121, 56)
        Me.txt_meslek.Name = "txt_meslek"
        Me.txt_meslek.Size = New System.Drawing.Size(246, 30)
        Me.txt_meslek.TabIndex = 9
        '
        'txt_adsoyad
        '
        Me.txt_adsoyad.BackColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.txt_adsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_adsoyad.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.txt_adsoyad.Location = New System.Drawing.Point(121, 12)
        Me.txt_adsoyad.Name = "txt_adsoyad"
        Me.txt_adsoyad.Size = New System.Drawing.Size(246, 30)
        Me.txt_adsoyad.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(16, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cinsiyet"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Doğum Yeri"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Meslek"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label8.Location = New System.Drawing.Point(16, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Ad Soyad"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.ClientSize = New System.Drawing.Size(727, 462)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.PanelRight.ResumeLayout(false)
        Me.PanelRight.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.grd_personel,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btn_guncelle As Button
    Friend WithEvents btn_ekle As Button
    Friend WithEvents btn_sil As Button
    Friend WithEvents cmb_cinsiyet As ComboBox
    Friend WithEvents btn_ara As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents txt_dogumyeri As TextBox
    Friend WithEvents txt_meslek As TextBox
    Friend WithEvents txt_adsoyad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grd_personel As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadBtn_csv As RadioButton
    Friend WithEvents RadBtn_xlsx As RadioButton
    Friend WithEvents btn_excel As Button
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents SFD As SaveFileDialog
End Class
