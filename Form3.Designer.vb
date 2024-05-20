<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.luxbutton = New System.Windows.Forms.Button()
        Me.standardbutton = New System.Windows.Forms.Button()
        Me.econbutton = New System.Windows.Forms.Button()
        Me.undercoat = New System.Windows.Forms.CheckBox()
        Me.billbutton = New System.Windows.Forms.Button()
        Me.CostCalc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HamzaPainters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quotation"
        '
        'luxbutton
        '
        Me.luxbutton.Location = New System.Drawing.Point(166, 99)
        Me.luxbutton.Name = "luxbutton"
        Me.luxbutton.Size = New System.Drawing.Size(75, 23)
        Me.luxbutton.TabIndex = 2
        Me.luxbutton.Text = "Luxery"
        Me.luxbutton.UseVisualStyleBackColor = True
        '
        'standardbutton
        '
        Me.standardbutton.Location = New System.Drawing.Point(166, 128)
        Me.standardbutton.Name = "standardbutton"
        Me.standardbutton.Size = New System.Drawing.Size(75, 23)
        Me.standardbutton.TabIndex = 3
        Me.standardbutton.Text = "Standard"
        Me.standardbutton.UseVisualStyleBackColor = True
        '
        'econbutton
        '
        Me.econbutton.Location = New System.Drawing.Point(166, 161)
        Me.econbutton.Name = "econbutton"
        Me.econbutton.Size = New System.Drawing.Size(75, 23)
        Me.econbutton.TabIndex = 4
        Me.econbutton.Text = "Economy"
        Me.econbutton.UseVisualStyleBackColor = True
        '
        'undercoat
        '
        Me.undercoat.AutoSize = True
        Me.undercoat.Location = New System.Drawing.Point(166, 190)
        Me.undercoat.Name = "undercoat"
        Me.undercoat.Size = New System.Drawing.Size(122, 17)
        Me.undercoat.TabIndex = 5
        Me.undercoat.Text = "Undercoat Required"
        Me.undercoat.UseVisualStyleBackColor = True
        '
        'billbutton
        '
        Me.billbutton.Location = New System.Drawing.Point(15, 205)
        Me.billbutton.Name = "billbutton"
        Me.billbutton.Size = New System.Drawing.Size(75, 23)
        Me.billbutton.TabIndex = 6
        Me.billbutton.Text = "Print Bill"
        Me.billbutton.UseVisualStyleBackColor = True
        '
        'CostCalc
        '
        Me.CostCalc.AutoSize = True
        Me.CostCalc.Location = New System.Drawing.Point(27, 171)
        Me.CostCalc.Name = "CostCalc"
        Me.CostCalc.Size = New System.Drawing.Size(31, 13)
        Me.CostCalc.TabIndex = 7
        Me.CostCalc.Text = "Total"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CostCalc)
        Me.Controls.Add(Me.billbutton)
        Me.Controls.Add(Me.undercoat)
        Me.Controls.Add(Me.econbutton)
        Me.Controls.Add(Me.standardbutton)
        Me.Controls.Add(Me.luxbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents luxbutton As Button
    Friend WithEvents standardbutton As Button
    Friend WithEvents econbutton As Button
    Friend WithEvents undercoat As CheckBox
    Friend WithEvents billbutton As Button
    Friend WithEvents CostCalc As Label
End Class
