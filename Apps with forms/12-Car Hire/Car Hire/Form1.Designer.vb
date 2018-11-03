<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarHire
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
        Me.lstVehicleType = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtCostPerDay = New System.Windows.Forms.TextBox()
        Me.txtStandingCharge = New System.Windows.Forms.TextBox()
        Me.txtKmTotal = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtTotalIncVat = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtTotalExVat = New System.Windows.Forms.TextBox()
        Me.txtCostPerKm = New System.Windows.Forms.TextBox()
        Me.txtDayTotal = New System.Windows.Forms.TextBox()
        Me.txtNumDays = New System.Windows.Forms.TextBox()
        Me.chkInsuranceTaken = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstVehicleType
        '
        Me.lstVehicleType.FormattingEnabled = True
        Me.lstVehicleType.Items.AddRange(New Object() {"Economic", "Value", "Luxury"})
        Me.lstVehicleType.Location = New System.Drawing.Point(12, 36)
        Me.lstVehicleType.Name = "lstVehicleType"
        Me.lstVehicleType.Size = New System.Drawing.Size(156, 108)
        Me.lstVehicleType.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 314)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(152, 55)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(170, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtCostPerDay
        '
        Me.txtCostPerDay.Location = New System.Drawing.Point(192, 36)
        Me.txtCostPerDay.Name = "txtCostPerDay"
        Me.txtCostPerDay.ReadOnly = True
        Me.txtCostPerDay.Size = New System.Drawing.Size(68, 20)
        Me.txtCostPerDay.TabIndex = 3
        '
        'txtStandingCharge
        '
        Me.txtStandingCharge.Location = New System.Drawing.Point(415, 191)
        Me.txtStandingCharge.Name = "txtStandingCharge"
        Me.txtStandingCharge.ReadOnly = True
        Me.txtStandingCharge.Size = New System.Drawing.Size(68, 20)
        Me.txtStandingCharge.TabIndex = 4
        '
        'txtKmTotal
        '
        Me.txtKmTotal.Location = New System.Drawing.Point(415, 124)
        Me.txtKmTotal.Name = "txtKmTotal"
        Me.txtKmTotal.ReadOnly = True
        Me.txtKmTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtKmTotal.TabIndex = 5
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(300, 124)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(68, 20)
        Me.txtDistance.TabIndex = 6
        '
        'txtTotalIncVat
        '
        Me.txtTotalIncVat.Location = New System.Drawing.Point(415, 349)
        Me.txtTotalIncVat.Name = "txtTotalIncVat"
        Me.txtTotalIncVat.ReadOnly = True
        Me.txtTotalIncVat.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalIncVat.TabIndex = 7
        '
        'txtVAT
        '
        Me.txtVAT.Location = New System.Drawing.Point(415, 295)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(68, 20)
        Me.txtVAT.TabIndex = 8
        '
        'txtTotalExVat
        '
        Me.txtTotalExVat.Location = New System.Drawing.Point(415, 246)
        Me.txtTotalExVat.Name = "txtTotalExVat"
        Me.txtTotalExVat.ReadOnly = True
        Me.txtTotalExVat.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalExVat.TabIndex = 9
        '
        'txtCostPerKm
        '
        Me.txtCostPerKm.Location = New System.Drawing.Point(192, 124)
        Me.txtCostPerKm.Name = "txtCostPerKm"
        Me.txtCostPerKm.ReadOnly = True
        Me.txtCostPerKm.Size = New System.Drawing.Size(68, 20)
        Me.txtCostPerKm.TabIndex = 10
        Me.txtCostPerKm.Text = "0.28"
        '
        'txtDayTotal
        '
        Me.txtDayTotal.Location = New System.Drawing.Point(415, 36)
        Me.txtDayTotal.Name = "txtDayTotal"
        Me.txtDayTotal.ReadOnly = True
        Me.txtDayTotal.Size = New System.Drawing.Size(68, 20)
        Me.txtDayTotal.TabIndex = 11
        '
        'txtNumDays
        '
        Me.txtNumDays.Location = New System.Drawing.Point(300, 36)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(68, 20)
        Me.txtNumDays.TabIndex = 12
        '
        'chkInsuranceTaken
        '
        Me.chkInsuranceTaken.AutoSize = True
        Me.chkInsuranceTaken.Location = New System.Drawing.Point(15, 169)
        Me.chkInsuranceTaken.Name = "chkInsuranceTaken"
        Me.chkInsuranceTaken.Size = New System.Drawing.Size(104, 17)
        Me.chkInsuranceTaken.TabIndex = 13
        Me.chkInsuranceTaken.Text = "InsuranceTaken"
        Me.chkInsuranceTaken.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select Vehicle Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cost/Day:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No of Days:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Day Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cost/Km:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Distance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Km Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Standing Charge:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Total (ex VAT):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(305, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "VAT:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(305, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total (inc VAT):"
        '
        'CarHire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 381)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkInsuranceTaken)
        Me.Controls.Add(Me.txtNumDays)
        Me.Controls.Add(Me.txtDayTotal)
        Me.Controls.Add(Me.txtCostPerKm)
        Me.Controls.Add(Me.txtTotalExVat)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.txtTotalIncVat)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtKmTotal)
        Me.Controls.Add(Me.txtStandingCharge)
        Me.Controls.Add(Me.txtCostPerDay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstVehicleType)
        Me.Name = "CarHire"
        Me.Text = "Car Hire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstVehicleType As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtCostPerDay As System.Windows.Forms.TextBox
    Friend WithEvents txtStandingCharge As System.Windows.Forms.TextBox
    Friend WithEvents txtKmTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIncVat As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalExVat As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerKm As System.Windows.Forms.TextBox
    Friend WithEvents txtDayTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDays As System.Windows.Forms.TextBox
    Friend WithEvents chkInsuranceTaken As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
