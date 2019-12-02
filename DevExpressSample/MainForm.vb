Public Class MainForm
    Private _current As Category
    Private ReadOnly _source As New ObjectSource()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim categories = _source.GetCategories()

        GridLookUpEdit1.Properties.DisplayMember = "Name"
        GridLookUpEdit1.Properties.ValueMember = ""

        Dim binding = New Binding("EditValue", Me, "Current")

        GridLookUpEdit1.Properties.DataSource = categories
        GridLookUpEdit1.DataBindings.Add(binding)
        Current = categories.First()

        GridLookUpEdit1.EditValue = Current
    End Sub

    Public Property Current() As Category
        Get
            Return _current
        End Get
        Set(ByVal value As Category)
            _current = value
        End Set
    End Property
End Class