Public Class Category
    Public Property Id As Integer
    Public Property Name As String

    Public Sub New(categoryId As Integer, categoryName As String)
        Id = categoryId
        Name = categoryName
    End Sub
End Class
