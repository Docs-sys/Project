Public Class roomManagementForm
    Private Sub roomManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBoxes
        ComboBox2.Items.Add("Single")
        ComboBox2.Items.Add("Double")
        ComboBox2.Items.Add("Suite")
        ComboBox2.Items.Add("Deluxe")

        ComboBox1.Items.Add("Available")
        ComboBox1.Items.Add("Unavailable")
        ComboBox1.Items.Add("On Maintenance")

        ' Initialize DataGridView
        DataGridView1.Columns.Add("RoomNumber", "Room Number")
        DataGridView1.Columns.Add("RoomRate", "Room Rate")
        DataGridView1.Columns.Add("RoomStatus", "Room Status")
        DataGridView1.Columns.Add("RoomType", "Room Type")
        DataGridView1.Columns.Add("Adult", "Adult")
        DataGridView1.Columns.Add("Children", "Children")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get values from inputs
        Dim roomNumber As String = TextBox1.Text
        Dim roomRate As String = TextBox2.Text
        Dim roomStatus As String = ComboBox1.SelectedItem?.ToString()
        Dim roomType As String = ComboBox2.SelectedItem?.ToString()
        Dim adult As String = ComboBox3.SelectedItem?.ToString()
        Dim children As String = ComboBox4.SelectedItem?.ToString()

        ' Validate inputs
        If String.IsNullOrEmpty(roomNumber) OrElse String.IsNullOrEmpty(roomRate) OrElse
           String.IsNullOrEmpty(roomStatus) OrElse String.IsNullOrEmpty(roomType) OrElse
           String.IsNullOrEmpty(adult) OrElse String.IsNullOrEmpty(children) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Add the information to the DataGridView
        DataGridView1.Rows.Add(roomNumber, roomRate, roomStatus, roomType, adult, children)

        ' Clear inputs
        ClearInputs()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = If(selectedRow.Cells("RoomNumber").Value?.ToString(), "")
            TextBox2.Text = If(selectedRow.Cells("RoomRate").Value?.ToString(), "")
            ComboBox1.SelectedItem = If(selectedRow.Cells("RoomStatus").Value, Nothing)
            ComboBox2.SelectedItem = If(selectedRow.Cells("RoomType").Value, Nothing)
            ComboBox3.SelectedItem = If(selectedRow.Cells("Adult").Value, Nothing)
            ComboBox4.SelectedItem = If(selectedRow.Cells("Children").Value, Nothing)
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim selectedIndex As Integer = DataGridView1.CurrentRow.Index

            ' Update the selected row with the modified values
            DataGridView1.Rows(selectedIndex).Cells("RoomNumber").Value = TextBox1.Text
            DataGridView1.Rows(selectedIndex).Cells("RoomRate").Value = TextBox2.Text
            DataGridView1.Rows(selectedIndex).Cells("RoomStatus").Value = ComboBox1.SelectedItem?.ToString()
            DataGridView1.Rows(selectedIndex).Cells("RoomType").Value = ComboBox2.SelectedItem?.ToString()
            DataGridView1.Rows(selectedIndex).Cells("Adult").Value = ComboBox3.SelectedItem?.ToString()
            DataGridView1.Rows(selectedIndex).Cells("Children").Value = ComboBox4.SelectedItem?.ToString()

            ' Clear inputs
            ClearInputs()
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                ClearInputs() ' Optional: Clear the input fields after deletion
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub ClearInputs()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class


