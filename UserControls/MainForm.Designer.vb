<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ShowLastNameButton = New System.Windows.Forms.Button()
        Me.PersonControl1 = New UserControls.PersonControl()
        Me.SuspendLayout()
        '
        'ShowLastNameButton
        '
        Me.ShowLastNameButton.Location = New System.Drawing.Point(87, 146)
        Me.ShowLastNameButton.Name = "ShowLastNameButton"
        Me.ShowLastNameButton.Size = New System.Drawing.Size(200, 23)
        Me.ShowLastNameButton.TabIndex = 1
        Me.ShowLastNameButton.Text = "Show Last Name"
        Me.ShowLastNameButton.UseVisualStyleBackColor = True
        '
        'PersonControl1
        '
        Me.PersonControl1.Location = New System.Drawing.Point(12, 12)
        Me.PersonControl1.Name = "PersonControl1"
        Me.PersonControl1.Size = New System.Drawing.Size(283, 124)
        Me.PersonControl1.TabIndex = 2
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(503, 261)
        Me.Controls.Add(Me.PersonControl1)
        Me.Controls.Add(Me.ShowLastNameButton)
        Me.Name = "MainForm"
        Me.Text = "User Control Sample"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowLastNameButton As Button
    Friend WithEvents PersonControl1 As PersonControl
End Class
