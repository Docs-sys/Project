Public Class AdminLoginForm

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ' Hardcoded credentials
        Dim adminUsername As String = "admin"
        Dim adminPassword As String = "password123"

        ' Check if entered credentials match the hardcoded credentials
        If TxtUsername.Text = adminUsername AndAlso txtPassword.Text = adminPassword Then
            ' Create an instance of MainForm
            Dim mainform As New mainform()
            Me.Hide()
            mainform.Show()   ' Display the Main Form
        Else
            ' Display error message if credentials are incorrect
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Optionally, clear the entered password for security
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub


    Private Sub btnOpenManager_Click(sender As Object, e As EventArgs) Handles btnOpenManager.Click
        ' Create an instance of the Manager Login Form
        Dim managerForm As New ManagerLoginForm()
        managerForm.Show()   ' Display the Manager Login Form
        Me.Hide()            ' Hide the Admin Login Form (optional)
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class