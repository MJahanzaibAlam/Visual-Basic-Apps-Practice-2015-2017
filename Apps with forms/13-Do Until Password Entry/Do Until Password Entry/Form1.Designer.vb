<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoUntil
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
        Me.btnPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPass
        '
        Me.btnPass.Location = New System.Drawing.Point(12, 12)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(232, 87)
        Me.btnPass.TabIndex = 0
        Me.btnPass.Text = "Enter Password"
        Me.btnPass.UseVisualStyleBackColor = True
        '
        'DoUntil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 111)
        Me.Controls.Add(Me.btnPass)
        Me.Name = "DoUntil"
        Me.Text = "Do Until Password Entry"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPass As System.Windows.Forms.Button

End Class
