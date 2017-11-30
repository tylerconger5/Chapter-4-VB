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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGrade)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.txtScore3)
        Me.GroupBox1.Controls.Add(Me.txtScore2)
        Me.GroupBox1.Controls.Add(Me.txtScore1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " Score 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Average "
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(113, 29)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(100, 20)
        Me.txtScore1.TabIndex = 6
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(113, 73)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 20)
        Me.txtScore2.TabIndex = 7
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(113, 114)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 20)
        Me.txtScore3.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 290)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 48)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate Average "
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(194, 276)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(114, 149)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 25)
        Me.lblResult.TabIndex = 9
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(56, 257)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(100, 23)
        Me.lblMessage.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Grade:"
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(114, 190)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblGrade.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 350)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
