Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI

Namespace RegisterCustomFieldEditor

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub RegisterComboBoxEditor()
            ' Create a new combo box editor with required settings.
            Dim repositoryItemComboBox As RepositoryItemComboBox = New RepositoryItemComboBox() With {.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor, .ImmediatePopup = True}
            ' Populate the created editor with items.
            For i As Integer = 0 To 20 - 1
                repositoryItemComboBox.Items.Add(String.Format("Item {0}", i + 1))
            Next

            EditingFieldExtensionsWin.Instance.RegisterEditor("ComboBoxEditor", "ComboBox Editor", "Custom", repositoryItemComboBox)
        End Sub

        Private Sub RegisterDateEditor()
            ' Create a new date editor with required settings.
            Dim dateRepositoryItem As RepositoryItemDateEdit = New RepositoryItemDateEdit() With {.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor, .MinValue = Date.Today.AddMonths(-2), .MaxValue = Date.Today.AddMonths(2)}
            ' Apply a mask to the created editor.
            dateRepositoryItem.Mask.UseMaskAsDisplayFormat = True
            dateRepositoryItem.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            dateRepositoryItem.Mask.EditMask = "MMMM dd, yyyy"
            EditingFieldExtensionsWin.Instance.RegisterEditor("DateEditor", "Date Editor", "Custom", dateRepositoryItem)
        End Sub

        Private Sub RegisterEditorWithMask()
            ' Register a text editor with a phone number mask.
            Call EditingFieldExtensionsWin.Instance.RegisterMaskEditor("PhoneNumberEditor", "Phone Number Editor", "Custom", DevExpress.XtraEditors.Mask.MaskType.Simple, "(999) 000-0000")
        End Sub

        Private Function CreateReport() As XtraReport
            ' Create a new report instance.
            Dim report As XtraReport1 = New XtraReport1()
            ' Register custom editors.
            RegisterComboBoxEditor()
            RegisterDateEditor()
            RegisterEditorWithMask()
            ' Enable content editing for controls and assign the required editors.
            report.xrLabel1.EditOptions.Enabled = True
            report.xrLabel1.EditOptions.EditorName = "ComboBoxEditor"
            report.xrLabel2.EditOptions.Enabled = True
            report.xrLabel2.EditOptions.EditorName = "DateEditor"
            report.xrLabel3.EditOptions.Enabled = True
            report.xrLabel3.EditOptions.EditorName = "PhoneNumberEditor"
            Return report
        End Function

        Private Sub btnShowPreview_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Show the report's print preview
            Dim printTool As ReportPrintTool = New ReportPrintTool(CreateReport())
            printTool.ShowPreview()
        End Sub

        Private Sub btnShowDesigner_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Open the report in the End-User Designer.
            Dim designTool As ReportDesignTool = New ReportDesignTool(CreateReport())
            designTool.ShowRibbonDesignerDialog()
        End Sub
    End Class
End Namespace
