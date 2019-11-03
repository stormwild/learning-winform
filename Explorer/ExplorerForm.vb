Imports System.IO

Public Class ExplorerForm
    Private Sub ExplorerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewToolStripComboBox.SelectedIndex = 1

        MainListView.Columns.Add("Name", 250)
        MainListView.Columns.Add("Date Modified", 150)
        MainListView.Columns.Add("Size", 75, HorizontalAlignment.Right)

        Dim docs As New TreeNode("My Documents")
        docs.Tag = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        MainTreeView.Nodes.Add(docs)

        GetFolders(docs)
        docs.Expand()
    End Sub

    Private Sub GetFolders(node As TreeNode)
        Dim dir As New DirectoryInfo(node.Tag)

        Try
            For Each childDir In dir.GetDirectories()
                If childDir.Attributes.HasFlag(FileAttributes.Hidden) Then
                    Continue For
                End If

                Dim childNode As New TreeNode(childDir.Name)
                childNode.Tag = childDir.FullName
                node.Nodes.Add(childNode)

                GetFolders(childNode)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MainTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MainTreeView.AfterSelect
        Dim dir As New DirectoryInfo(e.Node.Tag)

        MainListView.Items.Clear()
        LargeImageList.Images.RemoveByKey(".exe")
        SmallImageList.Images.RemoveByKey(".exe")

        For Each fileItem In dir.GetFiles()
            Dim item As New ListViewItem(fileItem.Name)

            Dim lastWrite = fileItem.LastWriteTime
            item.SubItems.Add(lastWrite.ToShortDateString() & " " & lastWrite.ToShortTimeString)
            item.SubItems.Add(Math.Ceiling(fileItem.Length / 1024) & " kb")

            If Not LargeImageList.Images.ContainsKey(fileItem.Extension) Then
                Dim iconItem = Icon.ExtractAssociatedIcon(fileItem.FullName)
                LargeImageList.Images.Add(fileItem.Extension, iconItem)
                SmallImageList.Images.Add(fileItem.Extension, iconItem)
            End If

            item.ImageKey = fileItem.Extension
            MainListView.Items.Add(item)
        Next
    End Sub

    Private Sub ViewToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ViewToolStripComboBox.SelectedIndexChanged
        Select Case ViewToolStripComboBox.Text
            Case "Detail"
                MainListView.View = View.Details
            Case "Large Icon"
                MainListView.View = View.LargeIcon
            Case "Small Icon"
                MainListView.View = View.SmallIcon
        End Select
    End Sub
End Class
