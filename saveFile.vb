Public Class saveFile
    Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        ' Show the OpenFileDialog and check if the user selected a file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Clear the previous image (if any) from the PictureBox
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose() ' Dispose the previous image to free up resources
            End If

            ' Load the selected image into the PictureBox
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        SaveFileDialog1.FileName = "image.jpg"
        SaveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp"

        ' Show the SaveFileDialog and check if the user clicked Save
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Check if the file already exists and prompt for confirmation to overwrite
            If System.IO.File.Exists(SaveFileDialog1.FileName) Then
                Dim overwriteConfirm As DialogResult = MessageBox.Show("File already exists. Do you want to overwrite it?",
                                                                       "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If overwriteConfirm = DialogResult.No Then
                    Exit Sub ' Exit if the user does not want to overwrite
                End If
            End If

            ' Determine the format based on the file extension
            Dim selectedFormat As System.Drawing.Imaging.ImageFormat
            Select Case IO.Path.GetExtension(SaveFileDialog1.FileName).ToLower()
                Case ".jpg", ".jpeg"
                    selectedFormat = System.Drawing.Imaging.ImageFormat.Jpeg
                Case ".png"
                    selectedFormat = System.Drawing.Imaging.ImageFormat.Png
                Case ".bmp"
                    selectedFormat = System.Drawing.Imaging.ImageFormat.Bmp
                Case Else
                    MessageBox.Show("Unsupported file format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select

            ' Save the image with the chosen format
            PictureBox1.Image.Save(SaveFileDialog1.FileName, selectedFormat)
            MessageBox.Show("Image saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class