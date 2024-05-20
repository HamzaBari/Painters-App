<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.roomheight = New System.Windows.Forms.TextBox()
        Me.roomlength = New System.Windows.Forms.TextBox()
        Me.AreaCalc = New System.Windows.Forms.Label()
        Me.Calculatebutton = New System.Windows.Forms.Button()
        Me.Nextbutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label2.Location = New System.Drawing.Point(151, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter measurements"
        '
        'roomheight
        '
        Me.roomheight.Location = New System.Drawing.Point(154, 90)
        Me.roomheight.Name = "roomheight"
        Me.roomheight.Size = New System.Drawing.Size(100, 20)
        Me.roomheight.TabIndex = 2
        Me.roomheight.Text = "Between 2-6"
        '
        'roomlength
        '
        Me.roomlength.Location = New System.Drawing.Point(154, 142)
        Me.roomlength.Name = "roomlength"
        Me.roomlength.Size = New System.Drawing.Size(100, 20)
        Me.roomlength.TabIndex = 3
        Me.roomlength.Text = "Between 1-25"
        '
        'AreaCalc
        '
        Me.AreaCalc.AutoSize = True
        Me.AreaCalc.Location = New System.Drawing.Point(166, 185)
        Me.AreaCalc.Name = "AreaCalc"
        Me.AreaCalc.Size = New System.Drawing.Size(56, 13)
        Me.AreaCalc.TabIndex = 4
        Me.AreaCalc.Text = "Total Area"
        '
        'Calculatebutton
        '
        Me.Calculatebutton.Location = New System.Drawing.Point(37, 90)
        Me.Calculatebutton.Name = "Calculatebutton"
        Me.Calculatebutton.Size = New System.Drawing.Size(75, 23)
        Me.Calculatebutton.TabIndex = 5
        Me.Calculatebutton.Text = "Calculate"
        Me.Calculatebutton.UseVisualStyleBackColor = True
        '
        'Nextbutton
        '
        Me.Nextbutton.Location = New System.Drawing.Point(37, 175)
        Me.Nextbutton.Name = "Nextbutton"
        Me.Nextbutton.Size = New System.Drawing.Size(75, 23)
        Me.Nextbutton.TabIndex = 6
        Me.Nextbutton.Text = "Next"
        Me.Nextbutton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Length"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nextbutton)
        Me.Controls.Add(Me.Calculatebutton)
        Me.Controls.Add(Me.AreaCalc)
        Me.Controls.Add(Me.roomlength)
        Me.Controls.Add(Me.roomheight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents roomheight As TextBox
    Friend WithEvents roomlength As TextBox
    Friend WithEvents AreaCalc As Label
    Friend WithEvents Calculatebutton As Button
    Friend WithEvents Nextbutton As Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
