Public Class ManagerLoginForm
    Private Sub btnLoginManager_Click(sender As Object, e As EventArgs) Handles btnLoginManager.Click
        ' Manager credentials (for demonstration purposes, these are hardcoded)
        Dim managerUsername As String = "manager"
        Dim managerPassword As String = "manager123"

        ' Validate the entered credentials
        If TxtManagerUser.Text = managerUsername AndAlso txtManagerPass.Text = managerPassword Then
            ' Display a success message

            ' Open the DashboardForm or the next form
            Dim dashboardForm As New dashboardform()
            dashboardForm.Show()
            Me.Hide()
        Else
            ' Display an error message for invalid credentials
            MessageBox.Show("Invalid Manager credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Optionally, clear the entered password for security
            txtManagerPass.Clear()
            txtManagerPass.Focus()
        End If
    End Sub


    Private Sub btnOpenAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click

        Dim adminform As New AdminLoginForm()
        adminform.Show()
        Me.Hide()
    End Sub
End Class