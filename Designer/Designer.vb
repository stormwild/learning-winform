Public Class Designer
    Private Sub ShowMessageButton_Click(sender As Object, e As EventArgs) Handles ShowMessageButton.Click
        MessageLabel.Text = MessageTextBox.Text
        MessageBox.Show("Button Clicked")
    End Sub
End Class
