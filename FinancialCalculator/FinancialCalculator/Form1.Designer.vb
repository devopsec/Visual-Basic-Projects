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
        Me.gbxSavings = New System.Windows.Forms.GroupBox()
        Me.cbxSavingsInterest = New System.Windows.Forms.CheckBox()
        Me.tbxSavingsYears = New System.Windows.Forms.TextBox()
        Me.btnSavingsCalculate = New System.Windows.Forms.Button()
        Me.tbxSavingsInvestment = New System.Windows.Forms.TextBox()
        Me.lvlSavings = New System.Windows.Forms.Label()
        Me.gbxStocks = New System.Windows.Forms.GroupBox()
        Me.cbxStockInterest = New System.Windows.Forms.CheckBox()
        Me.tbxStockYears = New System.Windows.Forms.TextBox()
        Me.btnStockCalculate = New System.Windows.Forms.Button()
        Me.tbxStockInvestment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbxDataOutput = New System.Windows.Forms.ListBox()
        Me.lbxPayPeriod = New System.Windows.Forms.ListBox()
        Me.lblPayPeriod = New System.Windows.Forms.Label()
        Me.lblDataOutput = New System.Windows.Forms.Label()
        Me.vsbScrollData = New System.Windows.Forms.VScrollBar()
        Me.gbxSavings.SuspendLayout()
        Me.gbxStocks.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxSavings
        '
        Me.gbxSavings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxSavings.Controls.Add(Me.cbxSavingsInterest)
        Me.gbxSavings.Controls.Add(Me.tbxSavingsYears)
        Me.gbxSavings.Controls.Add(Me.btnSavingsCalculate)
        Me.gbxSavings.Controls.Add(Me.tbxSavingsInvestment)
        Me.gbxSavings.Controls.Add(Me.lvlSavings)
        Me.gbxSavings.Cursor = System.Windows.Forms.Cursors.Cross
        Me.gbxSavings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxSavings.Location = New System.Drawing.Point(89, 51)
        Me.gbxSavings.Name = "gbxSavings"
        Me.gbxSavings.Size = New System.Drawing.Size(397, 190)
        Me.gbxSavings.TabIndex = 0
        Me.gbxSavings.TabStop = False
        '
        'cbxSavingsInterest
        '
        Me.cbxSavingsInterest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxSavingsInterest.AutoSize = True
        Me.cbxSavingsInterest.Location = New System.Drawing.Point(42, 117)
        Me.cbxSavingsInterest.Name = "cbxSavingsInterest"
        Me.cbxSavingsInterest.Size = New System.Drawing.Size(104, 17)
        Me.cbxSavingsInterest.TabIndex = 3
        Me.cbxSavingsInterest.Text = "Accrued Interest"
        Me.cbxSavingsInterest.UseVisualStyleBackColor = True
        '
        'tbxSavingsYears
        '
        Me.tbxSavingsYears.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxSavingsYears.Location = New System.Drawing.Point(217, 54)
        Me.tbxSavingsYears.Name = "tbxSavingsYears"
        Me.tbxSavingsYears.Size = New System.Drawing.Size(120, 20)
        Me.tbxSavingsYears.TabIndex = 2
        Me.tbxSavingsYears.Text = "Investment Time (yrs)"
        Me.tbxSavingsYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSavingsCalculate
        '
        Me.btnSavingsCalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSavingsCalculate.Location = New System.Drawing.Point(240, 110)
        Me.btnSavingsCalculate.Name = "btnSavingsCalculate"
        Me.btnSavingsCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnSavingsCalculate.TabIndex = 4
        Me.btnSavingsCalculate.Text = "Calculate"
        Me.btnSavingsCalculate.UseVisualStyleBackColor = True
        '
        'tbxSavingsInvestment
        '
        Me.tbxSavingsInvestment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxSavingsInvestment.Location = New System.Drawing.Point(35, 54)
        Me.tbxSavingsInvestment.Name = "tbxSavingsInvestment"
        Me.tbxSavingsInvestment.Size = New System.Drawing.Size(115, 20)
        Me.tbxSavingsInvestment.TabIndex = 1
        Me.tbxSavingsInvestment.Text = "Enter Investment"
        Me.tbxSavingsInvestment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvlSavings
        '
        Me.lvlSavings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lvlSavings.AutoSize = True
        Me.lvlSavings.Location = New System.Drawing.Point(148, 3)
        Me.lvlSavings.Name = "lvlSavings"
        Me.lvlSavings.Size = New System.Drawing.Size(95, 13)
        Me.lvlSavings.TabIndex = 0
        Me.lvlSavings.Text = "Savings Calculator"
        '
        'gbxStocks
        '
        Me.gbxStocks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxStocks.Controls.Add(Me.cbxStockInterest)
        Me.gbxStocks.Controls.Add(Me.tbxStockYears)
        Me.gbxStocks.Controls.Add(Me.btnStockCalculate)
        Me.gbxStocks.Controls.Add(Me.tbxStockInvestment)
        Me.gbxStocks.Controls.Add(Me.Label2)
        Me.gbxStocks.Cursor = System.Windows.Forms.Cursors.Cross
        Me.gbxStocks.Location = New System.Drawing.Point(89, 299)
        Me.gbxStocks.Name = "gbxStocks"
        Me.gbxStocks.Size = New System.Drawing.Size(397, 190)
        Me.gbxStocks.TabIndex = 1
        Me.gbxStocks.TabStop = False
        '
        'cbxStockInterest
        '
        Me.cbxStockInterest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxStockInterest.AutoSize = True
        Me.cbxStockInterest.Location = New System.Drawing.Point(41, 109)
        Me.cbxStockInterest.Name = "cbxStockInterest"
        Me.cbxStockInterest.Size = New System.Drawing.Size(104, 17)
        Me.cbxStockInterest.TabIndex = 3
        Me.cbxStockInterest.Text = "Accrued Interest"
        Me.cbxStockInterest.UseVisualStyleBackColor = True
        '
        'tbxStockYears
        '
        Me.tbxStockYears.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxStockYears.Location = New System.Drawing.Point(217, 46)
        Me.tbxStockYears.Name = "tbxStockYears"
        Me.tbxStockYears.Size = New System.Drawing.Size(120, 20)
        Me.tbxStockYears.TabIndex = 2
        Me.tbxStockYears.Text = "Investment Time (yrs)"
        Me.tbxStockYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStockCalculate
        '
        Me.btnStockCalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStockCalculate.Location = New System.Drawing.Point(240, 105)
        Me.btnStockCalculate.Name = "btnStockCalculate"
        Me.btnStockCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnStockCalculate.TabIndex = 4
        Me.btnStockCalculate.Text = "Calculate"
        Me.btnStockCalculate.UseVisualStyleBackColor = True
        '
        'tbxStockInvestment
        '
        Me.tbxStockInvestment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbxStockInvestment.Location = New System.Drawing.Point(35, 46)
        Me.tbxStockInvestment.Name = "tbxStockInvestment"
        Me.tbxStockInvestment.Size = New System.Drawing.Size(115, 20)
        Me.tbxStockInvestment.TabIndex = 1
        Me.tbxStockInvestment.Text = "Enter Investment"
        Me.tbxStockInvestment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock Calulator"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotal.Location = New System.Drawing.Point(89, 256)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(397, 25)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "display value here"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotal.Visible = False
        '
        'lbxDataOutput
        '
        Me.lbxDataOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbxDataOutput.FormattingEnabled = True
        Me.lbxDataOutput.Location = New System.Drawing.Point(59, 524)
        Me.lbxDataOutput.Name = "lbxDataOutput"
        Me.lbxDataOutput.Size = New System.Drawing.Size(506, 95)
        Me.lbxDataOutput.TabIndex = 3
        Me.lbxDataOutput.TabStop = False
        '
        'lbxPayPeriod
        '
        Me.lbxPayPeriod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbxPayPeriod.FormattingEnabled = True
        Me.lbxPayPeriod.Location = New System.Drawing.Point(0, 524)
        Me.lbxPayPeriod.Name = "lbxPayPeriod"
        Me.lbxPayPeriod.Size = New System.Drawing.Size(59, 95)
        Me.lbxPayPeriod.TabIndex = 4
        Me.lbxPayPeriod.TabStop = False
        '
        'lblPayPeriod
        '
        Me.lblPayPeriod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPayPeriod.AutoSize = True
        Me.lblPayPeriod.Location = New System.Drawing.Point(0, 508)
        Me.lblPayPeriod.Name = "lblPayPeriod"
        Me.lblPayPeriod.Size = New System.Drawing.Size(58, 13)
        Me.lblPayPeriod.TabIndex = 5
        Me.lblPayPeriod.Text = "Pay Period"
        Me.lblPayPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataOutput
        '
        Me.lblDataOutput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDataOutput.AutoSize = True
        Me.lblDataOutput.Location = New System.Drawing.Point(262, 508)
        Me.lblDataOutput.Name = "lblDataOutput"
        Me.lblDataOutput.Size = New System.Drawing.Size(113, 13)
        Me.lblDataOutput.TabIndex = 6
        Me.lblDataOutput.Text = "Extended Data Output"
        Me.lblDataOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vsbScrollData
        '
        Me.vsbScrollData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vsbScrollData.LargeChange = 4
        Me.vsbScrollData.Location = New System.Drawing.Point(566, 524)
        Me.vsbScrollData.Maximum = 400
        Me.vsbScrollData.Name = "vsbScrollData"
        Me.vsbScrollData.Size = New System.Drawing.Size(17, 95)
        Me.vsbScrollData.TabIndex = 7
        Me.vsbScrollData.TabStop = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinancialCalculator.My.Resources.Resources.form_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 619)
        Me.Controls.Add(Me.vsbScrollData)
        Me.Controls.Add(Me.lblDataOutput)
        Me.Controls.Add(Me.lblPayPeriod)
        Me.Controls.Add(Me.lbxPayPeriod)
        Me.Controls.Add(Me.lbxDataOutput)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.gbxStocks)
        Me.Controls.Add(Me.gbxSavings)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Calculator"
        Me.gbxSavings.ResumeLayout(False)
        Me.gbxSavings.PerformLayout()
        Me.gbxStocks.ResumeLayout(False)
        Me.gbxStocks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxSavings As GroupBox
    Friend WithEvents gbxStocks As GroupBox
    Friend WithEvents cbxSavingsInterest As CheckBox
    Friend WithEvents tbxSavingsYears As TextBox
    Friend WithEvents btnSavingsCalculate As Button
    Friend WithEvents tbxSavingsInvestment As TextBox
    Friend WithEvents lvlSavings As Label
    Friend WithEvents cbxStockInterest As CheckBox
    Friend WithEvents tbxStockYears As TextBox
    Friend WithEvents btnStockCalculate As Button
    Friend WithEvents tbxStockInvestment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lbxDataOutput As ListBox
    Friend WithEvents lbxPayPeriod As ListBox
    Friend WithEvents lblPayPeriod As Label
    Friend WithEvents lblDataOutput As Label
    Friend WithEvents vsbScrollData As VScrollBar
End Class
