<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodeCreate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ord = New System.Windows.Forms.TextBox()
        Me.txt_sta = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_operator = New System.Windows.Forms.TextBox()
        Me.btn_barcode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OrderNumber"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "StationId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DateTime"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Operator"
        '
        'txt_ord
        '
        Me.txt_ord.Location = New System.Drawing.Point(129, 35)
        Me.txt_ord.Name = "txt_ord"
        Me.txt_ord.Size = New System.Drawing.Size(100, 20)
        Me.txt_ord.TabIndex = 4
        '
        'txt_sta
        '
        Me.txt_sta.Location = New System.Drawing.Point(129, 64)
        Me.txt_sta.Name = "txt_sta"
        Me.txt_sta.Size = New System.Drawing.Size(100, 20)
        Me.txt_sta.TabIndex = 5
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(129, 128)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_date.TabIndex = 7
        '
        'txt_operator
        '
        Me.txt_operator.Location = New System.Drawing.Point(129, 99)
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.Size = New System.Drawing.Size(100, 20)
        Me.txt_operator.TabIndex = 6
        '
        'btn_barcode
        '
        Me.btn_barcode.Location = New System.Drawing.Point(129, 193)
        Me.btn_barcode.Name = "btn_barcode"
        Me.btn_barcode.Size = New System.Drawing.Size(100, 23)
        Me.btn_barcode.TabIndex = 8
        Me.btn_barcode.Text = "Create Barcode"
        Me.btn_barcode.UseVisualStyleBackColor = True
        '
        'BarcodeCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 285)
        Me.Controls.Add(Me.btn_barcode)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_operator)
        Me.Controls.Add(Me.txt_sta)
        Me.Controls.Add(Me.txt_ord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BarcodeCreate"
        Me.Text = "BarcodeCreate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ord As TextBox
    Friend WithEvents txt_sta As TextBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_operator As TextBox
    Friend WithEvents btn_barcode As Button
End Class
