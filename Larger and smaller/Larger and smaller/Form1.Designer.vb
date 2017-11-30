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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Two Integers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(134, 124)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(116, 20)
        Me.txtA.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "B:"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(338, 124)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(163, 216)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(225, 32)
        Me.lblResult.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(163, 320)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 7
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 378)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCompare As System.Windows.Forms.Button

End Class
