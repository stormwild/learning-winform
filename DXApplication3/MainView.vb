Imports System.ComponentModel
Imports System.Text


Partial Public Class MainView
    Public Sub New()
        InitializeComponent()
        If (Not MvvmContext1.IsDesignMode) Then
            InitializeBindings()
        End If
    End Sub

    Sub InitializeBindings()
        Dim fluent = MvvmContext1.OfType(Of MainViewModel)()
    End Sub
End Class
