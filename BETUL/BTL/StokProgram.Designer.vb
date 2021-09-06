<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StokProgram
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStokAdiAra = New System.Windows.Forms.Button()
        Me.btnStokModelAra = New System.Windows.Forms.Button()
        Me.btnResimSil = New System.Windows.Forms.Button()
        Me.btnResimEkle = New System.Windows.Forms.Button()
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.btnStokGuncelle = New System.Windows.Forms.Button()
        Me.btnStokSil = New System.Windows.Forms.Button()
        Me.btnStokEkle = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_kayit = New System.Windows.Forms.TextBox()
        Me.txt_ad = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_serino = New System.Windows.Forms.TextBox()
        Me.txt_adet = New System.Windows.Forms.TextBox()
        Me.dt_tarih = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_modelara = New System.Windows.Forms.TextBox()
        Me.txt_stokadiara = New System.Windows.Forms.TextBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdStok = New System.Windows.Forms.DataGridView()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.grdStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.pictureBox1)
        Me.groupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.groupBox2.Location = New System.Drawing.Point(720, 36)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox2.Size = New System.Drawing.Size(267, 245)
        Me.groupBox2.TabIndex = 110
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "RESİM EKLEME"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(40, 28)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(196, 192)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 26
        Me.pictureBox1.TabStop = False
        '
        'btnStokAdiAra
        '
        Me.btnStokAdiAra.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStokAdiAra.Location = New System.Drawing.Point(544, 77)
        Me.btnStokAdiAra.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStokAdiAra.Name = "btnStokAdiAra"
        Me.btnStokAdiAra.Size = New System.Drawing.Size(148, 70)
        Me.btnStokAdiAra.TabIndex = 93
        Me.btnStokAdiAra.Text = "ARA"
        Me.btnStokAdiAra.UseVisualStyleBackColor = False
        '
        'btnStokModelAra
        '
        Me.btnStokModelAra.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStokModelAra.Location = New System.Drawing.Point(544, 220)
        Me.btnStokModelAra.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStokModelAra.Name = "btnStokModelAra"
        Me.btnStokModelAra.Size = New System.Drawing.Size(148, 70)
        Me.btnStokModelAra.TabIndex = 95
        Me.btnStokModelAra.Text = "ARA"
        Me.btnStokModelAra.UseVisualStyleBackColor = False
        '
        'btnResimSil
        '
        Me.btnResimSil.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResimSil.Location = New System.Drawing.Point(869, 306)
        Me.btnResimSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResimSil.Name = "btnResimSil"
        Me.btnResimSil.Size = New System.Drawing.Size(129, 70)
        Me.btnResimSil.TabIndex = 109
        Me.btnResimSil.Text = "RESİM SİL"
        Me.btnResimSil.UseVisualStyleBackColor = False
        '
        'btnResimEkle
        '
        Me.btnResimEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResimEkle.Location = New System.Drawing.Point(728, 306)
        Me.btnResimEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResimEkle.Name = "btnResimEkle"
        Me.btnResimEkle.Size = New System.Drawing.Size(129, 70)
        Me.btnResimEkle.TabIndex = 108
        Me.btnResimEkle.Text = "RESİM EKLE"
        Me.btnResimEkle.UseVisualStyleBackColor = False
        '
        'btnCikis
        '
        Me.btnCikis.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCikis.Location = New System.Drawing.Point(503, 306)
        Me.btnCikis.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(157, 70)
        Me.btnCikis.TabIndex = 107
        Me.btnCikis.Text = "ÇIKIŞ"
        Me.btnCikis.UseVisualStyleBackColor = False
        '
        'btnStokGuncelle
        '
        Me.btnStokGuncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStokGuncelle.Location = New System.Drawing.Point(338, 306)
        Me.btnStokGuncelle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStokGuncelle.Name = "btnStokGuncelle"
        Me.btnStokGuncelle.Size = New System.Drawing.Size(157, 70)
        Me.btnStokGuncelle.TabIndex = 106
        Me.btnStokGuncelle.Text = "STOK GÜNCELLE"
        Me.btnStokGuncelle.UseVisualStyleBackColor = False
        '
        'btnStokSil
        '
        Me.btnStokSil.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStokSil.Location = New System.Drawing.Point(181, 306)
        Me.btnStokSil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStokSil.Name = "btnStokSil"
        Me.btnStokSil.Size = New System.Drawing.Size(157, 70)
        Me.btnStokSil.TabIndex = 105
        Me.btnStokSil.Text = "STOK SİL"
        Me.btnStokSil.UseVisualStyleBackColor = False
        '
        'btnStokEkle
        '
        Me.btnStokEkle.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStokEkle.Location = New System.Drawing.Point(24, 306)
        Me.btnStokEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStokEkle.Name = "btnStokEkle"
        Me.btnStokEkle.Size = New System.Drawing.Size(157, 70)
        Me.btnStokEkle.TabIndex = 104
        Me.btnStokEkle.Text = "STOK EKLE"
        Me.btnStokEkle.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(541, 160)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(131, 17)
        Me.label8.TabIndex = 103
        Me.label8.Text = "STOK MODEL ARA"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txt_kayit)
        Me.groupBox1.Controls.Add(Me.txt_ad)
        Me.groupBox1.Controls.Add(Me.txt_model)
        Me.groupBox1.Controls.Add(Me.txt_serino)
        Me.groupBox1.Controls.Add(Me.txt_adet)
        Me.groupBox1.Controls.Add(Me.dt_tarih)
        Me.groupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.groupBox1.Location = New System.Drawing.Point(146, 25)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(356, 256)
        Me.groupBox1.TabIndex = 91
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "KAYIT İŞLEMLERİ"
        '
        'txt_kayit
        '
        Me.txt_kayit.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_kayit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_kayit.Location = New System.Drawing.Point(40, 204)
        Me.txt_kayit.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_kayit.Name = "txt_kayit"
        Me.txt_kayit.Size = New System.Drawing.Size(281, 26)
        Me.txt_kayit.TabIndex = 5
        '
        'txt_ad
        '
        Me.txt_ad.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ad.Location = New System.Drawing.Point(40, 32)
        Me.txt_ad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ad.Name = "txt_ad"
        Me.txt_ad.Size = New System.Drawing.Size(281, 26)
        Me.txt_ad.TabIndex = 0
        '
        'txt_model
        '
        Me.txt_model.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_model.Location = New System.Drawing.Point(40, 66)
        Me.txt_model.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(281, 26)
        Me.txt_model.TabIndex = 1
        '
        'txt_serino
        '
        Me.txt_serino.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_serino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_serino.Location = New System.Drawing.Point(40, 101)
        Me.txt_serino.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_serino.Name = "txt_serino"
        Me.txt_serino.Size = New System.Drawing.Size(281, 26)
        Me.txt_serino.TabIndex = 2
        '
        'txt_adet
        '
        Me.txt_adet.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_adet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_adet.Location = New System.Drawing.Point(40, 135)
        Me.txt_adet.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_adet.Name = "txt_adet"
        Me.txt_adet.Size = New System.Drawing.Size(281, 26)
        Me.txt_adet.TabIndex = 3
        '
        'dt_tarih
        '
        Me.dt_tarih.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_tarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dt_tarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_tarih.Location = New System.Drawing.Point(40, 170)
        Me.dt_tarih.Margin = New System.Windows.Forms.Padding(4)
        Me.dt_tarih.Name = "dt_tarih"
        Me.dt_tarih.Size = New System.Drawing.Size(281, 26)
        Me.dt_tarih.TabIndex = 4
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(32, 239)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(97, 17)
        Me.label6.TabIndex = 101
        Me.label6.Text = "KAYIT YAPAN"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(32, 203)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(91, 17)
        Me.label5.TabIndex = 100
        Me.label5.Text = "STOK TARİH"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(32, 167)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(91, 17)
        Me.label4.TabIndex = 99
        Me.label4.Text = "STOK ADEDİ"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(32, 132)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 17)
        Me.label3.TabIndex = 98
        Me.label3.Text = "STOK SERİNO"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(32, 96)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(102, 17)
        Me.label2.TabIndex = 97
        Me.label2.Text = "STOK MODELİ"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(32, 60)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 17)
        Me.label1.TabIndex = 96
        Me.label1.Text = "STOK ADI"
        '
        'txt_modelara
        '
        Me.txt_modelara.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_modelara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_modelara.Location = New System.Drawing.Point(544, 186)
        Me.txt_modelara.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_modelara.Name = "txt_modelara"
        Me.txt_modelara.Size = New System.Drawing.Size(148, 26)
        Me.txt_modelara.TabIndex = 94
        '
        'txt_stokadiara
        '
        Me.txt_stokadiara.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stokadiara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_stokadiara.Location = New System.Drawing.Point(544, 43)
        Me.txt_stokadiara.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_stokadiara.Name = "txt_stokadiara"
        Me.txt_stokadiara.Size = New System.Drawing.Size(148, 26)
        Me.txt_stokadiara.TabIndex = 92
        '
        'OFD
        '
        Me.OFD.FileName = "openFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(556, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "STOK ADI ARA"
        '
        'grdStok
        '
        Me.grdStok.AllowUserToAddRows = False
        Me.grdStok.AllowUserToDeleteRows = False
        Me.grdStok.AllowUserToResizeColumns = False
        Me.grdStok.AllowUserToResizeRows = False
        Me.grdStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdStok.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStok.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdStok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdStok.Location = New System.Drawing.Point(24, 410)
        Me.grdStok.Margin = New System.Windows.Forms.Padding(4)
        Me.grdStok.MultiSelect = False
        Me.grdStok.Name = "grdStok"
        Me.grdStok.ReadOnly = True
        Me.grdStok.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdStok.Size = New System.Drawing.Size(974, 234)
        Me.grdStok.TabIndex = 113
        '
        'StokProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1007, 679)
        Me.Controls.Add(Me.grdStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btnStokAdiAra)
        Me.Controls.Add(Me.btnStokModelAra)
        Me.Controls.Add(Me.btnResimSil)
        Me.Controls.Add(Me.btnResimEkle)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.btnStokGuncelle)
        Me.Controls.Add(Me.btnStokSil)
        Me.Controls.Add(Me.btnStokEkle)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txt_modelara)
        Me.Controls.Add(Me.txt_stokadiara)
        Me.Name = "StokProgram"
        Me.Text = "StokProgram"
        Me.groupBox2.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.grdStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnStokAdiAra As Button
    Private WithEvents btnStokModelAra As Button
    Private WithEvents btnResimSil As Button
    Private WithEvents btnResimEkle As Button
    Private WithEvents btnCikis As Button
    Private WithEvents btnStokGuncelle As Button
    Private WithEvents btnStokSil As Button
    Private WithEvents btnStokEkle As Button
    Private WithEvents label8 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txt_kayit As TextBox
    Private WithEvents txt_ad As TextBox
    Private WithEvents txt_model As TextBox
    Private WithEvents txt_serino As TextBox
    Private WithEvents txt_adet As TextBox
    Private WithEvents dt_tarih As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents txt_modelara As TextBox
    Private WithEvents txt_stokadiara As TextBox
    Private WithEvents OFD As OpenFileDialog
    Private WithEvents Label7 As Label
    Private WithEvents groupBox2 As GroupBox
    Friend WithEvents grdStok As DataGridView
    Private WithEvents pictureBox1 As PictureBox
End Class
