<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForLoop
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
        Me.lstLoopbox = New System.Windows.Forms.ListBox()
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstLoopbox
        '
        Me.lstLoopbox.FormattingEnabled = True
        Me.lstLoopbox.Location = New System.Drawing.Point(12, 12)
        Me.lstLoopbox.Name = "lstLoopbox"
        Me.lstLoopbox.Size = New System.Drawing.Size(122, 238)
        Me.lstLoopbox.TabIndex = 0
        '
        'btnLoop
        '
        Me.btnLoop.Location = New System.Drawing.Point(147, 196)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(125, 53)
        Me.btnLoop.TabIndex = 1
        Me.btnLoop.Text = "StartForLoop"
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'ForLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 265)
        Me.Controls.Add(Me.btnLoop)
        Me.Controls.Add(Me.lstLoopbox)
        Me.Name = "ForLoop"
        Me.Text = "For...NextLoop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstLoopbox As System.Windows.Forms.ListBox
    Friend WithEvents btnLoop As System.Windows.Forms.Button

End Class
