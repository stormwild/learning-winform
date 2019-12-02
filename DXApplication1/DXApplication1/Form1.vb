Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class Form1

    Private employeesUserControl As XtraUserControl
    Private customersUserControl As XtraUserControl
    Public Sub New()
        InitializeComponent()
        employeesUserControl = CreateUserControl("Employees")
        customersUserControl = CreateUserControl("Customers")
        accordionControl.SelectedElement = employeesAccordionControlElement
    End Sub
    Private Function CreateUserControl(ByVal text As String) As XtraUserControl
        Dim result As New XtraUserControl()
        result.Name = text.ToLower() & "UserControl"
        result.Text = text
        Dim label As New LabelControl()
        label.Parent = result
        label.Appearance.Font = New Font("Tahoma", 25.25F)
        label.Appearance.ForeColor = Color.Gray
        label.Dock = System.Windows.Forms.DockStyle.Fill
        label.AutoSizeMode = LabelAutoSizeMode.None
        label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        label.Text = text
        Return result
    End Function
    Private Sub accordionControl_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs) Handles accordionControl.SelectedElementChanged
        If e.Element Is Nothing Then
            Return
        End If
        Dim userControl As XtraUserControl = If(e.Element.Text = "Employees", employeesUserControl, customersUserControl)
        tabbedView.AddDocument(userControl)
        tabbedView.ActivateDocument(userControl)
    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles employeesBarButtonItem.ItemClick, customersBarButtonItem.ItemClick
        If e.Item.Caption = "Employees" Then
            accordionControl.SelectedElement = employeesAccordionControlElement
        Else
            accordionControl.SelectedElement = customersAccordionControlElement
        End If
    End Sub
    Private Sub tabbedView_DocumentClosed(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView.DocumentClosed
        RecreateUserControls(e)
        SetAccordionSelectedElement(e)
    End Sub
    Private Sub SetAccordionSelectedElement(ByVal e As DocumentEventArgs)
        If tabbedView.Documents.Count <> 0 Then
            If e.Document.Caption = "Employees" Then
                accordionControl.SelectedElement = customersAccordionControlElement
            Else
                accordionControl.SelectedElement = employeesAccordionControlElement
            End If
        Else
            accordionControl.SelectedElement = Nothing
        End If
    End Sub
    Private Sub RecreateUserControls(ByVal e As DocumentEventArgs)
        If e.Document.Caption = "Employees" Then
            employeesUserControl = CreateUserControl("Employees")
        Else
            customersUserControl = CreateUserControl("Customers")
        End If
    End Sub
End Class
