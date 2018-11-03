<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighTemperatures
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
        Me.btnEnterTemp = New System.Windows.Forms.Button()
        Me.btnDisplayTemp = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnterTemp
        '
        Me.btnEnterTemp.Location = New System.Drawing.Point(12, 126)
        Me.btnEnterTemp.Name = "btnEnterTemp"
        Me.btnEnterTemp.Size = New System.Drawing.Size(107, 49)
        Me.btnEnterTemp.TabIndex = 1
        Me.btnEnterTemp.Text = "Enter Temperature"
        Me.btnEnterTemp.UseVisualStyleBackColor = True
        '
        'btnDisplayTemp
        '
        Me.btnDisplayTemp.Location = New System.Drawing.Point(125, 126)
        Me.btnDisplayTemp.Name = "btnDisplayTemp"
        Me.btnDisplayTemp.Size = New System.Drawing.Size(107, 49)
        Me.btnDisplayTemp.TabIndex = 2
        Me.btnDisplayTemp.Text = "Display Temperature"
        Me.btnDisplayTemp.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 12)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(220, 108)
        Me.txtOutput.TabIndex = 3
        '
        'HighTemperatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 182)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDisplayTemp)
        Me.Controls.Add(Me.btnEnterTemp)
        Me.Name = "HighTemperatures"
        Me.Text = "High Temperatures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterTemp As System.Windows.Forms.Button
    Friend WithEvents btnDisplayTemp As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
