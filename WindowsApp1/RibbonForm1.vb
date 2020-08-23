Public Class RibbonForm1
    Private Sub RibbonForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim obj = New ObjectSource
        BindingSource1.DataSource = obj.GetCategories()
    End Sub
End Class