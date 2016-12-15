Public Class ChosenRestarauntForm
    Dim strInfo(,) As String = {{"McDonald’s", "1234 Fake St", "Bldg 104", "123-456-7890", "09:00:00-17:00:00"},
                                {"Arby’s", "1234 Fake St", "Bldg 104", "123-456-7890", "09:00:00-17:00:00"},
                                {"Applebee’s", "1234 Fake St", "Bldg 104", "123-456-7890", "09:00:00-17:00:00"},
                                {"Texas Roadhouse", "1234 Fake St", "Bldg 104", "123-456-7890", "09:00:00-17:00:00"},
                                {"White Castle", "1234 Fake St", "Bldg 104", "123-456-7890", "09:00:00-17:00:00"}}
    Dim chosen As String
    Dim index As Integer
    Dim isFormCreated As Boolean
    Dim frmPicker As RestarauntPickerForm

    'constructor
    Public Sub New(picked As String, chosenIndex As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        Me.chosen = picked
        Me.index = chosenIndex
    End Sub

    'refresh open form with new data
    Public Sub Refreshed(picked As String, chosenIndex As Integer)
        ' This call is required by the designer.
        'InitializeComponent()

        Me.chosen = picked
        Me.index = chosenIndex

        'clear any previous data displayed
        lblAddress1Display.Text = Nothing
        lblAddress2Display.Text = Nothing
        lblPhoneNumberDisplay.Text = Nothing
        lblHoursDisplay.Text = Nothing
        lblChosenRestarauntDisplay.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If Application.OpenForms().OfType(Of ChosenRestarauntForm).Any Then
            closeOpenForms()
        End If

        Me.Close()
        End
    End Sub

    Private Sub closeOpenForms()
        Try
            For Each f As Form In My.Application.OpenForms
                ' Use a thread-safe method to get all form titles.
                f.Close()
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ChosenRestarauntForm_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        If index <= 4 Then
            lblAddress1Display.Text = strInfo(index, 1)
            lblAddress2Display.Text = strInfo(index, 2)
            lblPhoneNumberDisplay.Text = strInfo(index, 3)
            lblHoursDisplay.Text = strInfo(index, 4)
            lblChosenRestarauntDisplay.Text = chosen
        Else
            lblAddress1Display.Text = “Data N/A”
            lblAddress2Display.Text = “Data N/A”
            lblPhoneNumberDisplay.Text = “Data N/A”
            lblHoursDisplay.Text = “Data N/A”
            lblChosenRestarauntDisplay.Text = chosen
        End If
    End Sub

    Private Sub btnRestarauntPicker_Click(sender As Object, e As EventArgs) Handles btnRestarauntPicker.Click
        Try
            isFormCreated = Application.OpenForms().OfType(Of RestarauntPickerForm).First.Created
        Catch ex As Exception
            isFormCreated = False
        End Try

        'if chosen restaraunt form is open show it, otherwise create it
        If isFormCreated = True Then
            frmPicker = Application.OpenForms().OfType(Of RestarauntPickerForm).First
        Else
            frmPicker = New RestarauntPickerForm()
        End If

        Me.Hide()
        frmPicker.Show()
        frmPicker.BringToFront()
        frmPicker.Activate()
    End Sub
End Class