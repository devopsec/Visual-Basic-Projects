Imports System.IO
Imports StoringContacts.refMod

Public Class RetrieveForm
    Private list As ContactList
    Private person As Contact
    Dim i As Integer
    Dim sfdSaveFile As SaveFileDialog
    Dim ofdOpenFile As OpenFileDialog

    Private Sub btnGetContact_Click(sender As Object, e As EventArgs) Handles btnGetContact.Click
        Dim search As String = tbxRetrieve.Text.Trim

        'validate input
        If isInputInvalid(search, "name") = True Then
            MessageBox.Show("Input Validation Failed!" & vbNewLine & "Ensure Your Input Data Does NOT Contain:" & vbNewLine &
                            "1: Nothing (an empty field)" & vbNewLine & "2: Commas (,)" & vbNewLine & "3: Symbols (other than (-)(_)(.)" &
                            vbNewLine & "4: Names w/ numbers" & vbNewLine & "5: Phone Numbers w/ letters (no country code or parentheses)" &
                            vbNewLine & "6: Family Members w/ numbers" & vbNewLine & "7: Address MUST be a VALID Address")
            Exit Sub
        End If

        'get contact and display 
        Try
            person = list.getContact(LCase(search))
            With person
                For Each str As String In .arrName
                    lbxRetrieve.Items.Insert(str, 0)
                Next
                For Each str As String In .arrAddress
                    lbxRetrieve.Items.Insert(str, 1)
                Next
                For Each str As String In .arrNumber
                    lbxRetrieve.Items.Insert(str, 2)
                Next
                For Each str As String In .arrFamily
                    lbxRetrieve.Items.Insert(str, 3)
                Next
            End With
        Catch ex As Exception
            MessageBox.Show("Error : Contact Not Found!" & vbNewLine & "Check Spelling and Search by Last Name")
        End Try

        'clear textboxe
        tbxRetrieve.Clear()
    End Sub

    Private Sub RetrieveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set label tabstops to false
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                lbl.TabStop = False
            End If
        Next

        'init objects to access data
        list = New ContactList
        person = New Contact
    End Sub

    'save contacts to file
    Private Sub menuSave_Click(sender As Object, e As EventArgs) Handles menuSave.Click
        ' Does the current document have a filename?
        If ContactList.filename = String.Empty Then
            ' use Save As dialog box.
            sfdSaveFile = New SaveFileDialog()
            sfdSaveFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
            If sfdSaveFile.ShowDialog = DialogResult.OK Then
                ContactList.filename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            ' Save the document with the current filename.
            SaveDocument()
        End If
        ContactList.isModified = False
    End Sub

    'load contacts from file
    Private Sub menuLoad_Click(sender As Object, e As EventArgs) Handles menuLoad.Click
        If ContactList.isModified = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " & "Are you sure?", "Confirm",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            ' Document has not changed, so replace contactList
            ClearDocument()
            OpenDocument()
        End If
        ContactList.isModified = False
    End Sub

    'return to start menu
    Private Sub menuReturn_Click(sender As Object, e As EventArgs) Handles menuReturn.Click
        Dim frmStart As New StartForm
        Me.Hide()
        frmStart.ShowDialog()
        Me.Close()
    End Sub

    'clear currently cached data
    Private Sub menuClear_Click(sender As Object, e As EventArgs) Handles menuClear.Click
        If ContactList.isModified = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " & "Are you sure?", "Confirm",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ClearDocument()
        End If
    End Sub

    Sub ClearDocument()
        ContactList.filename = String.Empty
        ContactList.isModified = False
        ContactList.clearContactList()
    End Sub

    Sub OpenDocument()
        Dim inputFile As IO.StreamReader
        ofdOpenFile = New OpenFileDialog()
        ofdOpenFile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"

        If ofdOpenFile.ShowDialog() = DialogResult.OK Then
            ' Retrieve the selected filename.
            ContactList.filename = ofdOpenFile.FileName
        ElseIf ofdOpenFile.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(ContactList.filename) Then
            Try 'read data from file
                inputFile = File.OpenText(ContactList.filename)
                Dim line As String
                Dim lineArr As String()
                Do Until inputFile.EndOfStream
                    line = inputFile.ReadLine()
                    lineArr = line.Split(",")
                    With person
                        .arrName = {lineArr(0), lineArr(1)}
                        .arrAddress = {lineArr(2), lineArr(3),
                                       lineArr(4), lineArr(5),
                                       lineArr(6), lineArr(7)}
                        .arrNumber = {lineArr(8), lineArr(9), lineArr(10)}
                        .arrFamily = {lineArr(11), lineArr(12)}
                    End With
                    list.setContact = person
                Loop
                ContactList.isModified = False
            Catch
                MessageBox.Show("Error opening the file.")
            End Try
        Else
            MessageBox.Show("File does not exist.")
        End If
    End Sub

    Sub SaveDocument()
        Dim outputFile As IO.StreamWriter

        Try 'write data to file (append)
            If My.Computer.FileSystem.FileExists(ContactList.filename) Then
                outputFile = File.AppendText(ContactList.filename)
                For Each contact As Contact In list.getContactList()
                    For Each name As String In contact.arrName
                        outputFile.Write(name & ",")
                    Next
                    For Each address As String In contact.arrAddress
                        outputFile.Write(address & ",")
                    Next
                    For Each number As String In contact.arrNumber
                        outputFile.Write(number & ",")
                    Next
                    For i = 0 To (contact.arrFamily.Length - 1)
                        If Not i = (contact.arrFamily.Length - 1) Then
                            outputFile.Write(contact.arrFamily(i) & ",")
                        Else
                            outputFile.Write(contact.arrFamily(i) & vbNewLine)
                        End If
                    Next
                Next

            Else 'write data to file (create)
                outputFile = File.CreateText(ContactList.filename)
                For Each contact As Contact In list.getContactList()
                    For Each name As String In contact.arrName
                        outputFile.Write(name & ",")
                    Next
                    For Each address As String In contact.arrAddress
                        outputFile.Write(address & ",")
                    Next
                    For Each number As String In contact.arrNumber
                        outputFile.Write(number & ",")
                    Next
                    For i = 0 To (contact.arrFamily.Length - 1)
                        If Not i = (contact.arrFamily.Length - 1) Then
                            outputFile.Write(contact.arrFamily(i) & ",")
                        Else
                            outputFile.Write(contact.arrFamily(i) & vbNewLine)
                        End If
                    Next
                Next
            End If
            outputFile.Close()
            ContactList.isModified = False
        Catch
            MessageBox.Show("Error occurred while saving file.")
        End Try
    End Sub
End Class