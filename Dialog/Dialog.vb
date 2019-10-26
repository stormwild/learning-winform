Public Class Dialog
    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fruits = New List(Of String)({"Apple", "Banana", "Grapes", "Peaches", "Pear", "Mango"})
        FruitsListBox.DataSource = fruits
        FruitsListBox.ClearSelected()
    End Sub

    Private Sub ShowSelectedButton_Click(sender As Object, e As EventArgs) Handles ShowSelectedButton.Click
        If FruitsListBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a fruit from the list")
            Exit Sub
        End If
        SelectedFruitLabel.Text = FruitsListBox.SelectedItem
    End Sub

    Private Sub Dialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim confirmDialog = New ConfirmDialog()

        If confirmDialog.ShowDialog() = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
