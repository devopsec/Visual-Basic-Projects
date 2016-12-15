<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.lblStart = New System.Windows.Forms.Label()
        Me.btnAddContacts = New System.Windows.Forms.Button()
        Me.btnRemoveContacts = New System.Windows.Forms.Button()
        Me.btnRetrieveContacts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(151, 62)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(246, 20)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Welcome to the Contact List App!"
        '
        'btnAddContacts
        '
        Me.btnAddContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddContacts.Location = New System.Drawing.Point(209, 166)
        Me.btnAddContacts.Name = "btnAddContacts"
        Me.btnAddContacts.Size = New System.Drawing.Size(120, 50)
        Me.btnAddContacts.TabIndex = 1
        Me.btnAddContacts.Text = "Add Contacts"
        Me.btnAddContacts.UseVisualStyleBackColor = True
        '
        'btnRemoveContacts
        '
        Me.btnRemoveContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveContacts.Location = New System.Drawing.Point(209, 245)
        Me.btnRemoveContacts.Name = "btnRemoveContacts"
        Me.btnRemoveContacts.Size = New System.Drawing.Size(120, 50)
        Me.btnRemoveContacts.TabIndex = 2
        Me.btnRemoveContacts.Text = "Remove Contacts"
        Me.btnRemoveContacts.UseVisualStyleBackColor = True
        '
        'btnRetrieveContacts
        '
        Me.btnRetrieveContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrieveContacts.Location = New System.Drawing.Point(209, 321)
        Me.btnRetrieveContacts.Name = "btnRetrieveContacts"
        Me.btnRetrieveContacts.Size = New System.Drawing.Size(120, 50)
        Me.btnRetrieveContacts.TabIndex = 3
        Me.btnRetrieveContacts.Text = "Retrieve Contact"
        Me.btnRetrieveContacts.UseVisualStyleBackColor = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StoringContacts.My.Resources.Resources.people_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(545, 450)
        Me.Controls.Add(Me.btnRetrieveContacts)
        Me.Controls.Add(Me.btnRemoveContacts)
        Me.Controls.Add(Me.btnAddContacts)
        Me.Controls.Add(Me.lblStart)
        Me.Name = "StartForm"
        Me.Text = "Contact List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStart As Label
    Friend WithEvents btnAddContacts As Button
    Friend WithEvents btnRemoveContacts As Button
    Friend WithEvents btnRetrieveContacts As Button
End Class
