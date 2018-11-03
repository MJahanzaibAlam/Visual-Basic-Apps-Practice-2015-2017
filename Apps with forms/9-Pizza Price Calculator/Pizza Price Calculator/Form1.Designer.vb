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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radDeepPan = New System.Windows.Forms.RadioButton()
        Me.radCheeseFilled = New System.Windows.Forms.RadioButton()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkBeef = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkChicken = New System.Windows.Forms.CheckBox()
        Me.chkSausage = New System.Windows.Forms.CheckBox()
        Me.chkProscuitto = New System.Windows.Forms.CheckBox()
        Me.chkOlives = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkVegetables = New System.Windows.Forms.CheckBox()
        Me.chkAnchovies = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkRocket = New System.Windows.Forms.CheckBox()
        Me.chkPineapple = New System.Windows.Forms.CheckBox()
        Me.chkCapers = New System.Windows.Forms.CheckBox()
        Me.chkFeta = New System.Windows.Forms.CheckBox()
        Me.chkGoatsCheese = New System.Windows.Forms.CheckBox()
        Me.chkMozarella = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.radLarge)
        Me.GroupBox1.Controls.Add(Me.radMedium)
        Me.GroupBox1.Controls.Add(Me.radSmall)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.radCheeseFilled)
        Me.GroupBox2.Controls.Add(Me.radDeepPan)
        Me.GroupBox2.Controls.Add(Me.radThin)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(139, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Crust"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblPrice)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(474, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 120)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Price"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.chkRocket)
        Me.GroupBox4.Controls.Add(Me.chkPineapple)
        Me.GroupBox4.Controls.Add(Me.chkCapers)
        Me.GroupBox4.Controls.Add(Me.chkFeta)
        Me.GroupBox4.Controls.Add(Me.chkGoatsCheese)
        Me.GroupBox4.Controls.Add(Me.chkMozarella)
        Me.GroupBox4.Controls.Add(Me.chkOlives)
        Me.GroupBox4.Controls.Add(Me.chkOnions)
        Me.GroupBox4.Controls.Add(Me.chkMushrooms)
        Me.GroupBox4.Controls.Add(Me.chkVegetables)
        Me.GroupBox4.Controls.Add(Me.chkAnchovies)
        Me.GroupBox4.Controls.Add(Me.chkTuna)
        Me.GroupBox4.Controls.Add(Me.chkProscuitto)
        Me.GroupBox4.Controls.Add(Me.chkSausage)
        Me.GroupBox4.Controls.Add(Me.chkChicken)
        Me.GroupBox4.Controls.Add(Me.chkHam)
        Me.GroupBox4.Controls.Add(Me.chkBeef)
        Me.GroupBox4.Controls.Add(Me.chkPepperoni)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 189)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Toppings"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(12, 21)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(65, 20)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(12, 56)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(80, 20)
        Me.radMedium.TabIndex = 1
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(12, 94)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(66, 20)
        Me.radLarge.TabIndex = 2
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Checked = True
        Me.radThin.Location = New System.Drawing.Point(11, 21)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(134, 20)
        Me.radThin.TabIndex = 3
        Me.radThin.TabStop = True
        Me.radThin.Text = "Thin and Crispy"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radDeepPan
        '
        Me.radDeepPan.AutoSize = True
        Me.radDeepPan.Location = New System.Drawing.Point(11, 56)
        Me.radDeepPan.Name = "radDeepPan"
        Me.radDeepPan.Size = New System.Drawing.Size(95, 20)
        Me.radDeepPan.TabIndex = 4
        Me.radDeepPan.Text = "Deep Pan"
        Me.radDeepPan.UseVisualStyleBackColor = True
        '
        'radCheeseFilled
        '
        Me.radCheeseFilled.AutoSize = True
        Me.radCheeseFilled.Location = New System.Drawing.Point(11, 94)
        Me.radCheeseFilled.Name = "radCheeseFilled"
        Me.radCheeseFilled.Size = New System.Drawing.Size(122, 20)
        Me.radCheeseFilled.TabIndex = 5
        Me.radCheeseFilled.Text = "Cheese Filled"
        Me.radCheeseFilled.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(21, 46)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 16)
        Me.lblPrice.TabIndex = 0
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.ForeColor = System.Drawing.Color.Black
        Me.chkPepperoni.Location = New System.Drawing.Point(6, 31)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(99, 20)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkBeef
        '
        Me.chkBeef.AutoSize = True
        Me.chkBeef.ForeColor = System.Drawing.Color.Black
        Me.chkBeef.Location = New System.Drawing.Point(6, 57)
        Me.chkBeef.Name = "chkBeef"
        Me.chkBeef.Size = New System.Drawing.Size(59, 20)
        Me.chkBeef.TabIndex = 1
        Me.chkBeef.Text = "Beef"
        Me.chkBeef.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.ForeColor = System.Drawing.Color.Black
        Me.chkHam.Location = New System.Drawing.Point(6, 83)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(83, 20)
        Me.chkHam.TabIndex = 2
        Me.chkHam.Text = "H(ar)am"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkChicken
        '
        Me.chkChicken.AutoSize = True
        Me.chkChicken.ForeColor = System.Drawing.Color.Black
        Me.chkChicken.Location = New System.Drawing.Point(6, 109)
        Me.chkChicken.Name = "chkChicken"
        Me.chkChicken.Size = New System.Drawing.Size(82, 20)
        Me.chkChicken.TabIndex = 3
        Me.chkChicken.Text = "Chicken"
        Me.chkChicken.UseVisualStyleBackColor = True
        '
        'chkSausage
        '
        Me.chkSausage.AutoSize = True
        Me.chkSausage.ForeColor = System.Drawing.Color.Black
        Me.chkSausage.Location = New System.Drawing.Point(6, 135)
        Me.chkSausage.Name = "chkSausage"
        Me.chkSausage.Size = New System.Drawing.Size(89, 20)
        Me.chkSausage.TabIndex = 4
        Me.chkSausage.Text = "Sausage"
        Me.chkSausage.UseVisualStyleBackColor = True
        '
        'chkProscuitto
        '
        Me.chkProscuitto.AutoSize = True
        Me.chkProscuitto.ForeColor = System.Drawing.Color.Black
        Me.chkProscuitto.Location = New System.Drawing.Point(6, 161)
        Me.chkProscuitto.Name = "chkProscuitto"
        Me.chkProscuitto.Size = New System.Drawing.Size(96, 20)
        Me.chkProscuitto.TabIndex = 5
        Me.chkProscuitto.Text = "Proscuitto"
        Me.chkProscuitto.UseVisualStyleBackColor = True
        '
        'chkOlives
        '
        Me.chkOlives.AutoSize = True
        Me.chkOlives.ForeColor = System.Drawing.Color.Black
        Me.chkOlives.Location = New System.Drawing.Point(143, 161)
        Me.chkOlives.Name = "chkOlives"
        Me.chkOlives.Size = New System.Drawing.Size(71, 20)
        Me.chkOlives.TabIndex = 11
        Me.chkOlives.Text = "Olives"
        Me.chkOlives.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.ForeColor = System.Drawing.Color.Black
        Me.chkOnions.Location = New System.Drawing.Point(143, 135)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(75, 20)
        Me.chkOnions.TabIndex = 10
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.ForeColor = System.Drawing.Color.Black
        Me.chkMushrooms.Location = New System.Drawing.Point(143, 109)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(106, 20)
        Me.chkMushrooms.TabIndex = 9
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkVegetables
        '
        Me.chkVegetables.AutoSize = True
        Me.chkVegetables.ForeColor = System.Drawing.Color.Black
        Me.chkVegetables.Location = New System.Drawing.Point(143, 83)
        Me.chkVegetables.Name = "chkVegetables"
        Me.chkVegetables.Size = New System.Drawing.Size(107, 20)
        Me.chkVegetables.TabIndex = 8
        Me.chkVegetables.Text = "Vegetables"
        Me.chkVegetables.UseVisualStyleBackColor = True
        '
        'chkAnchovies
        '
        Me.chkAnchovies.AutoSize = True
        Me.chkAnchovies.ForeColor = System.Drawing.Color.Black
        Me.chkAnchovies.Location = New System.Drawing.Point(143, 57)
        Me.chkAnchovies.Name = "chkAnchovies"
        Me.chkAnchovies.Size = New System.Drawing.Size(99, 20)
        Me.chkAnchovies.TabIndex = 7
        Me.chkAnchovies.Text = "Anchovies"
        Me.chkAnchovies.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.ForeColor = System.Drawing.Color.Black
        Me.chkTuna.Location = New System.Drawing.Point(143, 31)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(62, 20)
        Me.chkTuna.TabIndex = 6
        Me.chkTuna.Text = "Tuna"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkRocket
        '
        Me.chkRocket.AutoSize = True
        Me.chkRocket.ForeColor = System.Drawing.Color.Black
        Me.chkRocket.Location = New System.Drawing.Point(282, 161)
        Me.chkRocket.Name = "chkRocket"
        Me.chkRocket.Size = New System.Drawing.Size(76, 20)
        Me.chkRocket.TabIndex = 17
        Me.chkRocket.Text = "Rocket"
        Me.chkRocket.UseVisualStyleBackColor = True
        '
        'chkPineapple
        '
        Me.chkPineapple.AutoSize = True
        Me.chkPineapple.ForeColor = System.Drawing.Color.Black
        Me.chkPineapple.Location = New System.Drawing.Point(282, 135)
        Me.chkPineapple.Name = "chkPineapple"
        Me.chkPineapple.Size = New System.Drawing.Size(98, 20)
        Me.chkPineapple.TabIndex = 16
        Me.chkPineapple.Text = "Pineapple"
        Me.chkPineapple.UseVisualStyleBackColor = True
        '
        'chkCapers
        '
        Me.chkCapers.AutoSize = True
        Me.chkCapers.ForeColor = System.Drawing.Color.Black
        Me.chkCapers.Location = New System.Drawing.Point(282, 109)
        Me.chkCapers.Name = "chkCapers"
        Me.chkCapers.Size = New System.Drawing.Size(77, 20)
        Me.chkCapers.TabIndex = 15
        Me.chkCapers.Text = "Capers"
        Me.chkCapers.UseVisualStyleBackColor = True
        '
        'chkFeta
        '
        Me.chkFeta.AutoSize = True
        Me.chkFeta.ForeColor = System.Drawing.Color.Black
        Me.chkFeta.Location = New System.Drawing.Point(282, 83)
        Me.chkFeta.Name = "chkFeta"
        Me.chkFeta.Size = New System.Drawing.Size(58, 20)
        Me.chkFeta.TabIndex = 14
        Me.chkFeta.Text = "Feta"
        Me.chkFeta.UseVisualStyleBackColor = True
        '
        'chkGoatsCheese
        '
        Me.chkGoatsCheese.AutoSize = True
        Me.chkGoatsCheese.ForeColor = System.Drawing.Color.Black
        Me.chkGoatsCheese.Location = New System.Drawing.Point(282, 57)
        Me.chkGoatsCheese.Name = "chkGoatsCheese"
        Me.chkGoatsCheese.Size = New System.Drawing.Size(125, 20)
        Me.chkGoatsCheese.TabIndex = 13
        Me.chkGoatsCheese.Text = "Goats Cheese"
        Me.chkGoatsCheese.UseVisualStyleBackColor = True
        '
        'chkMozarella
        '
        Me.chkMozarella.AutoSize = True
        Me.chkMozarella.ForeColor = System.Drawing.Color.Black
        Me.chkMozarella.Location = New System.Drawing.Point(282, 31)
        Me.chkMozarella.Name = "chkMozarella"
        Me.chkMozarella.Size = New System.Drawing.Size(95, 20)
        Me.chkMozarella.TabIndex = 12
        Me.chkMozarella.Text = "Mozarella"
        Me.chkMozarella.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.MistyRose
        Me.btnReset.Location = New System.Drawing.Point(321, 20)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(118, 47)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MistyRose
        Me.btnExit.Location = New System.Drawing.Point(321, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 47)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(455, 153)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(593, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents radCheeseFilled As System.Windows.Forms.RadioButton
    Friend WithEvents radDeepPan As System.Windows.Forms.RadioButton
    Friend WithEvents radThin As System.Windows.Forms.RadioButton
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents chkProscuitto As System.Windows.Forms.CheckBox
    Friend WithEvents chkSausage As System.Windows.Forms.CheckBox
    Friend WithEvents chkChicken As System.Windows.Forms.CheckBox
    Friend WithEvents chkHam As System.Windows.Forms.CheckBox
    Friend WithEvents chkBeef As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkRocket As System.Windows.Forms.CheckBox
    Friend WithEvents chkPineapple As System.Windows.Forms.CheckBox
    Friend WithEvents chkCapers As System.Windows.Forms.CheckBox
    Friend WithEvents chkFeta As System.Windows.Forms.CheckBox
    Friend WithEvents chkGoatsCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkMozarella As System.Windows.Forms.CheckBox
    Friend WithEvents chkOlives As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkVegetables As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnchovies As System.Windows.Forms.CheckBox
    Friend WithEvents chkTuna As System.Windows.Forms.CheckBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
