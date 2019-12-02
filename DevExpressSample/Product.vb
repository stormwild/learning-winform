Public Class Product
    Public Property Id As Integer
    Public Property Name As String
    Public Property CategoryId As Integer
    Public Property QuantityPerUnit As String
    Public Property UnitPrice As Decimal
    Public Property UnitsInStock As Integer
    Public Property UnitsInOrder As Integer
    Public Property Discontinued As Boolean

    Public Sub New(
                  productId As Integer,
                  productName As String,
                  catId As Integer,
                  unitQuantity As String,
                  price As Decimal,
                  inStock As Integer,
                  inOrder As Integer,
                  discontd As String)
        Id = productId
        Name = productName
        CategoryId = catId
        QuantityPerUnit = unitQuantity
        UnitPrice = price
        UnitsInStock = inStock
        UnitsInOrder = inOrder
        Discontinued = discontd
    End Sub
End Class
