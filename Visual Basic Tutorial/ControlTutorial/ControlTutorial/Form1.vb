Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbFirstName.Clear()
        tbLastName.Clear()
        controlPhone.tbFirstPhone.Clear()
        controlPhone.tbSecondPhone.Clear()
        controlPhone.tbThirdPhone.Clear()
    End Sub
End Class
