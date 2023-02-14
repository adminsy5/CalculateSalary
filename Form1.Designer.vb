<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.basic = New System.Windows.Forms.TextBox()
        Me.pf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.da = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.calc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Basic"
        '
        'basic
        '
        Me.basic.Location = New System.Drawing.Point(290, 121)
        Me.basic.Name = "basic"
        Me.basic.Size = New System.Drawing.Size(147, 39)
        Me.basic.TabIndex = 1
        '
        'pf
        '
        Me.pf.Location = New System.Drawing.Point(290, 245)
        Me.pf.Name = "pf"
        Me.pf.Size = New System.Drawing.Size(97, 39)
        Me.pf.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pf(%)"
        '
        'da
        '
        Me.da.Location = New System.Drawing.Point(290, 183)
        Me.da.Name = "da"
        Me.da.Size = New System.Drawing.Size(97, 39)
        Me.da.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Da(%)"
        '
        'hra
        '
        Me.hra.Location = New System.Drawing.Point(290, 308)
        Me.hra.Name = "hra"
        Me.hra.Size = New System.Drawing.Size(97, 39)
        Me.hra.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hra(%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 32)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Salary : "
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Location = New System.Drawing.Point(323, 385)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(0, 32)
        Me.ans.TabIndex = 11
        '
        'calc
        '
        Me.calc.Location = New System.Drawing.Point(260, 463)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(150, 46)
        Me.calc.TabIndex = 12
        Me.calc.Text = "Calculate"
        Me.calc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "₹"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 689)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.da)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.basic)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents basic As TextBox
    Friend WithEvents pf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents da As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents hra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ans As Label
    Friend WithEvents calc As Button
    Friend WithEvents Label6 As Label
End Class
