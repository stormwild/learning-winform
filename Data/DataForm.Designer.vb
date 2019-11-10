<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DataTabControl = New System.Windows.Forms.TabControl()
        Me.FormTab = New System.Windows.Forms.TabPage()
        Me.GridTab = New System.Windows.Forms.TabPage()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CategoriesComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductStockTextBox = New System.Windows.Forms.TextBox()
        Me.DataTabControl.SuspendLayout()
        Me.FormTab.SuspendLayout()
        Me.GridTab.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'DataTabControl
        '
        Me.DataTabControl.Controls.Add(Me.FormTab)
        Me.DataTabControl.Controls.Add(Me.GridTab)
        Me.DataTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTabControl.Location = New System.Drawing.Point(0, 25)
        Me.DataTabControl.Name = "DataTabControl"
        Me.DataTabControl.SelectedIndex = 0
        Me.DataTabControl.Size = New System.Drawing.Size(800, 425)
        Me.DataTabControl.TabIndex = 1
        '
        'FormTab
        '
        Me.FormTab.Controls.Add(Me.ProductStockTextBox)
        Me.FormTab.Controls.Add(Me.ProductPriceTextBox)
        Me.FormTab.Controls.Add(Me.ProductNameTextBox)
        Me.FormTab.Controls.Add(Me.ProductsListBox)
        Me.FormTab.Controls.Add(Me.CategoriesComboBox)
        Me.FormTab.Location = New System.Drawing.Point(4, 22)
        Me.FormTab.Name = "FormTab"
        Me.FormTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FormTab.Size = New System.Drawing.Size(792, 399)
        Me.FormTab.TabIndex = 0
        Me.FormTab.Text = "Form"
        Me.FormTab.UseVisualStyleBackColor = True
        '
        'GridTab
        '
        Me.GridTab.Controls.Add(Me.ProductsDataGridView)
        Me.GridTab.Location = New System.Drawing.Point(4, 22)
        Me.GridTab.Name = "GridTab"
        Me.GridTab.Padding = New System.Windows.Forms.Padding(3)
        Me.GridTab.Size = New System.Drawing.Size(792, 399)
        Me.GridTab.TabIndex = 1
        Me.GridTab.Text = "Grid"
        Me.GridTab.UseVisualStyleBackColor = True
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(786, 393)
        Me.ProductsDataGridView.TabIndex = 0
        '
        'CategoriesComboBox
        '
        Me.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriesComboBox.FormattingEnabled = True
        Me.CategoriesComboBox.Location = New System.Drawing.Point(24, 24)
        Me.CategoriesComboBox.Name = "CategoriesComboBox"
        Me.CategoriesComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CategoriesComboBox.TabIndex = 2
        '
        'ProductsListBox
        '
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(24, 68)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(200, 290)
        Me.ProductsListBox.TabIndex = 3
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Location = New System.Drawing.Point(292, 68)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductNameTextBox.TabIndex = 4
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(292, 105)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductPriceTextBox.TabIndex = 5
        '
        'ProductStockTextBox
        '
        Me.ProductStockTextBox.Location = New System.Drawing.Point(292, 142)
        Me.ProductStockTextBox.Name = "ProductStockTextBox"
        Me.ProductStockTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductStockTextBox.TabIndex = 6
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataTabControl)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DataForm"
        Me.Text = "Data Binding Sample"
        Me.DataTabControl.ResumeLayout(False)
        Me.FormTab.ResumeLayout(False)
        Me.FormTab.PerformLayout()
        Me.GridTab.ResumeLayout(False)
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataTabControl As TabControl
    Friend WithEvents FormTab As TabPage
    Friend WithEvents GridTab As TabPage
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents CategoriesComboBox As ComboBox
    Friend WithEvents ProductsListBox As ListBox
    Friend WithEvents ProductStockTextBox As TextBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
End Class
