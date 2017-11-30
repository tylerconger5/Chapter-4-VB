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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names and finsihing times."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in Seconds)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Runner 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Runner 3:"
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(156, 131)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 26)
        Me.txtName1.TabIndex = 6
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(156, 174)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 26)
        Me.txtName2.TabIndex = 7
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(156, 217)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 26)
        Me.txtName3.TabIndex = 8
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(296, 131)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(100, 26)
        Me.txtTime1.TabIndex = 9
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(296, 179)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(100, 26)
        Me.txtTime2.TabIndex = 10
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(296, 222)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(100, 26)
        Me.txtTime3.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult3)
        Me.GroupBox1.Controls.Add(Me.lblResult2)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(156, 307)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 126)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'lblResult3
        '
        Me.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult3.Location = New System.Drawing.Point(127, 85)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(100, 23)
        Me.lblResult3.TabIndex = 5
        '
        'lblResult2
        '
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult2.Location = New System.Drawing.Point(128, 57)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(100, 23)
        Me.lblResult2.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(127, 30)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "3ed Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2nd Place:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1st Place:"
        '
        'btnResults
        '
        Me.btnResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResults.Location = New System.Drawing.Point(103, 457)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(80, 37)
        Me.btnResults.TabIndex = 13
        Me.btnResults.Text = "Calculate Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(257, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 37)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(422, 457)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 515)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Race Resutls "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult3 As System.Windows.Forms.Label
    Friend WithEvents lblResult2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
