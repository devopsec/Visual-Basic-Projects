<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbxNameFirst = New System.Windows.Forms.TextBox()
        Me.tbxNameLast = New System.Windows.Forms.TextBox()
        Me.tbxAddressApt = New System.Windows.Forms.TextBox()
        Me.lblNameFirst = New System.Windows.Forms.Label()
        Me.lblNameLast = New System.Windows.Forms.Label()
        Me.tbxAddressStreet = New System.Windows.Forms.TextBox()
        Me.lblAddressApt = New System.Windows.Forms.Label()
        Me.lblAddressStreet = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAddressState = New System.Windows.Forms.Label()
        Me.lblAddressCity = New System.Windows.Forms.Label()
        Me.tbxAddressState = New System.Windows.Forms.TextBox()
        Me.tbxAddressCity = New System.Windows.Forms.TextBox()
        Me.lblAddressZip = New System.Windows.Forms.Label()
        Me.lblAddressCountry = New System.Windows.Forms.Label()
        Me.tbxAddressZip = New System.Windows.Forms.TextBox()
        Me.tbxAddressCountry = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblPhoneNumberCell = New System.Windows.Forms.Label()
        Me.lblPhoneNumberHome = New System.Windows.Forms.Label()
        Me.tbxPhoneNumberCell = New System.Windows.Forms.TextBox()
        Me.tbxPhoneNumberHome = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumberWork = New System.Windows.Forms.Label()
        Me.tbxPhoneNumberWork = New System.Windows.Forms.TextBox()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblFamilyChildren = New System.Windows.Forms.Label()
        Me.tbxFamilyChildren = New System.Windows.Forms.TextBox()
        Me.lblFamilySpouse = New System.Windows.Forms.Label()
        Me.tbxFamilySpouse = New System.Windows.Forms.TextBox()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.tipFamilyChildren = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxNameFirst
        '
        Me.tbxNameFirst.Location = New System.Drawing.Point(123, 107)
        Me.tbxNameFirst.Name = "tbxNameFirst"
        Me.tbxNameFirst.Size = New System.Drawing.Size(100, 20)
        Me.tbxNameFirst.TabIndex = 0
        '
        'tbxNameLast
        '
        Me.tbxNameLast.Location = New System.Drawing.Point(337, 107)
        Me.tbxNameLast.Name = "tbxNameLast"
        Me.tbxNameLast.Size = New System.Drawing.Size(100, 20)
        Me.tbxNameLast.TabIndex = 1
        '
        'tbxAddressApt
        '
        Me.tbxAddressApt.Location = New System.Drawing.Point(123, 214)
        Me.tbxAddressApt.Name = "tbxAddressApt"
        Me.tbxAddressApt.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressApt.TabIndex = 2
        '
        'lblNameFirst
        '
        Me.lblNameFirst.AutoSize = True
        Me.lblNameFirst.Location = New System.Drawing.Point(33, 110)
        Me.lblNameFirst.Name = "lblNameFirst"
        Me.lblNameFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblNameFirst.TabIndex = 3
        Me.lblNameFirst.Text = "First Name"
        '
        'lblNameLast
        '
        Me.lblNameLast.AutoSize = True
        Me.lblNameLast.Location = New System.Drawing.Point(254, 110)
        Me.lblNameLast.Name = "lblNameLast"
        Me.lblNameLast.Size = New System.Drawing.Size(58, 13)
        Me.lblNameLast.TabIndex = 4
        Me.lblNameLast.Text = "Last Name"
        '
        'tbxAddressStreet
        '
        Me.tbxAddressStreet.Location = New System.Drawing.Point(337, 214)
        Me.tbxAddressStreet.Name = "tbxAddressStreet"
        Me.tbxAddressStreet.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressStreet.TabIndex = 3
        '
        'lblAddressApt
        '
        Me.lblAddressApt.AutoSize = True
        Me.lblAddressApt.Location = New System.Drawing.Point(42, 217)
        Me.lblAddressApt.Name = "lblAddressApt"
        Me.lblAddressApt.Size = New System.Drawing.Size(33, 13)
        Me.lblAddressApt.TabIndex = 6
        Me.lblAddressApt.Text = "Apt #"
        '
        'lblAddressStreet
        '
        Me.lblAddressStreet.AutoSize = True
        Me.lblAddressStreet.Location = New System.Drawing.Point(264, 217)
        Me.lblAddressStreet.Name = "lblAddressStreet"
        Me.lblAddressStreet.Size = New System.Drawing.Size(35, 13)
        Me.lblAddressStreet.TabIndex = 7
        Me.lblAddressStreet.Text = "Street"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(220, 51)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(211, 160)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(75, 20)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'lblAddressState
        '
        Me.lblAddressState.AutoSize = True
        Me.lblAddressState.Location = New System.Drawing.Point(265, 261)
        Me.lblAddressState.Name = "lblAddressState"
        Me.lblAddressState.Size = New System.Drawing.Size(32, 13)
        Me.lblAddressState.TabIndex = 13
        Me.lblAddressState.Text = "State"
        '
        'lblAddressCity
        '
        Me.lblAddressCity.AutoSize = True
        Me.lblAddressCity.Location = New System.Drawing.Point(47, 261)
        Me.lblAddressCity.Name = "lblAddressCity"
        Me.lblAddressCity.Size = New System.Drawing.Size(24, 13)
        Me.lblAddressCity.TabIndex = 12
        Me.lblAddressCity.Text = "City"
        '
        'tbxAddressState
        '
        Me.tbxAddressState.Location = New System.Drawing.Point(338, 258)
        Me.tbxAddressState.Name = "tbxAddressState"
        Me.tbxAddressState.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressState.TabIndex = 5
        '
        'tbxAddressCity
        '
        Me.tbxAddressCity.Location = New System.Drawing.Point(124, 258)
        Me.tbxAddressCity.Name = "tbxAddressCity"
        Me.tbxAddressCity.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressCity.TabIndex = 4
        '
        'lblAddressZip
        '
        Me.lblAddressZip.AutoSize = True
        Me.lblAddressZip.Location = New System.Drawing.Point(257, 303)
        Me.lblAddressZip.Name = "lblAddressZip"
        Me.lblAddressZip.Size = New System.Drawing.Size(50, 13)
        Me.lblAddressZip.TabIndex = 17
        Me.lblAddressZip.Text = "Zip Code"
        '
        'lblAddressCountry
        '
        Me.lblAddressCountry.AutoSize = True
        Me.lblAddressCountry.Location = New System.Drawing.Point(39, 303)
        Me.lblAddressCountry.Name = "lblAddressCountry"
        Me.lblAddressCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblAddressCountry.TabIndex = 16
        Me.lblAddressCountry.Text = "Country"
        '
        'tbxAddressZip
        '
        Me.tbxAddressZip.Location = New System.Drawing.Point(338, 300)
        Me.tbxAddressZip.Name = "tbxAddressZip"
        Me.tbxAddressZip.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressZip.TabIndex = 7
        '
        'tbxAddressCountry
        '
        Me.tbxAddressCountry.Location = New System.Drawing.Point(124, 300)
        Me.tbxAddressCountry.Name = "tbxAddressCountry"
        Me.tbxAddressCountry.Size = New System.Drawing.Size(100, 20)
        Me.tbxAddressCountry.TabIndex = 6
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(188, 353)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(127, 20)
        Me.lblPhoneNumber.TabIndex = 18
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblPhoneNumberCell
        '
        Me.lblPhoneNumberCell.AutoSize = True
        Me.lblPhoneNumberCell.Location = New System.Drawing.Point(179, 398)
        Me.lblPhoneNumberCell.Name = "lblPhoneNumberCell"
        Me.lblPhoneNumberCell.Size = New System.Drawing.Size(24, 13)
        Me.lblPhoneNumberCell.TabIndex = 22
        Me.lblPhoneNumberCell.Text = "Cell"
        '
        'lblPhoneNumberHome
        '
        Me.lblPhoneNumberHome.AutoSize = True
        Me.lblPhoneNumberHome.Location = New System.Drawing.Point(14, 398)
        Me.lblPhoneNumberHome.Name = "lblPhoneNumberHome"
        Me.lblPhoneNumberHome.Size = New System.Drawing.Size(35, 13)
        Me.lblPhoneNumberHome.TabIndex = 21
        Me.lblPhoneNumberHome.Text = "Home"
        '
        'tbxPhoneNumberCell
        '
        Me.tbxPhoneNumberCell.Location = New System.Drawing.Point(220, 395)
        Me.tbxPhoneNumberCell.Name = "tbxPhoneNumberCell"
        Me.tbxPhoneNumberCell.Size = New System.Drawing.Size(100, 20)
        Me.tbxPhoneNumberCell.TabIndex = 9
        '
        'tbxPhoneNumberHome
        '
        Me.tbxPhoneNumberHome.Location = New System.Drawing.Point(60, 395)
        Me.tbxPhoneNumberHome.Name = "tbxPhoneNumberHome"
        Me.tbxPhoneNumberHome.Size = New System.Drawing.Size(100, 20)
        Me.tbxPhoneNumberHome.TabIndex = 8
        '
        'lblPhoneNumberWork
        '
        Me.lblPhoneNumberWork.AutoSize = True
        Me.lblPhoneNumberWork.Location = New System.Drawing.Point(343, 398)
        Me.lblPhoneNumberWork.Name = "lblPhoneNumberWork"
        Me.lblPhoneNumberWork.Size = New System.Drawing.Size(33, 13)
        Me.lblPhoneNumberWork.TabIndex = 24
        Me.lblPhoneNumberWork.Text = "Work"
        '
        'tbxPhoneNumberWork
        '
        Me.tbxPhoneNumberWork.Location = New System.Drawing.Point(391, 395)
        Me.tbxPhoneNumberWork.Name = "tbxPhoneNumberWork"
        Me.tbxPhoneNumberWork.Size = New System.Drawing.Size(100, 20)
        Me.tbxPhoneNumberWork.TabIndex = 10
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.Location = New System.Drawing.Point(218, 454)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(65, 20)
        Me.lblFamily.TabIndex = 25
        Me.lblFamily.Text = "Family "
        '
        'lblFamilyChildren
        '
        Me.lblFamilyChildren.AutoSize = True
        Me.lblFamilyChildren.Location = New System.Drawing.Point(150, 542)
        Me.lblFamilyChildren.Name = "lblFamilyChildren"
        Me.lblFamilyChildren.Size = New System.Drawing.Size(45, 13)
        Me.lblFamilyChildren.TabIndex = 15
        Me.lblFamilyChildren.Text = "Cihldren"
        '
        'tbxFamilyChildren
        '
        Me.tbxFamilyChildren.Location = New System.Drawing.Point(246, 539)
        Me.tbxFamilyChildren.Name = "tbxFamilyChildren"
        Me.tbxFamilyChildren.Size = New System.Drawing.Size(100, 20)
        Me.tbxFamilyChildren.TabIndex = 12
        '
        'lblFamilySpouse
        '
        Me.lblFamilySpouse.AutoSize = True
        Me.lblFamilySpouse.Location = New System.Drawing.Point(151, 500)
        Me.lblFamilySpouse.Name = "lblFamilySpouse"
        Me.lblFamilySpouse.Size = New System.Drawing.Size(43, 13)
        Me.lblFamilySpouse.TabIndex = 27
        Me.lblFamilySpouse.Text = "Spouse"
        '
        'tbxFamilySpouse
        '
        Me.tbxFamilySpouse.Location = New System.Drawing.Point(246, 497)
        Me.tbxFamilySpouse.Name = "tbxFamilySpouse"
        Me.tbxFamilySpouse.Size = New System.Drawing.Size(100, 20)
        Me.tbxFamilySpouse.TabIndex = 11
        '
        'btnAddContact
        '
        Me.btnAddContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddContact.Location = New System.Drawing.Point(189, 602)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(123, 32)
        Me.btnAddContact.TabIndex = 13
        Me.btnAddContact.Text = "Add Contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSave, Me.menuLoad, Me.menuReturn, Me.menuClear})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 28
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
        'AddForm
        '
        Me.AcceptButton = Me.btnAddContact
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StoringContacts.My.Resources.Resources.people2_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(515, 666)
        Me.Controls.Add(Me.btnAddContact)
        Me.Controls.Add(Me.lblFamilyChildren)
        Me.Controls.Add(Me.tbxFamilyChildren)
        Me.Controls.Add(Me.lblFamilySpouse)
        Me.Controls.Add(Me.tbxFamilySpouse)
        Me.Controls.Add(Me.lblFamily)
        Me.Controls.Add(Me.lblPhoneNumberWork)
        Me.Controls.Add(Me.tbxPhoneNumberWork)
        Me.Controls.Add(Me.lblPhoneNumberCell)
        Me.Controls.Add(Me.lblPhoneNumberHome)
        Me.Controls.Add(Me.tbxPhoneNumberCell)
        Me.Controls.Add(Me.tbxPhoneNumberHome)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.lblAddressZip)
        Me.Controls.Add(Me.lblAddressCountry)
        Me.Controls.Add(Me.tbxAddressZip)
        Me.Controls.Add(Me.tbxAddressCountry)
        Me.Controls.Add(Me.lblAddressState)
        Me.Controls.Add(Me.lblAddressCity)
        Me.Controls.Add(Me.tbxAddressState)
        Me.Controls.Add(Me.tbxAddressCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAddressStreet)
        Me.Controls.Add(Me.lblAddressApt)
        Me.Controls.Add(Me.tbxAddressStreet)
        Me.Controls.Add(Me.lblNameLast)
        Me.Controls.Add(Me.lblNameFirst)
        Me.Controls.Add(Me.tbxAddressApt)
        Me.Controls.Add(Me.tbxNameLast)
        Me.Controls.Add(Me.tbxNameFirst)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxNameFirst As TextBox
    Friend WithEvents tbxNameLast As TextBox
    Friend WithEvents tbxAddressApt As TextBox
    Friend WithEvents lblNameFirst As Label
    Friend WithEvents lblNameLast As Label
    Friend WithEvents tbxAddressStreet As TextBox
    Friend WithEvents lblAddressApt As Label
    Friend WithEvents lblAddressStreet As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAddressState As Label
    Friend WithEvents lblAddressCity As Label
    Friend WithEvents tbxAddressState As TextBox
    Friend WithEvents tbxAddressCity As TextBox
    Friend WithEvents lblAddressZip As Label
    Friend WithEvents lblAddressCountry As Label
    Friend WithEvents tbxAddressZip As TextBox
    Friend WithEvents tbxAddressCountry As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblPhoneNumberCell As Label
    Friend WithEvents lblPhoneNumberHome As Label
    Friend WithEvents tbxPhoneNumberCell As TextBox
    Friend WithEvents tbxPhoneNumberHome As TextBox
    Friend WithEvents lblPhoneNumberWork As Label
    Friend WithEvents tbxPhoneNumberWork As TextBox
    Friend WithEvents lblFamily As Label
    Friend WithEvents lblFamilyChildren As Label
    Friend WithEvents tbxFamilyChildren As TextBox
    Friend WithEvents lblFamilySpouse As Label
    Friend WithEvents tbxFamilySpouse As TextBox
    Friend WithEvents btnAddContact As Button
    Friend WithEvents tipFamilyChildren As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuSave As ToolStripMenuItem
    Friend WithEvents menuLoad As ToolStripMenuItem
    Friend WithEvents menuReturn As ToolStripMenuItem
    Friend WithEvents menuClear As ToolStripMenuItem
End Class
