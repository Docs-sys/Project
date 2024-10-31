Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim payment As New Payment()

        ' Show the Room Form
        payment.Show()
    End Sub

    Private Sub btnwanttosavefile_Click(sender As Object, e As EventArgs) Handles btnwanttosavefile.Click
        Dim saveFile As New saveFile()

        saveFile.Show()
    End Sub
End Class