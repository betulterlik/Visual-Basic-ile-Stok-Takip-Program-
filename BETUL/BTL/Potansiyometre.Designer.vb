<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Potansiyometre
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(219, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.DiscardNull = True
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.PortName = "COM4"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(219, 224)
        Me.ProgressBar1.Maximum = 1023
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(275, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(275, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Kapat"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Potansiyometre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Potansiyometre"
        Me.Text = "Potansiyometre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
End Class
