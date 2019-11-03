<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExplorerForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MainToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.MainTreeView = New System.Windows.Forms.TreeView()
        Me.MainListView = New System.Windows.Forms.ListView()
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ViewToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ViewToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.MainToolStrip.SuspendLayout()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.Panel1.SuspendLayout()
        Me.MainSplitContainer.Panel2.SuspendLayout()
        Me.MainSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainToolStrip
        '
        Me.MainToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripLabel, Me.ViewToolStripComboBox})
        Me.MainToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainToolStrip.Name = "MainToolStrip"
        Me.MainToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.MainToolStrip.TabIndex = 0
        Me.MainToolStrip.Text = "ToolStrip1"
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 25)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.MainTreeView)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.MainListView)
        Me.MainSplitContainer.Size = New System.Drawing.Size(800, 425)
        Me.MainSplitContainer.SplitterDistance = 266
        Me.MainSplitContainer.TabIndex = 1
        '
        'MainTreeView
        '
        Me.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.MainTreeView.Name = "MainTreeView"
        Me.MainTreeView.Size = New System.Drawing.Size(266, 425)
        Me.MainTreeView.TabIndex = 0
        '
        'MainListView
        '
        Me.MainListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainListView.HideSelection = False
        Me.MainListView.LargeImageList = Me.LargeImageList
        Me.MainListView.Location = New System.Drawing.Point(0, 0)
        Me.MainListView.Name = "MainListView"
        Me.MainListView.Size = New System.Drawing.Size(530, 425)
        Me.MainListView.SmallImageList = Me.SmallImageList
        Me.MainListView.TabIndex = 0
        Me.MainListView.UseCompatibleStateImageBehavior = False
        '
        'LargeImageList
        '
        Me.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LargeImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'SmallImageList
        '
        Me.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.SmallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ViewToolStripLabel
        '
        Me.ViewToolStripLabel.Name = "ViewToolStripLabel"
        Me.ViewToolStripLabel.Size = New System.Drawing.Size(32, 22)
        Me.ViewToolStripLabel.Text = "View"
        '
        'ViewToolStripComboBox
        '
        Me.ViewToolStripComboBox.Items.AddRange(New Object() {"Detail", "Large Icon", "Small Icon"})
        Me.ViewToolStripComboBox.Name = "ViewToolStripComboBox"
        Me.ViewToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ExplorerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.MainToolStrip)
        Me.Name = "ExplorerForm"
        Me.Text = "Explorer Style Application"
        Me.MainToolStrip.ResumeLayout(False)
        Me.MainToolStrip.PerformLayout()
        Me.MainSplitContainer.Panel1.ResumeLayout(False)
        Me.MainSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainToolStrip As ToolStrip
    Friend WithEvents MainSplitContainer As SplitContainer
    Friend WithEvents MainTreeView As TreeView
    Friend WithEvents MainListView As ListView
    Friend WithEvents LargeImageList As ImageList
    Friend WithEvents SmallImageList As ImageList
    Friend WithEvents ViewToolStripLabel As ToolStripLabel
    Friend WithEvents ViewToolStripComboBox As ToolStripComboBox
End Class
