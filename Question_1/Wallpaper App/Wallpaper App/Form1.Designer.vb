<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wallpaper_app
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblRollCoverage = New System.Windows.Forms.Label()
        Me.lblSingleRoll = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbLength = New System.Windows.Forms.ComboBox()
        Me.cmbWidth = New System.Windows.Forms.ComboBox()
        Me.cmbHeight = New System.Windows.Forms.ComboBox()
        Me.cmbRollCoverage = New System.Windows.Forms.ComboBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(33, 75)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(140, 25)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length (feet):"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(33, 195)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(129, 25)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Width (feet):"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(33, 306)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(136, 25)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Heigth (feet):"
        '
        'lblRollCoverage
        '
        Me.lblRollCoverage.AutoSize = True
        Me.lblRollCoverage.Location = New System.Drawing.Point(33, 405)
        Me.lblRollCoverage.Name = "lblRollCoverage"
        Me.lblRollCoverage.Size = New System.Drawing.Size(226, 25)
        Me.lblRollCoverage.TabIndex = 6
        Me.lblRollCoverage.Text = "Roll coverage (sqrFT):"
        '
        'lblSingleRoll
        '
        Me.lblSingleRoll.AutoSize = True
        Me.lblSingleRoll.Location = New System.Drawing.Point(517, 149)
        Me.lblSingleRoll.Name = "lblSingleRoll"
        Me.lblSingleRoll.Size = New System.Drawing.Size(113, 25)
        Me.lblSingleRoll.TabIndex = 8
        Me.lblSingleRoll.Text = "Single roll:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(522, 291)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(164, 55)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(692, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 55)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmbLength
        '
        Me.cmbLength.FormattingEnabled = True
        Me.cmbLength.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.cmbLength.Location = New System.Drawing.Point(265, 67)
        Me.cmbLength.Name = "cmbLength"
        Me.cmbLength.Size = New System.Drawing.Size(194, 33)
        Me.cmbLength.TabIndex = 1
        '
        'cmbWidth
        '
        Me.cmbWidth.FormattingEnabled = True
        Me.cmbWidth.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.cmbWidth.Location = New System.Drawing.Point(265, 187)
        Me.cmbWidth.Name = "cmbWidth"
        Me.cmbWidth.Size = New System.Drawing.Size(194, 33)
        Me.cmbWidth.TabIndex = 3
        '
        'cmbHeight
        '
        Me.cmbHeight.FormattingEnabled = True
        Me.cmbHeight.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.cmbHeight.Location = New System.Drawing.Point(265, 298)
        Me.cmbHeight.Name = "cmbHeight"
        Me.cmbHeight.Size = New System.Drawing.Size(194, 33)
        Me.cmbHeight.TabIndex = 5
        '
        'cmbRollCoverage
        '
        Me.cmbRollCoverage.FormattingEnabled = True
        Me.cmbRollCoverage.Items.AddRange(New Object() {"40", "40,5", "41", "41,5", "42", "42,5", "43", "43,5", "44", "44,5", "45", "45,5", "46", "46,5", "47", "47,5", "48", "48,5", "49", "49,5", "50"})
        Me.cmbRollCoverage.Location = New System.Drawing.Point(265, 397)
        Me.cmbRollCoverage.Name = "cmbRollCoverage"
        Me.cmbRollCoverage.Size = New System.Drawing.Size(194, 33)
        Me.cmbRollCoverage.TabIndex = 7
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(522, 215)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(334, 31)
        Me.txtResult.TabIndex = 12
        '
        'Wallpaper_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 501)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.cmbRollCoverage)
        Me.Controls.Add(Me.cmbHeight)
        Me.Controls.Add(Me.cmbWidth)
        Me.Controls.Add(Me.cmbLength)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSingleRoll)
        Me.Controls.Add(Me.lblRollCoverage)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "Wallpaper_app"
        Me.Text = "Wallpaper App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblRollCoverage As Label
    Friend WithEvents lblSingleRoll As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbLength As ComboBox
    Friend WithEvents cmbWidth As ComboBox
    Friend WithEvents cmbHeight As ComboBox
    Friend WithEvents cmbRollCoverage As ComboBox
    Friend WithEvents txtResult As TextBox
End Class
