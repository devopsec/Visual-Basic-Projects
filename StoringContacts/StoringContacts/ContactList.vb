Imports StoringContacts.refMod

'holds temp contact changes
Class ContactList
    Private Shared contacts As New Collection
    Private Shared modified As Boolean = False
    Private Shared name As String = String.Empty
    Private contact As Contact = New Contact

    'ctor
    Public Sub New(ByVal ParamArray args() As Contact)
        For Each arg As Contact In args
            contacts.Add(arg, arg.arrName(1))
        Next
    End Sub

    'no-arg ctor
    Public Sub New()
        'use to init class when no contacts yet exist
    End Sub

    'getters / setters

    Protected Friend ReadOnly Property getContact(ByVal name As String) As Contact
        Get
            If name = Nothing Then 'no name provided
                Console.WriteLine("getContact : Error name is null")
                Exit Property
            End If

            Try
                'get contact by last name
                Return CType(contacts.Item(name), Contact)
            Catch ex As Exception
                Console.WriteLine(ex.ToString)
                Console.WriteLine("Unable to find Contact in ContactList")
                Console.WriteLine(ex.StackTrace)
                Exit Property
            End Try

#Disable Warning BC42107 ' Property will never reach End Property code path
        End Get
#Enable Warning BC42107
    End Property

    Protected Friend WriteOnly Property setContact As Contact
        Set(ByVal contact As Contact)
            If contact.arrName.Length <> 2 Then 'no contact provided
                Console.WriteLine("setContact : Error contact is null")
                Exit Property
            End If

            Try
                'copy object contents into New object
                Dim copycontact As Contact = New Contact
                With copycontact
                    .arrName = {contact.arrName(0), contact.arrName(1)}
                    .arrAddress = {contact.arrAddress(0), contact.arrAddress(1),
                    contact.arrAddress(2), contact.arrAddress(3),
                    contact.arrAddress(4), contact.arrAddress(5)}
                    .arrNumber = {contact.arrNumber(0), contact.arrNumber(1), contact.arrNumber(2)}
                    .arrFamily = {contact.arrFamily(0), contact.arrFamily(1)}
                End With

                'convert name to lowercase
                Dim lowCaseName As String = LCase(copycontact.arrName(1))

                'add contact
                contacts.Add(copycontact, lowCaseName)

            Catch ex As Exception
                Console.WriteLine(ex.ToString)
                Console.WriteLine("Unable to ADD Contact to ContactList")
                Console.WriteLine(ex.StackTrace)
                Exit Property
            End Try
        End Set
    End Property

    Protected Friend Shared Sub clearContactList()
        contacts = Nothing
    End Sub

    Protected Friend Function getContactList() As Collection
        Return contacts
    End Function

    Protected Friend Shared Property isModified As Boolean
        Get
            Return modified
        End Get
        Set(value As Boolean)
            modified = value
        End Set
    End Property

    Protected Friend Shared Property filename As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

End Class

