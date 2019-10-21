Public Class Designer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ShowMessageButton_Click(sender As Object, e As EventArgs) Handles ShowMessageButton.Click
        MessageLabel.Text = MessageTextBox.Text
        MessageBox.Show("Button Clicked")
    End Sub
End Class
