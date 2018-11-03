<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayClassMethods
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
        Me.btnFillArray = New System.Windows.Forms.Button()
        Me.btnSortArray = New System.Windows.Forms.Button()
        Me.btnReverseArray = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFillArray
        '
        Me.btnFillArray.Location = New System.Drawing.Point(261, 12)
        Me.btnFillArray.Name = "btnFillArray"
        Me.btnFillArray.Size = New System.Drawing.Size(100, 38)
        Me.btnFillArray.TabIndex = 0
        Me.btnFillArray.Text = "Fill Array"
        Me.btnFillArray.UseVisualStyleBackColor = True
        '
        'btnSortArray
        '
        Me.btnSortArray.Location = New System.Drawing.Point(261, 56)
        Me.btnSortArray.Name = "btnSortArray"
        Me.btnSortArray.Size = New System.Drawing.Size(100, 38)
        Me.btnSortArray.TabIndex = 1
        Me.btnSortArray.Text = "Sort Array"
        Me.btnSortArray.UseVisualStyleBackColor = True
        '
        'btnReverseArray
        '
        Me.btnReverseArray.Location = New System.Drawing.Point(261, 100)
        Me.btnReverseArray.Name = "btnReverseArray"
        Me.btnReverseArray.Size = New System.Drawing.Size(100, 38)
        Me.btnReverseArray.TabIndex = 2
        Me.btnReverseArray.Text = "Reverse Array"
        Me.btnReverseArray.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Progress"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(233, 151)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 5
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 149)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(146, 21)
        Me.ProgressBar1.TabIndex = 6
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(26, 12)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(227, 126)
        Me.txtOutput.TabIndex = 7
        '
        'ArrayClassMethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 182)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReverseArray)
        Me.Controls.Add(Me.btnSortArray)
        Me.Controls.Add(Me.btnFillArray)
        Me.Name = "ArrayClassMethods"
        Me.Text = "Array Class Methods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFillArray As System.Windows.Forms.Button
    Friend WithEvents btnSortArray As System.Windows.Forms.Button
    Friend WithEvents btnReverseArray As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
