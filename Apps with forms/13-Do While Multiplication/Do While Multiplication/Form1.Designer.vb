<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoWhileMultiplication
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
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnLoop
        '
        Me.btnLoop.Location = New System.Drawing.Point(64, 172)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(156, 78)
        Me.btnLoop.TabIndex = 0
        Me.btnLoop.Text = "Try Do While Loop!"
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.Location = New System.Drawing.Point(12, 12)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(260, 147)
        Me.lstNumber.TabIndex = 1
        '
        'DoWhileMultiplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.btnLoop)
        Me.Name = "DoWhileMultiplication"
        Me.Text = "Do While Multiplication"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoop As System.Windows.Forms.Button
    Friend WithEvents lstNumber As System.Windows.Forms.ListBox

End Class
