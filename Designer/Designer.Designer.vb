<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Designer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.ShowMessageButton = New System.Windows.Forms.Button()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(12, 64)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(39, 13)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "[Label]"
        '
        'ShowMessageButton
        '
        Me.ShowMessageButton.Location = New System.Drawing.Point(12, 38)
        Me.ShowMessageButton.Name = "ShowMessageButton"
        Me.ShowMessageButton.Size = New System.Drawing.Size(200, 23)
        Me.ShowMessageButton.TabIndex = 1
        Me.ShowMessageButton.Text = "ShowMessage"
        Me.ShowMessageButton.UseVisualStyleBackColor = True
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Location = New System.Drawing.Point(12, 12)
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MessageTextBox.TabIndex = 2
        '
        'Designer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 441)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.ShowMessageButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "Designer"
        Me.Text = "Designer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageLabel As Label
    Friend WithEvents ShowMessageButton As Button
    Friend WithEvents MessageTextBox As TextBox
End Class
