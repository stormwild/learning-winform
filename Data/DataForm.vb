Public Class DataForm
    Private ReadOnly _source As New ObjectSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoriesComboBox.ValueMember = "Id"
        CategoriesComboBox.DisplayMember = "Name"
        CategoriesComboBox.DataSource = _source.GetCategories()
    End Sub

    Private Sub CategoriesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoriesComboBox.SelectedIndexChanged
        Dim catId = CategoriesComboBox.SelectedValue
        Dim products = _source.GetProducts(catId)
        ProductsListBox.DataSource = products
        ProductsListBox.DisplayMember = "Name"

        ProductNameTextBox.DataBindings.Clear()
        ProductStockTextBox.DataBindings.Clear()
        ProductPriceTextBox.DataBindings.Clear()

        ProductNameTextBox.DataBindings.Add("Text", products, "Name")
        ProductPriceTextBox.DataBindings.Add("Text", products, "UnitPrice")
        ProductStockTextBox.DataBindings.Add("Text", products, "UnitsInStock")
    End Sub
End Class
