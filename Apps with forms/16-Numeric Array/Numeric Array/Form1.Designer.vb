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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAddArray = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDisplayArray = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblDisplaySearch = New System.Windows.Forms.Label()
        Me.txtSearchNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindNumber = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(437, 224)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddArray)
        Me.TabPage1.Controls.Add(Me.txtInput)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(429, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAddArray
        '
        Me.btnAddArray.Location = New System.Drawing.Point(276, 157)
        Me.btnAddArray.Name = "btnAddArray"
        Me.btnAddArray.Size = New System.Drawing.Size(147, 35)
        Me.btnAddArray.TabIndex = 5
        Me.btnAddArray.Text = "Add to Array"
        Me.btnAddArray.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(28, 53)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(174, 20)
        Me.txtInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number between 0 and 100:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDisplayArray)
        Me.TabPage2.Controls.Add(Me.lstNumbers)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(429, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Output"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDisplayArray
        '
        Me.btnDisplayArray.Location = New System.Drawing.Point(276, 157)
        Me.btnDisplayArray.Name = "btnDisplayArray"
        Me.btnDisplayArray.Size = New System.Drawing.Size(147, 35)
        Me.btnDisplayArray.TabIndex = 6
        Me.btnDisplayArray.Text = "Display Array"
        Me.btnDisplayArray.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(23, 14)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(161, 160)
        Me.lstNumbers.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblDisplaySearch)
        Me.TabPage3.Controls.Add(Me.txtSearchNumber)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.btnFindNumber)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(429, 198)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Search"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblDisplaySearch
        '
        Me.lblDisplaySearch.AutoSize = True
        Me.lblDisplaySearch.Location = New System.Drawing.Point(36, 89)
        Me.lblDisplaySearch.Name = "lblDisplaySearch"
        Me.lblDisplaySearch.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplaySearch.TabIndex = 10
        '
        'txtSearchNumber
        '
        Me.txtSearchNumber.Location = New System.Drawing.Point(209, 18)
        Me.txtSearchNumber.Name = "txtSearchNumber"
        Me.txtSearchNumber.Size = New System.Drawing.Size(174, 20)
        Me.txtSearchNumber.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter a number to search for:"
        '
        'btnFindNumber
        '
        Me.btnFindNumber.Location = New System.Drawing.Point(276, 157)
        Me.btnFindNumber.Name = "btnFindNumber"
        Me.btnFindNumber.Size = New System.Drawing.Size(147, 35)
        Me.btnFindNumber.TabIndex = 7
        Me.btnFindNumber.Text = "Find Number"
        Me.btnFindNumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 248)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddArray As System.Windows.Forms.Button
    Friend WithEvents btnDisplayArray As System.Windows.Forms.Button
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox
    Friend WithEvents btnFindNumber As System.Windows.Forms.Button
    Friend WithEvents txtSearchNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDisplaySearch As System.Windows.Forms.Label

End Class
