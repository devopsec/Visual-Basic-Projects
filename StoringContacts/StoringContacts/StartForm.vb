Public Class StartForm
    'ctor
    Public Sub New()
        InitializeComponent()
        'ensure isModified = False on startup
        ContactList.isModified = False
    End Sub

    'addform
    Private Sub btnAddContacts_Click(sender As Object, e As EventArgs) Handles btnAddContacts.Click
        Dim frmAdd As New AddForm
        Me.Hide()
        frmAdd.ShowDialog()
        Me.Close()
    End Sub

    'removeform
    Private Sub btnRemoveContacts_Click(sender As Object, e As EventArgs) Handles btnRemoveContacts.Click
        Dim frmRemove As New RetrieveForm
        Me.Hide()
        frmRemove.ShowDialog()
        Me.Close()
    End Sub

    'retrieveform
    Private Sub btnRetrieveContacts_Click(sender As Object, e As EventArgs) Handles btnRetrieveContacts.Click
        Dim frmRetrieve As New RetrieveForm
        Me.Hide()
        frmRetrieve.ShowDialog()
        Me.Close()
    End Sub

End Class
