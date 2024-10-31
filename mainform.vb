Public Class mainform

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim mainform As New mainform()

        ' Show the Room Form
        mainform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of the Room Form
        Dim roomie As New RoomForm()

        ' Show the Room Form
        roomie.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim checkAvailability As New checkAvailability()

        checkAvailability.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = "Seaside Boulevard corner Coral Way," & vbCrLf & "Mall of Asia Complex, Pasay City, 1300, Philippines"
        System.Diagnostics.Process.Start("https://www.google.com/maps/place/Conrad+Manila/@14.5315849,120.9774651,17z/data=!4m9!3m8!1s0x3397cbf96a5d6189:0xf1ea364d508e51d1!5m2!4m1!1i2!8m2!3d14.5315849!4d120.98004!16s%2Fg%2F11cp5_4qbg?entry=ttu&g_ep=EgoyMDI0MTAyMy4wIKXMDSoASAFQAw%3D%3D")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim GuestList As New GuestList()

        ' Show the Room Form
        GuestList.Show()
    End Sub
End Class