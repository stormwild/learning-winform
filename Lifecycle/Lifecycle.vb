Public Class Lifecycle
    Private Sub Lifecycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fruits = New List(Of String)({"Orange", "Apple", "Grapes", "Bananas", "Peaches", "Pear", "Mango"})

        'Add items inidividually
        'FruitsListBox.Items.Add("Pear")
        'FruitsListBox.Items.Add("Peaches")
        'FruitsListBox.Items.Add("Mango")

        'Add an array of items using
        'FruitsListBox.Items.AddRange(fruits.ToArray())

        'Assign the list to the DataSource property
        FruitsListBox.DataSource = fruits
    End Sub

    Private Sub ShowSelectedButton_Click(sender As Object, e As EventArgs) Handles ShowSelectedButton.Click
        If FruitsListBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select a fruit")
            Exit Sub
        End If
        SelectedFruitLabel.Text = FruitsListBox.SelectedItem
    End Sub

    Private Sub Lifecycle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to close?", Me.Text, MessageBoxButtons.YesNo).Equals(DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class
