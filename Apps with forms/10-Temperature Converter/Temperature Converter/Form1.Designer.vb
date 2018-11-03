<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConverter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCentigrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Centigrade"
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(12, 208)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(102, 41)
        Me.btnMin.TabIndex = 2
        Me.btnMin.Text = "MIN"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(170, 208)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(102, 41)
        Me.btnMax.TabIndex = 3
        Me.btnMax.Text = "MAX"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(117, 16)
        Me.VScrollBar1.Maximum = 180
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(50, 233)
        Me.VScrollBar1.TabIndex = 4
        Me.VScrollBar1.Value = 180
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Enabled = False
        Me.txtFahrenheit.Location = New System.Drawing.Point(12, 32)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.ReadOnly = True
        Me.txtFahrenheit.Size = New System.Drawing.Size(102, 20)
        Me.txtFahrenheit.TabIndex = 5
        Me.txtFahrenheit.Text = "-50"
        '
        'txtCentigrade
        '
        Me.txtCentigrade.Enabled = False
        Me.txtCentigrade.Location = New System.Drawing.Point(170, 32)
        Me.txtCentigrade.Name = "txtCentigrade"
        Me.txtCentigrade.ReadOnly = True
        Me.txtCentigrade.Size = New System.Drawing.Size(102, 20)
        Me.txtCentigrade.TabIndex = 6
        Me.txtCentigrade.Text = "-46"
        '
        'TemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtCentigrade)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TemperatureConverter"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents txtCentigrade As System.Windows.Forms.TextBox

End Class
