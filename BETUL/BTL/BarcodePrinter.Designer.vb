<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodePrinter
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Barcode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_operator = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Printer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Barcode
        '
        Me.Barcode.AutoSize = True
        Me.Barcode.Location = New System.Drawing.Point(36, 72)
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Size = New System.Drawing.Size(47, 13)
        Me.Barcode.TabIndex = 1
        Me.Barcode.Text = "Barcode"
        Me.Barcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operator Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date Time"
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(133, 65)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(100, 20)
        Me.txt_barcode.TabIndex = 4
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(133, 168)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_date.TabIndex = 5
        '
        'txt_operator
        '
        Me.txt_operator.Location = New System.Drawing.Point(133, 115)
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.Size = New System.Drawing.Size(100, 20)
        Me.txt_operator.TabIndex = 6
        '
        'BarcodePrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 450)
        Me.Controls.Add(Me.txt_operator)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Barcode)
        Me.Controls.Add(Me.Button1)
        Me.Name = "BarcodePrinter"
        Me.Text = "BarcodePrinter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Barcode As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_operator As TextBox
End Class
