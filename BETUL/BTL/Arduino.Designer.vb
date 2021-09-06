<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arduino
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_calis = New System.Windows.Forms.Button()
        Me.txt_command = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.tmr_process = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'btn_calis
        '
        Me.btn_calis.Location = New System.Drawing.Point(130, 121)
        Me.btn_calis.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_calis.Name = "btn_calis"
        Me.btn_calis.Size = New System.Drawing.Size(132, 28)
        Me.btn_calis.TabIndex = 3
        Me.btn_calis.Text = "Çalıştır"
        Me.btn_calis.UseVisualStyleBackColor = True
        '
        'txt_command
        '
        Me.txt_command.Location = New System.Drawing.Point(130, 36)
        Me.txt_command.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_command.Name = "txt_command"
        Me.txt_command.Size = New System.Drawing.Size(132, 22)
        Me.txt_command.TabIndex = 1
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(130, 66)
        Me.txt_data.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(132, 22)
        Me.txt_data.TabIndex = 2
        '
        'tmr_process
        '
        Me.tmr_process.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seri Port Yaz"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(405, 27)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(37, 122)
        Me.VScrollBar1.TabIndex = 14
        Me.VScrollBar1.Visible = False
        '
        'Arduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 227)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_calis)
        Me.Controls.Add(Me.txt_command)
        Me.Controls.Add(Me.txt_data)
        Me.Name = "Arduino"
        Me.Text = "Arduino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_calis As Button
    Friend WithEvents txt_command As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents tmr_process As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
