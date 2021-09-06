<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolderingTest
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
        Me.cmb_Electrodechange = New System.Windows.Forms.ComboBox()
        Me.cbox_leftelectrode = New System.Windows.Forms.CheckBox()
        Me.cbox_leftsidechange = New System.Windows.Forms.CheckBox()
        Me.cbox_rightelectrode = New System.Windows.Forms.CheckBox()
        Me.cbox_rightsidechange = New System.Windows.Forms.CheckBox()
        Me.txt_TotalCrossSection = New System.Windows.Forms.TextBox()
        Me.btn_hesapla = New System.Windows.Forms.Button()
        Me.lbl_ssr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_Electrodechange
        '
        Me.cmb_Electrodechange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Electrodechange.FormattingEnabled = True
        Me.cmb_Electrodechange.Location = New System.Drawing.Point(158, 132)
        Me.cmb_Electrodechange.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_Electrodechange.Name = "cmb_Electrodechange"
        Me.cmb_Electrodechange.Size = New System.Drawing.Size(97, 21)
        Me.cmb_Electrodechange.TabIndex = 131
        '
        'cbox_leftelectrode
        '
        Me.cbox_leftelectrode.AutoSize = True
        Me.cbox_leftelectrode.Location = New System.Drawing.Point(158, 58)
        Me.cbox_leftelectrode.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_leftelectrode.Name = "cbox_leftelectrode"
        Me.cbox_leftelectrode.Size = New System.Drawing.Size(87, 17)
        Me.cbox_leftelectrode.TabIndex = 127
        Me.cbox_leftelectrode.Text = "left electrode"
        Me.cbox_leftelectrode.UseVisualStyleBackColor = True
        '
        'cbox_leftsidechange
        '
        Me.cbox_leftsidechange.AutoSize = True
        Me.cbox_leftsidechange.Location = New System.Drawing.Point(158, 77)
        Me.cbox_leftsidechange.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_leftsidechange.Name = "cbox_leftsidechange"
        Me.cbox_leftsidechange.Size = New System.Drawing.Size(101, 17)
        Me.cbox_leftsidechange.TabIndex = 128
        Me.cbox_leftsidechange.Text = "left side change"
        Me.cbox_leftsidechange.UseVisualStyleBackColor = True
        '
        'cbox_rightelectrode
        '
        Me.cbox_rightelectrode.AutoSize = True
        Me.cbox_rightelectrode.Location = New System.Drawing.Point(158, 96)
        Me.cbox_rightelectrode.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_rightelectrode.Name = "cbox_rightelectrode"
        Me.cbox_rightelectrode.Size = New System.Drawing.Size(93, 17)
        Me.cbox_rightelectrode.TabIndex = 129
        Me.cbox_rightelectrode.Text = "right electrode"
        Me.cbox_rightelectrode.UseVisualStyleBackColor = True
        '
        'cbox_rightsidechange
        '
        Me.cbox_rightsidechange.AutoSize = True
        Me.cbox_rightsidechange.Location = New System.Drawing.Point(158, 115)
        Me.cbox_rightsidechange.Margin = New System.Windows.Forms.Padding(2)
        Me.cbox_rightsidechange.Name = "cbox_rightsidechange"
        Me.cbox_rightsidechange.Size = New System.Drawing.Size(107, 17)
        Me.cbox_rightsidechange.TabIndex = 130
        Me.cbox_rightsidechange.Text = "right side change"
        Me.cbox_rightsidechange.UseVisualStyleBackColor = True
        '
        'txt_TotalCrossSection
        '
        Me.txt_TotalCrossSection.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_TotalCrossSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_TotalCrossSection.Location = New System.Drawing.Point(375, 127)
        Me.txt_TotalCrossSection.MaxLength = 10
        Me.txt_TotalCrossSection.Name = "txt_TotalCrossSection"
        Me.txt_TotalCrossSection.Size = New System.Drawing.Size(117, 26)
        Me.txt_TotalCrossSection.TabIndex = 132
        '
        'btn_hesapla
        '
        Me.btn_hesapla.Location = New System.Drawing.Point(375, 177)
        Me.btn_hesapla.Name = "btn_hesapla"
        Me.btn_hesapla.Size = New System.Drawing.Size(117, 23)
        Me.btn_hesapla.TabIndex = 133
        Me.btn_hesapla.Text = "Alan Hesapla"
        Me.btn_hesapla.UseVisualStyleBackColor = True
        '
        'lbl_ssr
        '
        Me.lbl_ssr.AutoSize = True
        Me.lbl_ssr.Location = New System.Drawing.Point(375, 229)
        Me.lbl_ssr.Name = "lbl_ssr"
        Me.lbl_ssr.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ssr.TabIndex = 134
        Me.lbl_ssr.Text = "*"
        '
        'SolderingTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lbl_ssr)
        Me.Controls.Add(Me.btn_hesapla)
        Me.Controls.Add(Me.txt_TotalCrossSection)
        Me.Controls.Add(Me.cmb_Electrodechange)
        Me.Controls.Add(Me.cbox_leftelectrode)
        Me.Controls.Add(Me.cbox_leftsidechange)
        Me.Controls.Add(Me.cbox_rightelectrode)
        Me.Controls.Add(Me.cbox_rightsidechange)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SolderingTest"
        Me.Text = "SolderingTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_Electrodechange As ComboBox
    Friend WithEvents cbox_leftelectrode As CheckBox
    Friend WithEvents cbox_leftsidechange As CheckBox
    Friend WithEvents cbox_rightelectrode As CheckBox
    Friend WithEvents cbox_rightsidechange As CheckBox
    Friend WithEvents txt_TotalCrossSection As TextBox
    Friend WithEvents btn_hesapla As Button
    Friend WithEvents lbl_ssr As Label
End Class
