Public Class StartForm

    Private Sub btnLoadPicker_Click(sender As Object, e As EventArgs) Handles btnLoadPicker.Click
        Dim frmPicker As New RestarauntPickerForm()
        frmPicker.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
