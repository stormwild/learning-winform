<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmDialog
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
        Me.ConfirmPanel = New System.Windows.Forms.Panel()
        Me.ConfirmLabel = New System.Windows.Forms.Label()
        Me.ConfirmNo = New System.Windows.Forms.Button()
        Me.ConfirmYes = New System.Windows.Forms.Button()
        Me.ConfirmPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConfirmPanel
        '
        Me.ConfirmPanel.BackColor = System.Drawing.Color.White
        Me.ConfirmPanel.Controls.Add(Me.ConfirmLabel)
        Me.ConfirmPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ConfirmPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmPanel.Name = "ConfirmPanel"
        Me.ConfirmPanel.Size = New System.Drawing.Size(284, 80)
        Me.ConfirmPanel.TabIndex = 0
        '
        'ConfirmLabel
        '
        Me.ConfirmLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConfirmLabel.AutoSize = True
        Me.ConfirmLabel.Location = New System.Drawing.Point(13, 30)
        Me.ConfirmLabel.Name = "ConfirmLabel"
        Me.ConfirmLabel.Size = New System.Drawing.Size(158, 13)
        Me.ConfirmLabel.TabIndex = 0
        Me.ConfirmLabel.Text = "Are you sure you want to close?"
        '
        'ConfirmNo
        '
        Me.ConfirmNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.ConfirmNo.Location = New System.Drawing.Point(197, 86)
        Me.ConfirmNo.Name = "ConfirmNo"
        Me.ConfirmNo.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmNo.TabIndex = 1
        Me.ConfirmNo.Text = "No"
        Me.ConfirmNo.UseVisualStyleBackColor = True
        '
        'ConfirmYes
        '
        Me.ConfirmYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.ConfirmYes.Location = New System.Drawing.Point(116, 87)
        Me.ConfirmYes.Name = "ConfirmYes"
        Me.ConfirmYes.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmYes.TabIndex = 2
        Me.ConfirmYes.Text = "Yes"
        Me.ConfirmYes.UseVisualStyleBackColor = True
        '
        'ConfirmDialog
        '
        Me.AcceptButton = Me.ConfirmYes
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ConfirmNo
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.ConfirmYes)
        Me.Controls.Add(Me.ConfirmNo)
        Me.Controls.Add(Me.ConfirmPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfirmDialog"
        Me.Text = "ConfirmDialog"
        Me.ConfirmPanel.ResumeLayout(False)
        Me.ConfirmPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConfirmPanel As Panel
    Friend WithEvents ConfirmLabel As Label
    Friend WithEvents ConfirmNo As Button
    Friend WithEvents ConfirmYes As Button
End Class
