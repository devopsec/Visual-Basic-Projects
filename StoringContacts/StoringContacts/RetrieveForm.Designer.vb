<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetrieveForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbxRetrieve = New System.Windows.Forms.ListBox()
        Me.btnGetContact = New System.Windows.Forms.Button()
        Me.tbxRetrieve = New System.Windows.Forms.TextBox()
        Me.lblNameLast = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSave, Me.menuLoad, Me.menuReturn, Me.menuClear})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(563, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'ContactListBindingSource
        '
        Me.ContactListBindingSource.DataSource = GetType(StoringContacts.ContactList)
        '
        'lbxRetrieve
        '
        Me.lbxRetrieve.ColumnWidth = 20
        Me.lbxRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxRetrieve.FormattingEnabled = True
        Me.lbxRetrieve.ItemHeight = 16
        Me.lbxRetrieve.Items.AddRange(New Object() {"Name:", "Address:", "Number:", "Family:"})
        Me.lbxRetrieve.Location = New System.Drawing.Point(12, 102)
        Me.lbxRetrieve.MultiColumn = True
        Me.lbxRetrieve.Name = "lbxRetrieve"
        Me.lbxRetrieve.Size = New System.Drawing.Size(539, 68)
        Me.lbxRetrieve.TabIndex = 3
        '
        'btnGetContact
        '
        Me.btnGetContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetContact.Location = New System.Drawing.Point(210, 278)
        Me.btnGetContact.Name = "btnGetContact"
        Me.btnGetContact.Size = New System.Drawing.Size(123, 32)
        Me.btnGetContact.TabIndex = 1
        Me.btnGetContact.Text = "Get Contact"
        Me.btnGetContact.UseVisualStyleBackColor = True
        '
        'tbxRetrieve
        '
        Me.tbxRetrieve.Location = New System.Drawing.Point(210, 220)
        Me.tbxRetrieve.Name = "tbxRetrieve"
        Me.tbxRetrieve.Size = New System.Drawing.Size(123, 20)
        Me.tbxRetrieve.TabIndex = 0
        '
        'lblNameLast
        '
        Me.lblNameLast.AutoSize = True
        Me.lblNameLast.Location = New System.Drawing.Point(366, 223)
        Me.lblNameLast.Name = "lblNameLast"
        Me.lblNameLast.Size = New System.Drawing.Size(58, 13)
        Me.lblNameLast.TabIndex = 33
        Me.lblNameLast.Text = "Last Name"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(119, 223)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(59, 13)
        Me.lblSearch.TabIndex = 34
        Me.lblSearch.Text = "Search By:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(234, 72)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(74, 15)
        Me.lblContact.TabIndex = 35
        Me.lblContact.Text = "Contact Info:"
        '
        'RetrieveForm
        '
        Me.AcceptButton = Me.btnGetContact
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 336)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblNameLast)
        Me.Controls.Add(Me.tbxRetrieve)
        Me.Controls.Add(Me.btnGetContact)
        Me.Controls.Add(Me.lbxRetrieve)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RetrieveForm"
        Me.Text = "RetrieveForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ContactListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuSave As ToolStripMenuItem
    Friend WithEvents menuLoad As ToolStripMenuItem
    Friend WithEvents menuReturn As ToolStripMenuItem
    Friend WithEvents menuClear As ToolStripMenuItem
    Friend WithEvents ContactListBindingSource As BindingSource
    Friend WithEvents lbxRetrieve As ListBox
    Friend WithEvents btnGetContact As Button
    Friend WithEvents tbxRetrieve As TextBox
    Friend WithEvents lblNameLast As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblContact As Label
End Class
