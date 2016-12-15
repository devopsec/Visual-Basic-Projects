<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChosenRestarauntForm
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
        Me.btnRestarauntPicker = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblAddress1Display = New System.Windows.Forms.Label()
        Me.lblAddress2Display = New System.Windows.Forms.Label()
        Me.lblPhoneNumberDisplay = New System.Windows.Forms.Label()
        Me.lblHoursDisplay = New System.Windows.Forms.Label()
        Me.lblChosenRestaraunt = New System.Windows.Forms.Label()
        Me.lblChosenRestarauntDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRestarauntPicker
        '
        Me.btnRestarauntPicker.Location = New System.Drawing.Point(127, 323)
        Me.btnRestarauntPicker.Name = "btnRestarauntPicker"
        Me.btnRestarauntPicker.Size = New System.Drawing.Size(105, 23)
        Me.btnRestarauntPicker.TabIndex = 0
        Me.btnRestarauntPicker.Text = "Pick Another"
        Me.btnRestarauntPicker.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(60, 133)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress1.TabIndex = 2
        Me.lblAddress1.Text = "Address"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(165, 133)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress2.TabIndex = 3
        Me.lblAddress2.Text = "Address"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(274, 133)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 4
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(399, 133)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(96, 13)
        Me.lblHours.TabIndex = 5
        Me.lblHours.Text = "Hours of Operation"
        '
        'lblAddress1Display
        '
        Me.lblAddress1Display.AutoSize = True
        Me.lblAddress1Display.Location = New System.Drawing.Point(60, 184)
        Me.lblAddress1Display.Name = "lblAddress1Display"
        Me.lblAddress1Display.Size = New System.Drawing.Size(39, 13)
        Me.lblAddress1Display.TabIndex = 6
        Me.lblAddress1Display.Text = "Label5"
        '
        'lblAddress2Display
        '
        Me.lblAddress2Display.AutoSize = True
        Me.lblAddress2Display.Location = New System.Drawing.Point(165, 184)
        Me.lblAddress2Display.Name = "lblAddress2Display"
        Me.lblAddress2Display.Size = New System.Drawing.Size(39, 13)
        Me.lblAddress2Display.TabIndex = 7
        Me.lblAddress2Display.Text = "Label6"
        '
        'lblPhoneNumberDisplay
        '
        Me.lblPhoneNumberDisplay.AutoSize = True
        Me.lblPhoneNumberDisplay.Location = New System.Drawing.Point(291, 184)
        Me.lblPhoneNumberDisplay.Name = "lblPhoneNumberDisplay"
        Me.lblPhoneNumberDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblPhoneNumberDisplay.TabIndex = 8
        Me.lblPhoneNumberDisplay.Text = "Label7"
        '
        'lblHoursDisplay
        '
        Me.lblHoursDisplay.AutoSize = True
        Me.lblHoursDisplay.Location = New System.Drawing.Point(426, 184)
        Me.lblHoursDisplay.Name = "lblHoursDisplay"
        Me.lblHoursDisplay.Size = New System.Drawing.Size(39, 13)
        Me.lblHoursDisplay.TabIndex = 9
        Me.lblHoursDisplay.Text = "Label8"
        '
        'lblChosenRestaraunt
        '
        Me.lblChosenRestaraunt.AutoSize = True
        Me.lblChosenRestaraunt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblChosenRestaraunt.Location = New System.Drawing.Point(113, 44)
        Me.lblChosenRestaraunt.Name = "lblChosenRestaraunt"
        Me.lblChosenRestaraunt.Size = New System.Drawing.Size(121, 16)
        Me.lblChosenRestaraunt.TabIndex = 10
        Me.lblChosenRestaraunt.Text = "Picked Restaraunt:"
        '
        'lblChosenRestarauntDisplay
        '
        Me.lblChosenRestarauntDisplay.AutoSize = True
        Me.lblChosenRestarauntDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblChosenRestarauntDisplay.Location = New System.Drawing.Point(277, 46)
        Me.lblChosenRestarauntDisplay.Name = "lblChosenRestarauntDisplay"
        Me.lblChosenRestarauntDisplay.Size = New System.Drawing.Size(57, 17)
        Me.lblChosenRestarauntDisplay.TabIndex = 11
        Me.lblChosenRestarauntDisplay.Text = "Label1"
        '
        'ChosenRestarauntForm
        '
        Me.AcceptButton = Me.btnRestarauntPicker
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 372)
        Me.Controls.Add(Me.lblChosenRestarauntDisplay)
        Me.Controls.Add(Me.lblChosenRestaraunt)
        Me.Controls.Add(Me.lblHoursDisplay)
        Me.Controls.Add(Me.lblPhoneNumberDisplay)
        Me.Controls.Add(Me.lblAddress2Display)
        Me.Controls.Add(Me.lblAddress1Display)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblAddress2)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRestarauntPicker)
        Me.Name = "ChosenRestarauntForm"
        Me.Text = "ChosenRestarauntForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRestarauntPicker As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblAddress1Display As Label
    Friend WithEvents lblAddress2Display As Label
    Friend WithEvents lblPhoneNumberDisplay As Label
    Friend WithEvents lblHoursDisplay As Label
    Private chosenRestaraunt As Integer

    Public Sub New()
        Me.chosenRestaraunt = chosenRestaraunt
    End Sub

    Friend WithEvents lblChosenRestaraunt As Label
    Friend WithEvents lblChosenRestarauntDisplay As Label
End Class
