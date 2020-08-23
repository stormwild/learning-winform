Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Private ReadOnly _source As New ObjectSource()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LookUpEdit1.Properties.ValueMember = "Id"
        LookUpEdit1.Properties.DisplayMember = "Name"
        LookUpEdit1.Properties.DataSource = _source.GetCategories()
    End Sub
End Class
