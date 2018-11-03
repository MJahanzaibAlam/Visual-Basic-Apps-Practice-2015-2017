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
        Me.lblCourt1 = New System.Windows.Forms.Label()
        Me.lblCourt2 = New System.Windows.Forms.Label()
        Me.lblCourt3 = New System.Windows.Forms.Label()
        Me.lblCourt4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtCourtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCourt1
        '
        Me.lblCourt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourt1.BackColor = System.Drawing.Color.Maroon
        Me.lblCourt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourt1.Location = New System.Drawing.Point(49, 26)
        Me.lblCourt1.Name = "lblCourt1"
        Me.lblCourt1.Size = New System.Drawing.Size(95, 40)
        Me.lblCourt1.TabIndex = 0
        Me.lblCourt1.Text = "1"
        Me.lblCourt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourt2
        '
        Me.lblCourt2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourt2.BackColor = System.Drawing.Color.Maroon
        Me.lblCourt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourt2.Location = New System.Drawing.Point(49, 81)
        Me.lblCourt2.Name = "lblCourt2"
        Me.lblCourt2.Size = New System.Drawing.Size(95, 40)
        Me.lblCourt2.TabIndex = 1
        Me.lblCourt2.Text = "2"
        Me.lblCourt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourt3
        '
        Me.lblCourt3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourt3.BackColor = System.Drawing.Color.Maroon
        Me.lblCourt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourt3.Location = New System.Drawing.Point(49, 134)
        Me.lblCourt3.Name = "lblCourt3"
        Me.lblCourt3.Size = New System.Drawing.Size(95, 40)
        Me.lblCourt3.TabIndex = 2
        Me.lblCourt3.Text = "3"
        Me.lblCourt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourt4
        '
        Me.lblCourt4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourt4.BackColor = System.Drawing.Color.Maroon
        Me.lblCourt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourt4.Location = New System.Drawing.Point(49, 192)
        Me.lblCourt4.Name = "lblCourt4"
        Me.lblCourt4.Size = New System.Drawing.Size(95, 40)
        Me.lblCourt4.TabIndex = 3
        Me.lblCourt4.Text = "4"
        Me.lblCourt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Court Number:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(311, 204)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(41, 30)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtCourtNumber
        '
        Me.txtCourtNumber.AcceptsReturn = True
        Me.txtCourtNumber.Location = New System.Drawing.Point(252, 41)
        Me.txtCourtNumber.Multiline = True
        Me.txtCourtNumber.Name = "txtCourtNumber"
        Me.txtCourtNumber.Size = New System.Drawing.Size(100, 25)
        Me.txtCourtNumber.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 265)
        Me.Controls.Add(Me.txtCourtNumber)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCourt4)
        Me.Controls.Add(Me.lblCourt3)
        Me.Controls.Add(Me.lblCourt2)
        Me.Controls.Add(Me.lblCourt1)
        Me.Name = "Form1"
        Me.Text = "Control Array - Tennis Court Hire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCourt1 As System.Windows.Forms.Label
    Friend WithEvents lblCourt2 As System.Windows.Forms.Label
    Friend WithEvents lblCourt3 As System.Windows.Forms.Label
    Friend WithEvents lblCourt4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtCourtNumber As System.Windows.Forms.TextBox

End Class
