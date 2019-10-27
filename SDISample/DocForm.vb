Public Class DocForm
    Private Shared _counter As Integer = 0
    Public Shared Function CreateForm() As DocForm
        Dim form = New DocForm()
        _counter += 1
        form.Text = "New Document " & _counter
        My.Application.ApplicationContext.MainForm = form
        form.Show()
        Return form
    End Function
End Class
