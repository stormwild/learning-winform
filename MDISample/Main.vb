Public Class Main
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim childForm = New ChildForm()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticallyToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.Redo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.Cut()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.Paste()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentRichTextBox.SelectAll()
        End If
    End Sub
End Class
