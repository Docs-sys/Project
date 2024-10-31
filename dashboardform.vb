Public Class dashboardform

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Ask the user for confirmation
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' Close the current main form
            Me.Hide()

            ' Create an instance of the Login Form
            Dim AdminLoginForm As New AdminLoginForm()

            ' Show the Login Form
            AdminLoginForm.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reportForm As New ReportForm()

        reportForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim GuestListForm As New GuestList()

        GuestListForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim roomManagement As New roomManagementForm()

        roomManagement.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim monitorLogin As New monitorLogin()

        monitorLogin.Show()
    End Sub
End Class