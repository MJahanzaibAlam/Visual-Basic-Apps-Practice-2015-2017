<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Me.lblFont = New System.Windows.Forms.Label()
        Me.txtFont = New System.Windows.Forms.TextBox()
        Me.lblCharCount = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpFontType = New System.Windows.Forms.GroupBox()
        Me.btnArial = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnCourier = New System.Windows.Forms.Button()
        Me.grpFontStyle = New System.Windows.Forms.GroupBox()
        Me.btnRegular = New System.Windows.Forms.Button()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.btnItalics = New System.Windows.Forms.Button()
        Me.grpFontSize = New System.Windows.Forms.GroupBox()
        Me.rad8 = New System.Windows.Forms.RadioButton()
        Me.rad12 = New System.Windows.Forms.RadioButton()
        Me.rad18 = New System.Windows.Forms.RadioButton()
        Me.rad24 = New System.Windows.Forms.RadioButton()
        Me.rad32 = New System.Windows.Forms.RadioButton()
        Me.grpFontType.SuspendLayout()
        Me.grpFontStyle.SuspendLayout()
        Me.grpFontSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFont.Location = New System.Drawing.Point(12, 9)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(42, 16)
        Me.lblFont.TabIndex = 0
        Me.lblFont.Text = "Font:"
        '
        'txtFont
        '
        Me.txtFont.Enabled = False
        Me.txtFont.Location = New System.Drawing.Point(60, 8)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.ReadOnly = True
        Me.txtFont.Size = New System.Drawing.Size(100, 20)
        Me.txtFont.TabIndex = 1
        Me.txtFont.Text = "Arial"
        '
        'lblCharCount
        '
        Me.lblCharCount.AutoSize = True
        Me.lblCharCount.Location = New System.Drawing.Point(194, 11)
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.Size = New System.Drawing.Size(87, 13)
        Me.lblCharCount.TabIndex = 2
        Me.lblCharCount.Text = "Character Count:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 34)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(616, 288)
        Me.txtInput.TabIndex = 3
        '
        'grpFontType
        '
        Me.grpFontType.Controls.Add(Me.btnCourier)
        Me.grpFontType.Controls.Add(Me.btnTimes)
        Me.grpFontType.Controls.Add(Me.btnArial)
        Me.grpFontType.Location = New System.Drawing.Point(15, 328)
        Me.grpFontType.Name = "grpFontType"
        Me.grpFontType.Size = New System.Drawing.Size(124, 146)
        Me.grpFontType.TabIndex = 4
        Me.grpFontType.TabStop = False
        Me.grpFontType.Text = "Font Type"
        '
        'btnArial
        '
        Me.btnArial.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArial.Location = New System.Drawing.Point(6, 30)
        Me.btnArial.Name = "btnArial"
        Me.btnArial.Size = New System.Drawing.Size(112, 31)
        Me.btnArial.TabIndex = 5
        Me.btnArial.Text = "Arial"
        Me.btnArial.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(6, 66)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(112, 31)
        Me.btnTimes.TabIndex = 6
        Me.btnTimes.Text = "Times"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnCourier
        '
        Me.btnCourier.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourier.Location = New System.Drawing.Point(6, 103)
        Me.btnCourier.Name = "btnCourier"
        Me.btnCourier.Size = New System.Drawing.Size(112, 31)
        Me.btnCourier.TabIndex = 7
        Me.btnCourier.Text = "Courier"
        Me.btnCourier.UseVisualStyleBackColor = True
        '
        'grpFontStyle
        '
        Me.grpFontStyle.Controls.Add(Me.btnItalics)
        Me.grpFontStyle.Controls.Add(Me.btnBold)
        Me.grpFontStyle.Controls.Add(Me.btnRegular)
        Me.grpFontStyle.Location = New System.Drawing.Point(157, 328)
        Me.grpFontStyle.Name = "grpFontStyle"
        Me.grpFontStyle.Size = New System.Drawing.Size(124, 146)
        Me.grpFontStyle.TabIndex = 8
        Me.grpFontStyle.TabStop = False
        Me.grpFontStyle.Text = "Font Style"
        '
        'btnRegular
        '
        Me.btnRegular.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegular.Location = New System.Drawing.Point(6, 30)
        Me.btnRegular.Name = "btnRegular"
        Me.btnRegular.Size = New System.Drawing.Size(112, 31)
        Me.btnRegular.TabIndex = 5
        Me.btnRegular.Text = "Regular"
        Me.btnRegular.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.Location = New System.Drawing.Point(6, 67)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(112, 31)
        Me.btnBold.TabIndex = 9
        Me.btnBold.Text = "Bold"
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'btnItalics
        '
        Me.btnItalics.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalics.Location = New System.Drawing.Point(6, 103)
        Me.btnItalics.Name = "btnItalics"
        Me.btnItalics.Size = New System.Drawing.Size(112, 31)
        Me.btnItalics.TabIndex = 10
        Me.btnItalics.Text = "Italics"
        Me.btnItalics.UseVisualStyleBackColor = True
        '
        'grpFontSize
        '
        Me.grpFontSize.Controls.Add(Me.rad32)
        Me.grpFontSize.Controls.Add(Me.rad24)
        Me.grpFontSize.Controls.Add(Me.rad18)
        Me.grpFontSize.Controls.Add(Me.rad12)
        Me.grpFontSize.Controls.Add(Me.rad8)
        Me.grpFontSize.Location = New System.Drawing.Point(302, 328)
        Me.grpFontSize.Name = "grpFontSize"
        Me.grpFontSize.Size = New System.Drawing.Size(72, 146)
        Me.grpFontSize.TabIndex = 9
        Me.grpFontSize.TabStop = False
        Me.grpFontSize.Text = "Font Size"
        '
        'rad8
        '
        Me.rad8.AutoSize = True
        Me.rad8.Location = New System.Drawing.Point(20, 26)
        Me.rad8.Name = "rad8"
        Me.rad8.Size = New System.Drawing.Size(31, 17)
        Me.rad8.TabIndex = 0
        Me.rad8.TabStop = True
        Me.rad8.Text = "8"
        Me.rad8.UseVisualStyleBackColor = True
        '
        'rad12
        '
        Me.rad12.AutoSize = True
        Me.rad12.Location = New System.Drawing.Point(20, 47)
        Me.rad12.Name = "rad12"
        Me.rad12.Size = New System.Drawing.Size(37, 17)
        Me.rad12.TabIndex = 1
        Me.rad12.TabStop = True
        Me.rad12.Text = "12"
        Me.rad12.UseVisualStyleBackColor = True
        '
        'rad18
        '
        Me.rad18.AutoSize = True
        Me.rad18.Location = New System.Drawing.Point(20, 69)
        Me.rad18.Name = "rad18"
        Me.rad18.Size = New System.Drawing.Size(37, 17)
        Me.rad18.TabIndex = 2
        Me.rad18.TabStop = True
        Me.rad18.Text = "18"
        Me.rad18.UseVisualStyleBackColor = True
        '
        'rad24
        '
        Me.rad24.AutoSize = True
        Me.rad24.Location = New System.Drawing.Point(20, 92)
        Me.rad24.Name = "rad24"
        Me.rad24.Size = New System.Drawing.Size(37, 17)
        Me.rad24.TabIndex = 3
        Me.rad24.TabStop = True
        Me.rad24.Text = "24"
        Me.rad24.UseVisualStyleBackColor = True
        '
        'rad32
        '
        Me.rad32.AutoSize = True
        Me.rad32.Location = New System.Drawing.Point(20, 115)
        Me.rad32.Name = "rad32"
        Me.rad32.Size = New System.Drawing.Size(37, 17)
        Me.rad32.TabIndex = 4
        Me.rad32.TabStop = True
        Me.rad32.Text = "32"
        Me.rad32.UseVisualStyleBackColor = True
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 483)
        Me.Controls.Add(Me.grpFontSize)
        Me.Controls.Add(Me.grpFontStyle)
        Me.Controls.Add(Me.grpFontType)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblCharCount)
        Me.Controls.Add(Me.txtFont)
        Me.Controls.Add(Me.lblFont)
        Me.Name = "TextEditor"
        Me.Text = "Super Duper Text Editor"
        Me.grpFontType.ResumeLayout(False)
        Me.grpFontStyle.ResumeLayout(False)
        Me.grpFontSize.ResumeLayout(False)
        Me.grpFontSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFont As System.Windows.Forms.Label
    Friend WithEvents txtFont As System.Windows.Forms.TextBox
    Friend WithEvents lblCharCount As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents grpFontType As System.Windows.Forms.GroupBox
    Friend WithEvents btnCourier As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnArial As System.Windows.Forms.Button
    Friend WithEvents grpFontStyle As System.Windows.Forms.GroupBox
    Friend WithEvents btnItalics As System.Windows.Forms.Button
    Friend WithEvents btnBold As System.Windows.Forms.Button
    Friend WithEvents btnRegular As System.Windows.Forms.Button
    Friend WithEvents grpFontSize As System.Windows.Forms.GroupBox
    Friend WithEvents rad8 As System.Windows.Forms.RadioButton
    Friend WithEvents rad32 As System.Windows.Forms.RadioButton
    Friend WithEvents rad24 As System.Windows.Forms.RadioButton
    Friend WithEvents rad18 As System.Windows.Forms.RadioButton
    Friend WithEvents rad12 As System.Windows.Forms.RadioButton

End Class
