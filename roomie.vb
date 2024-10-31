Public Class RoomForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Create an instance of the Single Room Form
        Dim singleroom As New singleroom()

        ' Show the Single Room Form
        singleroom.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim doubleroom As New doubleroom()

        doubleroom.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim suite As New suite()

        suite.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim deluxe As New deluxe()

        deluxe.Show()
    End Sub

    Private Sub png1_Click(sender As Object, e As EventArgs) Handles png1.Click
        Dim toolTip As New ToolTip()

        toolTip.AutoPopDelay = 2000
        toolTip.InitialDelay = 100
        toolTip.ReshowDelay = 50

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png1, " Bed ")
    End Sub

    Private Sub png2_Click(sender As Object, e As EventArgs) Handles png2.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png2, " Smart TV ")
    End Sub

    Private Sub png3_Click(sender As Object, e As EventArgs) Handles png3.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png3, " WiFi ")
    End Sub

    Private Sub png4_Click(sender As Object, e As EventArgs) Handles png4.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png4, " Wardrobe ")
    End Sub

    Private Sub png5_Click(sender As Object, e As EventArgs) Handles png5.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png5, " WiFi ")
    End Sub

    Private Sub png6_Click(sender As Object, e As EventArgs) Handles png6.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png6, " Bathtub ")
    End Sub

    Private Sub png7_Click(sender As Object, e As EventArgs) Handles png7.Click, PictureBox7.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png7, " Smart TV ")
    End Sub

    Private Sub png8_Click(sender As Object, e As EventArgs) Handles png8.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png8, " Bed ")
    End Sub

    Private Sub png9_Click(sender As Object, e As EventArgs) Handles png9.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png9, " Smart TV ")
    End Sub

    Private Sub png10_Click(sender As Object, e As EventArgs) Handles png10.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png10, " Gaming Consoles ")
    End Sub

    Private Sub png11_Click(sender As Object, e As EventArgs) Handles png11.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png11, " Mini Bar ")
    End Sub

    Private Sub png12_Click(sender As Object, e As EventArgs) Handles png12.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png12, " Working Space ")
    End Sub

    Private Sub png13_Click(sender As Object, e As EventArgs) Handles png13.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png13, " Smart Home ")
    End Sub

    Private Sub png14_Click(sender As Object, e As EventArgs) Handles png14.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png14, " Mini Bar ")
    End Sub

    Private Sub png15_Click(sender As Object, e As EventArgs) Handles png15.Click
        Dim toolTip As New ToolTip()


        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png15, " Working Space ")
    End Sub

    Private Sub png16_Click(sender As Object, e As EventArgs) Handles png16.Click
        Dim toolTip As New ToolTip()

        ' Set up the tooltip for the PictureBox
        toolTip.SetToolTip(png16, " Bathtub ")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' Hide the current form
        Me.Hide()

        ' Create instances of the forms
        Dim Form2 As New Form2()
        Dim roomie As New RoomForm()

        ' Show Form2
        Form2.Show()

        ' Handle the FormClosed event of Form2 to show the roomie form
        AddHandler Form2.FormClosed, Sub(s, args)
                                         roomie.Show()
                                     End Sub
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()

        ' Create instances of the forms
        Dim Form2 As New Form2()
        Dim roomie As New RoomForm()

        ' Show Form2
        Form2.Show()

        ' Handle the FormClosed event of Form2 to show the roomie form
        AddHandler Form2.FormClosed, Sub(s, args)
                                         roomie.Show()
                                     End Sub
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()

        ' Create instances of the forms
        Dim Form2 As New Form2()
        Dim roomie As New RoomForm()

        ' Show Form2
        Form2.Show()

        ' Handle the FormClosed event of Form2 to show the roomie form
        AddHandler Form2.FormClosed, Sub(s, args)
                                         roomie.Show()
                                     End Sub
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()

        ' Create instances of the forms
        Dim Form2 As New Form2()
        Dim roomie As New RoomForm()

        ' Show Form2
        Form2.Show()

        ' Handle the FormClosed event of Form2 to show the roomie form
        AddHandler Form2.FormClosed, Sub(s, args)
                                         roomie.Show()
                                     End Sub
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim mainform As New mainform()

        mainform.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim checkAvailability As New checkAvailability()

        checkAvailability.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim checkAvailability As New checkAvailability()

        checkAvailability.Show()
    End Sub
End Class