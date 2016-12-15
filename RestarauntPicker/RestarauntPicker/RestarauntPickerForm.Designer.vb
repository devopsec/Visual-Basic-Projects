<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestarauntPickerForm
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
        Me.tbxAddRestaraunt = New System.Windows.Forms.TextBox()
        Me.lbxRestaraunts = New System.Windows.Forms.ListBox()
        Me.btnRandomRestaraunt = New System.Windows.Forms.Button()
        Me.btnAddRestaraunt = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxAddRestaraunt
        '
        Me.tbxAddRestaraunt.Location = New System.Drawing.Point(164, 258)
        Me.tbxAddRestaraunt.Name = "tbxAddRestaraunt"
        Me.tbxAddRestaraunt.Size = New System.Drawing.Size(168, 20)
        Me.tbxAddRestaraunt.TabIndex = 0
        '
        'lbxRestaraunts
        '
        Me.lbxRestaraunts.FormattingEnabled = True
        Me.lbxRestaraunts.Items.AddRange(New Object() {"McDonald’s", "Arby’s", "Applebee’s", "Texas Roadhouse", "White Castle"})
        Me.lbxRestaraunts.Location = New System.Drawing.Point(164, 38)
        Me.lbxRestaraunts.Name = "lbxRestaraunts"
        Me.lbxRestaraunts.Size = New System.Drawing.Size(168, 173)
        Me.lbxRestaraunts.TabIndex = 1
        '
        'btnRandomRestaraunt
        '
        Me.btnRandomRestaraunt.Location = New System.Drawing.Point(33, 314)
        Me.btnRandomRestaraunt.Name = "btnRandomRestaraunt"
        Me.btnRandomRestaraunt.Size = New System.Drawing.Size(104, 23)
        Me.btnRandomRestaraunt.TabIndex = 2
        Me.btnRandomRestaraunt.Text = "Pick Restaraunt"
        Me.btnRandomRestaraunt.UseVisualStyleBackColor = True
        '
        'btnAddRestaraunt
        '
        Me.btnAddRestaraunt.Location = New System.Drawing.Point(199, 314)
        Me.btnAddRestaraunt.Name = "btnAddRestaraunt"
        Me.btnAddRestaraunt.Size = New System.Drawing.Size(95, 23)
        Me.btnAddRestaraunt.TabIndex = 3
        Me.btnAddRestaraunt.Text = "Add Restaraunt"
        Me.btnAddRestaraunt.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(360, 314)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RestarauntPickerForm
        '
        Me.AcceptButton = Me.btnAddRestaraunt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 371)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddRestaraunt)
        Me.Controls.Add(Me.btnRandomRestaraunt)
        Me.Controls.Add(Me.lbxRestaraunts)
        Me.Controls.Add(Me.tbxAddRestaraunt)
        Me.Name = "RestarauntPickerForm"
        Me.Text = "RestarauntPickerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbxAddRestaraunt As System.Windows.Forms.TextBox
    Friend WithEvents lbxRestaraunts As System.Windows.Forms.ListBox
    Friend WithEvents btnRandomRestaraunt As System.Windows.Forms.Button
    Friend WithEvents btnAddRestaraunt As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
