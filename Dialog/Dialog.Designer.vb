﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog
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
        Me.FruitsListBox = New System.Windows.Forms.ListBox()
        Me.ShowSelectedButton = New System.Windows.Forms.Button()
        Me.SelectedFruitLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FruitsListBox
        '
        Me.FruitsListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FruitsListBox.FormattingEnabled = True
        Me.FruitsListBox.Location = New System.Drawing.Point(13, 13)
        Me.FruitsListBox.Name = "FruitsListBox"
        Me.FruitsListBox.Size = New System.Drawing.Size(320, 108)
        Me.FruitsListBox.TabIndex = 0
        '
        'ShowSelectedButton
        '
        Me.ShowSelectedButton.Location = New System.Drawing.Point(12, 127)
        Me.ShowSelectedButton.Name = "ShowSelectedButton"
        Me.ShowSelectedButton.Size = New System.Drawing.Size(200, 23)
        Me.ShowSelectedButton.TabIndex = 1
        Me.ShowSelectedButton.Text = "Show Selected"
        Me.ShowSelectedButton.UseVisualStyleBackColor = True
        '
        'SelectedFruitLabel
        '
        Me.SelectedFruitLabel.AutoSize = True
        Me.SelectedFruitLabel.Location = New System.Drawing.Point(13, 157)
        Me.SelectedFruitLabel.Name = "SelectedFruitLabel"
        Me.SelectedFruitLabel.Size = New System.Drawing.Size(78, 13)
        Me.SelectedFruitLabel.TabIndex = 2
        Me.SelectedFruitLabel.Text = "[Selected Fruit]"
        '
        'Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 490)
        Me.Controls.Add(Me.SelectedFruitLabel)
        Me.Controls.Add(Me.ShowSelectedButton)
        Me.Controls.Add(Me.FruitsListBox)
        Me.Name = "Dialog"
        Me.Text = "Dialogs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FruitsListBox As ListBox
    Friend WithEvents ShowSelectedButton As Button
    Friend WithEvents SelectedFruitLabel As Label
End Class
