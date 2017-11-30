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
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a decimal integer in the range 1 - 10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equivalent Roman Numeral:"
        '
        'txtInteger
        '
        Me.txtInteger.Location = New System.Drawing.Point(238, 38)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(100, 20)
        Me.txtInteger.TabIndex = 2
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(235, 117)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(103, 23)
        Me.lblResult.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(82, 184)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert "
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(221, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 248)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
