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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Password"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(90, 120)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(194, 20)
        Me.txtAnswer.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(290, 120)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(142, 20)
        Me.lblResult.TabIndex = 2
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(106, 209)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter "
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(233, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 309)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
