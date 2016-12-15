Imports System.Windows.Forms

Public Class RestarauntPickerForm
    Dim strRestaraunts() As String
    Dim chosenRestaraunt As String
    Private frmChosen As ChosenRestarauntForm
    Private isFormCreated As Boolean

    Private Sub RestarauntPickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim strRestaraunts(4)
        strRestaraunts = {"McDonald's", "Arby’s", "Applebee’s", "Texas Roadhouse", "White Castle"}

    End Sub

    Private Sub tbxAddRestaraunt_TextChanged(sender As Object, e As EventArgs) Handles tbxAddRestaraunt.MouseClick
        'clear text when user clicks in text box
        tbxAddRestaraunt.Clear()
    End Sub

    Private Sub btnAddRestaraunt_Click(sender As Object, e As EventArgs) Handles btnAddRestaraunt.Click
        If tbxAddRestaraunt.Text IsNot Nothing Then
            'change dimension and add restaraunt
            ReDim Preserve strRestaraunts(strRestaraunts.Length)
            strRestaraunts(UBound(strRestaraunts)) = tbxAddRestaraunt.Text
            lbxRestaraunts.Items.Add(tbxAddRestaraunt.Text)
            tbxAddRestaraunt.Clear()
        End If
    End Sub

    Private Sub btnRandomRestaraunt_Click(sender As Object, e As EventArgs) Handles btnRandomRestaraunt.Click
        Dim randomNum As Integer = CInt(Math.Floor((strRestaraunts.Length + 1) * Rnd()))
        chosenRestaraunt = strRestaraunts(randomNum)

        Try
            isFormCreated = Application.OpenForms().OfType(Of ChosenRestarauntForm).First.Created
        Catch ex As Exception
            isFormCreated = False
        End Try

        'if chosen restaraunt form is open show it, otherwise create it
        If isFormCreated = True Then
            'frmChosen = Application.OpenForms().OfType(Of ChosenRestarauntForm).First
            frmChosen.Refreshed(chosenRestaraunt, randomNum)
            frmChosen.Activate()
        Else
            frmChosen = New ChosenRestarauntForm(chosenRestaraunt, randomNum)
        End If

        Me.Hide()
        frmChosen.Show()
        frmChosen.BringToFront()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If Application.OpenForms().OfType(Of RestarauntPickerForm).Any Then
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

End Class