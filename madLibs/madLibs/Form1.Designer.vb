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
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListNumber = New System.Windows.Forms.ListBox()
        Me.listBodyPart = New System.Windows.Forms.ListBox()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listNoun = New System.Windows.Forms.ListBox()
        Me.listPluralNoun = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listColor
        '
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Blue ", "Red ", "Yellow ", "Green", "Purple ", "Orange ", "Black", "White"})
        Me.listColor.Location = New System.Drawing.Point(46, 61)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 0
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"Biggest ", "fastest ", "fattest ", "greatest", "shortest ", "roundest ", "smallest "})
        Me.listEst.Location = New System.Drawing.Point(183, 61)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Word Ending in Est"
        '
        'ListNumber
        '
        Me.ListNumber.FormattingEnabled = True
        Me.ListNumber.Items.AddRange(New Object() {"1", "10", "100", "101", "11", "12", "2"})
        Me.ListNumber.Location = New System.Drawing.Point(327, 61)
        Me.ListNumber.Name = "ListNumber"
        Me.ListNumber.Size = New System.Drawing.Size(120, 95)
        Me.ListNumber.TabIndex = 4
        '
        'listBodyPart
        '
        Me.listBodyPart.FormattingEnabled = True
        Me.listBodyPart.Items.AddRange(New Object() {"arm", "legs", "toes", "fingers", "heads", "belly buttons", "hips", "hands"})
        Me.listBodyPart.Location = New System.Drawing.Point(46, 183)
        Me.listBodyPart.Name = "listBodyPart"
        Me.listBodyPart.Size = New System.Drawing.Size(120, 95)
        Me.listBodyPart.TabIndex = 5
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Items.AddRange(New Object() {"dog ", "cat ", "bear ", "elephant ", "racoon", "monkey", "turtle ", "wolf", "fox", "deer", "chicken"})
        Me.listAnimal.Location = New System.Drawing.Point(183, 183)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 6
        '
        'listNoun
        '
        Me.listNoun.FormattingEnabled = True
        Me.listNoun.Items.AddRange(New Object() {"house ", "boat", "car ", "pencil", "desk ", "city ", "planet"})
        Me.listNoun.Location = New System.Drawing.Point(327, 183)
        Me.listNoun.Name = "listNoun"
        Me.listNoun.Size = New System.Drawing.Size(120, 95)
        Me.listNoun.TabIndex = 7
        '
        'listPluralNoun
        '
        Me.listPluralNoun.FormattingEnabled = True
        Me.listPluralNoun.Items.AddRange(New Object() {"houses ", "pencils", "desks", "baseballs", "footballs", "parties", "trees"})
        Me.listPluralNoun.Location = New System.Drawing.Point(46, 299)
        Me.listPluralNoun.Name = "listPluralNoun"
        Me.listPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPluralNoun.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(214, 299)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 34)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(214, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 34)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 35)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Numbers "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Body Parts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Animals "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 424)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.listPluralNoun)
        Me.Controls.Add(Me.listNoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBodyPart)
        Me.Controls.Add(Me.ListNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.listColor)
        Me.Name = "Form1"
        Me.Text = "mad libs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listColor As System.Windows.Forms.ListBox
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListNumber As System.Windows.Forms.ListBox
    Friend WithEvents listBodyPart As System.Windows.Forms.ListBox
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listNoun As System.Windows.Forms.ListBox
    Friend WithEvents listPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
