Public Class DataForm
    Private ReadOnly _source As New ObjectSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoriesComboBox.ValueMember = "Id"
        CategoriesComboBox.DisplayMember = "Name"
        CategoriesComboBox.DataSource = _source.GetCategories()

        Dim catId = If(CategoriesComboBox.SelectedValue, _source.GetCategories().FirstOrDefault().Id)
        Dim products = _source.GetProducts(catId)
        ProductsDataGridView.DataSource = products
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

        ProductsDataGridView.DataSource = _source.GetProducts(catId)
    End Sub
End Class
