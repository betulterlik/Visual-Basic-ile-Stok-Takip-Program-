<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_MySettings
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_Port = New System.Windows.Forms.Label()
        Me.cmb_BaudRate = New System.Windows.Forms.ComboBox()
        Me.lbl_DataBits = New System.Windows.Forms.Label()
        Me.lbl_ParityBits = New System.Windows.Forms.Label()
        Me.cmb_StopBits = New System.Windows.Forms.ComboBox()
        Me.cmb_DataBits = New System.Windows.Forms.ComboBox()
        Me.lbl_BaudRate = New System.Windows.Forms.Label()
        Me.cmb_Port = New System.Windows.Forms.ComboBox()
        Me.lbl_StopBits = New System.Windows.Forms.Label()
        Me.cmb_ParityBits = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(347, 295)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(100, 28)
        Me.btn_exit.TabIndex = 16
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(135, 295)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 28)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_Port)
        Me.GroupBox4.Controls.Add(Me.cmb_BaudRate)
        Me.GroupBox4.Controls.Add(Me.lbl_DataBits)
        Me.GroupBox4.Controls.Add(Me.lbl_ParityBits)
        Me.GroupBox4.Controls.Add(Me.cmb_StopBits)
        Me.GroupBox4.Controls.Add(Me.cmb_DataBits)
        Me.GroupBox4.Controls.Add(Me.lbl_BaudRate)
        Me.GroupBox4.Controls.Add(Me.cmb_Port)
        Me.GroupBox4.Controls.Add(Me.lbl_StopBits)
        Me.GroupBox4.Controls.Add(Me.cmb_ParityBits)
        Me.GroupBox4.Location = New System.Drawing.Point(39, 52)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(375, 202)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ARDUINO - Setting"
        '
        'lbl_Port
        '
        Me.lbl_Port.AutoSize = True
        Me.lbl_Port.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_Port.Location = New System.Drawing.Point(9, 33)
        Me.lbl_Port.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Port.Name = "lbl_Port"
        Me.lbl_Port.Size = New System.Drawing.Size(38, 17)
        Me.lbl_Port.TabIndex = 112
        Me.lbl_Port.Tag = "lbl"
        Me.lbl_Port.Text = "Port:"
        '
        'cmb_BaudRate
        '
        Me.cmb_BaudRate.Enabled = False
        Me.cmb_BaudRate.FormattingEnabled = True
        Me.cmb_BaudRate.Location = New System.Drawing.Point(162, 62)
        Me.cmb_BaudRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_BaudRate.Name = "cmb_BaudRate"
        Me.cmb_BaudRate.Size = New System.Drawing.Size(160, 24)
        Me.cmb_BaudRate.TabIndex = 114
        '
        'lbl_DataBits
        '
        Me.lbl_DataBits.AutoSize = True
        Me.lbl_DataBits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_DataBits.Location = New System.Drawing.Point(9, 161)
        Me.lbl_DataBits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_DataBits.Name = "lbl_DataBits"
        Me.lbl_DataBits.Size = New System.Drawing.Size(69, 17)
        Me.lbl_DataBits.TabIndex = 119
        Me.lbl_DataBits.Tag = "lbl"
        Me.lbl_DataBits.Text = "Data Bits:"
        '
        'lbl_ParityBits
        '
        Me.lbl_ParityBits.AutoSize = True
        Me.lbl_ParityBits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_ParityBits.Location = New System.Drawing.Point(8, 97)
        Me.lbl_ParityBits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ParityBits.Name = "lbl_ParityBits"
        Me.lbl_ParityBits.Size = New System.Drawing.Size(75, 17)
        Me.lbl_ParityBits.TabIndex = 115
        Me.lbl_ParityBits.Tag = "lbl"
        Me.lbl_ParityBits.Text = "Parity Bits:"
        '
        'cmb_StopBits
        '
        Me.cmb_StopBits.Enabled = False
        Me.cmb_StopBits.FormattingEnabled = True
        Me.cmb_StopBits.Location = New System.Drawing.Point(162, 126)
        Me.cmb_StopBits.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_StopBits.Name = "cmb_StopBits"
        Me.cmb_StopBits.Size = New System.Drawing.Size(160, 24)
        Me.cmb_StopBits.TabIndex = 117
        '
        'cmb_DataBits
        '
        Me.cmb_DataBits.Enabled = False
        Me.cmb_DataBits.FormattingEnabled = True
        Me.cmb_DataBits.Location = New System.Drawing.Point(162, 158)
        Me.cmb_DataBits.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_DataBits.Name = "cmb_DataBits"
        Me.cmb_DataBits.Size = New System.Drawing.Size(160, 24)
        Me.cmb_DataBits.TabIndex = 120
        '
        'lbl_BaudRate
        '
        Me.lbl_BaudRate.AutoSize = True
        Me.lbl_BaudRate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_BaudRate.Location = New System.Drawing.Point(8, 65)
        Me.lbl_BaudRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_BaudRate.Name = "lbl_BaudRate"
        Me.lbl_BaudRate.Size = New System.Drawing.Size(79, 17)
        Me.lbl_BaudRate.TabIndex = 113
        Me.lbl_BaudRate.Tag = "lbl"
        Me.lbl_BaudRate.Text = "Baud Rate:"
        '
        'cmb_Port
        '
        Me.cmb_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Port.Enabled = False
        Me.cmb_Port.FormattingEnabled = True
        Me.cmb_Port.Location = New System.Drawing.Point(163, 30)
        Me.cmb_Port.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Port.Name = "cmb_Port"
        Me.cmb_Port.Size = New System.Drawing.Size(159, 24)
        Me.cmb_Port.TabIndex = 111
        '
        'lbl_StopBits
        '
        Me.lbl_StopBits.AutoSize = True
        Me.lbl_StopBits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_StopBits.Location = New System.Drawing.Point(9, 129)
        Me.lbl_StopBits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_StopBits.Name = "lbl_StopBits"
        Me.lbl_StopBits.Size = New System.Drawing.Size(68, 17)
        Me.lbl_StopBits.TabIndex = 116
        Me.lbl_StopBits.Tag = "lbl"
        Me.lbl_StopBits.Text = "Stop Bits:"
        '
        'cmb_ParityBits
        '
        Me.cmb_ParityBits.Enabled = False
        Me.cmb_ParityBits.FormattingEnabled = True
        Me.cmb_ParityBits.Location = New System.Drawing.Point(162, 94)
        Me.cmb_ParityBits.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_ParityBits.Name = "cmb_ParityBits"
        Me.cmb_ParityBits.Size = New System.Drawing.Size(160, 24)
        Me.cmb_ParityBits.TabIndex = 118
        '
        'frm_MySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 368)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "frm_MySettings"
        Me.Text = "frm_MySettings"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_Port As Label
    Friend WithEvents cmb_BaudRate As ComboBox
    Friend WithEvents lbl_DataBits As Label
    Friend WithEvents lbl_ParityBits As Label
    Friend WithEvents cmb_StopBits As ComboBox
    Friend WithEvents cmb_DataBits As ComboBox
    Friend WithEvents lbl_BaudRate As Label
    Friend WithEvents cmb_Port As ComboBox
    Friend WithEvents lbl_StopBits As Label
    Friend WithEvents cmb_ParityBits As ComboBox
End Class
