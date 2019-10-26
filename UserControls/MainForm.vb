Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p = New Person With {
           .FirstName = "Jane",
           .LastName = "Doe",
           .Age = 49
       }
        PersonControl1.Person = p
    End Sub

    Private Sub ShowLastNameButton_Click(sender As Object, e As EventArgs) Handles ShowLastNameButton.Click
        MessageBox.Show(PersonControl1.Person.LastName)
    End Sub
End Class
