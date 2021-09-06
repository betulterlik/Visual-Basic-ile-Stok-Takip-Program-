<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEST
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
        Me.btn_guid = New System.Windows.Forms.Button()
        Me.btn_ramdonsayi = New System.Windows.Forms.Button()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btn_guid
        '
        Me.btn_guid.Location = New System.Drawing.Point(33, 24)
        Me.btn_guid.Name = "btn_guid"
        Me.btn_guid.Size = New System.Drawing.Size(82, 23)
        Me.btn_guid.TabIndex = 0
        Me.btn_guid.Text = "Yeni Guid "
        Me.btn_guid.UseVisualStyleBackColor = true
        '
        'btn_ramdonsayi
        '
        Me.btn_ramdonsayi.Location = New System.Drawing.Point(33, 67)
        Me.btn_ramdonsayi.Name = "btn_ramdonsayi"
        Me.btn_ramdonsayi.Size = New System.Drawing.Size(82, 23)
        Me.btn_ramdonsayi.TabIndex = 1
        Me.btn_ramdonsayi.Text = "Şifre Üret"
        Me.btn_ramdonsayi.UseVisualStyleBackColor = true
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = true
        Me.lbl_pass.Location = New System.Drawing.Point(131, 50)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(15, 13)
        Me.lbl_pass.TabIndex = 2
        Me.lbl_pass.Text = "**"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.AutoEllipsis = true
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(33, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Oval Buton"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'TEST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.btn_ramdonsayi)
        Me.Controls.Add(Me.btn_guid)
        Me.Name = "TEST"
        Me.Text = "TEST"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btn_guid As Button
    Friend WithEvents btn_ramdonsayi As Button
    Friend WithEvents lbl_pass As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
