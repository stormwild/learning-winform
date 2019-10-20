Imports System.Windows.Forms

Public Class MyForm
    Inherits Form

    Private MessageTextbox As TextBox
    Private MessageLabel As Label
    Private ShowMessageButton As Button

    Public Sub New()
        Me.Text = "MyForm"

        MessageTextbox = New TextBox()
        MessageTextbox.Left = 25
        MessageTextbox.Top = 25
        MessageTextbox.Width = 200
        Me.Controls.Add(MessageTextbox)

        ShowMessageButton = New Button()
        ShowMessageButton.Left = 25
        ShowMessageButton.Top = 75
        ShowMessageButton.Width = 200
        ShowMessageButton.Text = "Show Message"
        Me.Controls.Add(ShowMessageButton)

        MessageLabel = New Label()
        MessageLabel.Left = 25
        MessageLabel.Top = 125
        MessageLabel.Text = "[Label]"
        Me.Controls.Add(MessageLabel)
    End Sub
End Class
