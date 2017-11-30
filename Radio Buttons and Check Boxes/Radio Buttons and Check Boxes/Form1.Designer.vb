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
        Me.radSandwhich = New System.Windows.Forms.RadioButton()
        Me.radChicken = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFires = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radWings = New System.Windows.Forms.RadioButton()
        Me.radFires = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSandwhich)
        Me.GroupBox1.Controls.Add(Me.radChicken)
        Me.GroupBox1.Controls.Add(Me.radCheese)
        Me.GroupBox1.Controls.Add(Me.radHam)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal "
        '
        'radSandwhich
        '
        Me.radSandwhich.AutoSize = True
        Me.radSandwhich.Location = New System.Drawing.Point(6, 105)
        Me.radSandwhich.Name = "radSandwhich"
        Me.radSandwhich.Size = New System.Drawing.Size(116, 17)
        Me.radSandwhich.TabIndex = 3
        Me.radSandwhich.TabStop = True
        Me.radSandwhich.Text = "Chesse Sandwhich"
        Me.radSandwhich.UseVisualStyleBackColor = True
        '
        'radChicken
        '
        Me.radChicken.AutoSize = True
        Me.radChicken.Location = New System.Drawing.Point(6, 82)
        Me.radChicken.Name = "radChicken"
        Me.radChicken.Size = New System.Drawing.Size(94, 17)
        Me.radChicken.TabIndex = 2
        Me.radChicken.TabStop = True
        Me.radChicken.Text = "Chicken Patty "
        Me.radChicken.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Location = New System.Drawing.Point(6, 59)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(98, 17)
        Me.radCheese.TabIndex = 1
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Cheese Burger "
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(6, 36)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(78, 17)
        Me.radHam.TabIndex = 0
        Me.radHam.TabStop = True
        Me.radHam.Text = "HamBurger"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFires)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(251, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings "
        '
        'chkFires
        '
        Me.chkFires.AutoSize = True
        Me.chkFires.Location = New System.Drawing.Point(17, 105)
        Me.chkFires.Name = "chkFires"
        Me.chkFires.Size = New System.Drawing.Size(48, 17)
        Me.chkFires.TabIndex = 3
        Me.chkFires.Text = "Fires"
        Me.chkFires.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(17, 82)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(17, 59)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(17, 37)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 223)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(219, 55)
        Me.lblResult.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(13, 296)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter "
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(94, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radFruit)
        Me.GroupBox3.Controls.Add(Me.radWings)
        Me.GroupBox3.Controls.Add(Me.radFires)
        Me.GroupBox3.Location = New System.Drawing.Point(251, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 104)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sides"
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Location = New System.Drawing.Point(7, 68)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(48, 17)
        Me.radFruit.TabIndex = 2
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit "
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radWings
        '
        Me.radWings.AutoSize = True
        Me.radWings.Location = New System.Drawing.Point(7, 44)
        Me.radWings.Name = "radWings"
        Me.radWings.Size = New System.Drawing.Size(55, 17)
        Me.radWings.TabIndex = 1
        Me.radWings.TabStop = True
        Me.radWings.Text = "Wings"
        Me.radWings.UseVisualStyleBackColor = True
        '
        'radFires
        '
        Me.radFires.AutoSize = True
        Me.radFires.Location = New System.Drawing.Point(7, 20)
        Me.radFires.Name = "radFires"
        Me.radFires.Size = New System.Drawing.Size(47, 17)
        Me.radFires.TabIndex = 0
        Me.radFires.TabStop = True
        Me.radFires.Text = "Fires"
        Me.radFires.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 333)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calss Selection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSandwhich As System.Windows.Forms.RadioButton
    Friend WithEvents radChicken As System.Windows.Forms.RadioButton
    Friend WithEvents radCheese As System.Windows.Forms.RadioButton
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFires As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radFruit As System.Windows.Forms.RadioButton
    Friend WithEvents radWings As System.Windows.Forms.RadioButton
    Friend WithEvents radFires As System.Windows.Forms.RadioButton

End Class
