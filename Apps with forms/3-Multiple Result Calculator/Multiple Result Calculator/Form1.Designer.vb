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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnLabelResult = New System.Windows.Forms.Button()
        Me.btnTextBoxResult = New System.Windows.Forms.Button()
        Me.btnMessageboxResult = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(12, 9)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(131, 24)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First Number"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(149, 14)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNumber.TabIndex = 1
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(255, 9)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(163, 24)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "Second Number"
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(424, 13)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNumber.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(13, 52)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result"
        '
        'btnLabelResult
        '
        Me.btnLabelResult.Location = New System.Drawing.Point(12, 265)
        Me.btnLabelResult.Name = "btnLabelResult"
        Me.btnLabelResult.Size = New System.Drawing.Size(90, 36)
        Me.btnLabelResult.TabIndex = 5
        Me.btnLabelResult.Text = "Label Result"
        Me.btnLabelResult.UseVisualStyleBackColor = True
        '
        'btnTextBoxResult
        '
        Me.btnTextBoxResult.Location = New System.Drawing.Point(118, 265)
        Me.btnTextBoxResult.Name = "btnTextBoxResult"
        Me.btnTextBoxResult.Size = New System.Drawing.Size(89, 36)
        Me.btnTextBoxResult.TabIndex = 6
        Me.btnTextBoxResult.Text = "Textbox Result"
        Me.btnTextBoxResult.UseVisualStyleBackColor = True
        '
        'btnMessageboxResult
        '
        Me.btnMessageboxResult.Location = New System.Drawing.Point(229, 265)
        Me.btnMessageboxResult.Name = "btnMessageboxResult"
        Me.btnMessageboxResult.Size = New System.Drawing.Size(92, 36)
        Me.btnMessageboxResult.TabIndex = 7
        Me.btnMessageboxResult.Text = "Messagebox Result"
        Me.btnMessageboxResult.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(503, 265)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(259, 52)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(336, 207)
        Me.txtResult.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 313)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMessageboxResult)
        Me.Controls.Add(Me.btnTextBoxResult)
        Me.Controls.Add(Me.btnLabelResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Multiple Result Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents txtFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnLabelResult As System.Windows.Forms.Button
    Friend WithEvents btnTextBoxResult As System.Windows.Forms.Button
    Friend WithEvents btnMessageboxResult As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
