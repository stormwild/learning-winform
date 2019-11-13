<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordForm
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
        Me.LaunchWordButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LaunchWordButton
        '
        Me.LaunchWordButton.Location = New System.Drawing.Point(46, 35)
        Me.LaunchWordButton.Name = "LaunchWordButton"
        Me.LaunchWordButton.Size = New System.Drawing.Size(200, 23)
        Me.LaunchWordButton.TabIndex = 0
        Me.LaunchWordButton.Text = "Launch Word"
        Me.LaunchWordButton.UseVisualStyleBackColor = True
        '
        'WordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LaunchWordButton)
        Me.Name = "WordForm"
        Me.Text = "Word Sample"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LaunchWordButton As Button
End Class
