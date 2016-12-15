''ctor
'Public Sub New()
'        ' Handle the ApplicationExit event to know when the application is exiting.
'        AddHandler Application.ApplicationExit, AddressOf OnApplicationExit
'    End Sub

'Private Sub OnApplicationExit(ByVal sender As Object, ByVal e As EventArgs)
'    If ContactList.isModified = True Then
'        If MessageBox.Show("The current document is not saved. " &
'       "Do you wish to discard your changes?", "Confirm",
'       MessageBoxButtons.YesNo) = DialogResult.Yes Then
'            e.Cancel = False
'        Else
'            e.Cancel = True
'        End If
'    End If
'End Sub