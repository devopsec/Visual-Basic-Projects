<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbxRemoveName = New System.Windows.Forms.ListBox()
        Me.btnRemoveContact = New System.Windows.Forms.Button()
        Me.lbxRemoveAddress = New System.Windows.Forms.ListBox()
        Me.lbxRemoveNumber = New System.Windows.Forms.ListBox()
        Me.lbxRemoveFamily = New System.Windows.Forms.ListBox()
        Me.lblRemoveName = New System.Windows.Forms.Label()
        Me.lblRemoveAddress = New System.Windows.Forms.Label()
        Me.lblRemoveNumber = New System.Windows.Forms.Label()
        Me.lblRemoveFamily = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSave, Me.menuLoad, Me.menuReturn, Me.menuClear})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuSave
        '
        Me.menuSave.Name = "menuSave"
        Me.menuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuSave.Size = New System.Drawing.Size(96, 20)
        Me.menuSave.Text = "Save Contacts "
        '
        'menuLoad
        '
        Me.menuLoad.Name = "menuLoad"
        Me.menuLoad.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.menuLoad.Size = New System.Drawing.Size(95, 20)
        Me.menuLoad.Text = "Load Contacts"
        '
        'menuReturn
        '
        Me.menuReturn.Name = "menuReturn"
        Me.menuReturn.Size = New System.Drawing.Size(95, 20)
        Me.menuReturn.Text = "Return to Start"
        '
        'menuClear
        '
        Me.menuClear.Name = "menuClear"
        Me.menuClear.Size = New System.Drawing.Size(138, 20)
        Me.menuClear.Text = "Clear Current Changes"
        '
        'lbxRemoveName
        '
        Me.lbxRemoveName.FormattingEnabled = True
        Me.lbxRemoveName.Location = New System.Drawing.Point(12, 88)
        Me.lbxRemoveName.Name = "lbxRemoveName"
        Me.lbxRemoveName.Size = New System.Drawing.Size(100, 472)
        Me.lbxRemoveName.TabIndex = 30
        '
        'btnRemoveContact
        '
        Me.btnRemoveContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveContact.Location = New System.Drawing.Point(348, 581)
        Me.btnRemoveContact.Name = "btnRemoveContact"
        Me.btnRemoveContact.Size = New System.Drawing.Size(142, 32)
        Me.btnRemoveContact.TabIndex = 31
        Me.btnRemoveContact.Text = "Remove Contact"
        Me.btnRemoveContact.UseVisualStyleBackColor = True
        '
        'lbxRemoveAddress
        '
        Me.lbxRemoveAddress.FormattingEnabled = True
        Me.lbxRemoveAddress.Location = New System.Drawing.Point(111, 88)
        Me.lbxRemoveAddress.Name = "lbxRemoveAddress"
        Me.lbxRemoveAddress.Size = New System.Drawing.Size(300, 472)
        Me.lbxRemoveAddress.TabIndex = 32
        '
        'lbxRemoveNumber
        '
        Me.lbxRemoveNumber.FormattingEnabled = True
        Me.lbxRemoveNumber.Location = New System.Drawing.Point(410, 88)
        Me.lbxRemoveNumber.Name = "lbxRemoveNumber"
        Me.lbxRemoveNumber.Size = New System.Drawing.Size(250, 472)
        Me.lbxRemoveNumber.TabIndex = 33
        '
        'lbxRemoveFamily
        '
        Me.lbxRemoveFamily.FormattingEnabled = True
        Me.lbxRemoveFamily.Location = New System.Drawing.Point(659, 88)
        Me.lbxRemoveFamily.Name = "lbxRemoveFamily"
        Me.lbxRemoveFamily.Size = New System.Drawing.Size(150, 472)
        Me.lbxRemoveFamily.TabIndex = 34
        '
        'lblRemoveName
        '
        Me.lblRemoveName.AutoSize = True
        Me.lblRemoveName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveName.Location = New System.Drawing.Point(40, 72)
        Me.lblRemoveName.Name = "lblRemoveName"
        Me.lblRemoveName.Size = New System.Drawing.Size(39, 13)
        Me.lblRemoveName.TabIndex = 35
        Me.lblRemoveName.Text = "Name"
        '
        'lblRemoveAddress
        '
        Me.lblRemoveAddress.AutoSize = True
        Me.lblRemoveAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveAddress.Location = New System.Drawing.Point(228, 72)
        Me.lblRemoveAddress.Name = "lblRemoveAddress"
        Me.lblRemoveAddress.Size = New System.Drawing.Size(52, 13)
        Me.lblRemoveAddress.TabIndex = 36
        Me.lblRemoveAddress.Text = "Address"
        '
        'lblRemoveNumber
        '
        Me.lblRemoveNumber.AutoSize = True
        Me.lblRemoveNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveNumber.Location = New System.Drawing.Point(463, 72)
        Me.lblRemoveNumber.Name = "lblRemoveNumber"
        Me.lblRemoveNumber.Size = New System.Drawing.Size(137, 13)
        Me.lblRemoveNumber.TabIndex = 37
        Me.lblRemoveNumber.Text = "Phone Number (h/w/c)"
        '
        'lblRemoveFamily
        '
        Me.lblRemoveFamily.AutoSize = True
        Me.lblRemoveFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemoveFamily.Location = New System.Drawing.Point(683, 72)
        Me.lblRemoveFamily.Name = "lblRemoveFamily"
        Me.lblRemoveFamily.Size = New System.Drawing.Size(103, 13)
        Me.lblRemoveFamily.TabIndex = 38
        Me.lblRemoveFamily.Text = "Family (sps/chld)"
        '
        'RemoveForm
        '
        Me.AcceptButton = Me.btnRemoveContact
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 631)
        Me.Controls.Add(Me.lblRemoveFamily)
        Me.Controls.Add(Me.lblRemoveNumber)
        Me.Controls.Add(Me.lblRemoveAddress)
        Me.Controls.Add(Me.lblRemoveName)
        Me.Controls.Add(Me.lbxRemoveFamily)
        Me.Controls.Add(Me.lbxRemoveNumber)
        Me.Controls.Add(Me.lbxRemoveAddress)
        Me.Controls.Add(Me.btnRemoveContact)
        Me.Controls.Add(Me.lbxRemoveName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RemoveForm"
        Me.Text = "RemoveForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuSave As ToolStripMenuItem
    Friend WithEvents menuLoad As ToolStripMenuItem
    Friend WithEvents menuReturn As ToolStripMenuItem
    Friend WithEvents menuClear As ToolStripMenuItem
    Friend WithEvents lbxRemoveName As ListBox
    Friend WithEvents btnRemoveContact As Button
    Friend WithEvents lbxRemoveAddress As ListBox
    Friend WithEvents lbxRemoveNumber As ListBox
    Friend WithEvents lbxRemoveFamily As ListBox
    Friend WithEvents lblRemoveName As Label
    Friend WithEvents lblRemoveAddress As Label
    Friend WithEvents lblRemoveNumber As Label
    Friend WithEvents lblRemoveFamily As Label
End Class
