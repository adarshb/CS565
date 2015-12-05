<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Number1 = New System.Windows.Forms.TextBox()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Number"
        '
        'Number1
        '
        Me.Number1.Location = New System.Drawing.Point(763, 92)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(100, 31)
        Me.Number1.TabIndex = 1
        '
        'Number2
        '
        Me.Number2.Location = New System.Drawing.Point(763, 171)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(100, 31)
        Me.Number2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Second Number"
        '
        'Sum
        '
        Me.Sum.Location = New System.Drawing.Point(763, 431)
        Me.Sum.Name = "Sum"
        Me.Sum.Size = New System.Drawing.Size(100, 31)
        Me.Sum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Result"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 72)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Sum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 655)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Sum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Number1 As TextBox
    Friend WithEvents Number2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Sum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
