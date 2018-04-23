using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace RegisterCustomFieldEditor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void RegisterComboBoxEditor() {
            // Create a new combo box editor with required settings.
            RepositoryItemComboBox repositoryItemComboBox = new RepositoryItemComboBox() {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor,
                ImmediatePopup = true
            };

            // Populate the created editor with items.
            for (int i = 0; i < 20; i++)
                repositoryItemComboBox.Items.Add(string.Format("Item {0}", i + 1));
            EditingFieldExtensionsWin.Instance.RegisterEditor
                ("ComboBoxEditor", "ComboBox Editor", "Custom", repositoryItemComboBox);
        }

        private void RegisterDateEditor() {
            // Create a new date editor with required settings.
            RepositoryItemDateEdit dateRepositoryItem = new RepositoryItemDateEdit() {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor,
                MinValue = DateTime.Today.AddMonths(-2),
                MaxValue = DateTime.Today.AddMonths(2)
            };

            // Apply a mask to the created editor.
            dateRepositoryItem.Mask.UseMaskAsDisplayFormat = true; 
            dateRepositoryItem.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dateRepositoryItem.Mask.EditMask = "MMMM dd, yyyy";
            EditingFieldExtensionsWin.Instance.RegisterEditor
                ("DateEditor", "Date Editor", "Custom", dateRepositoryItem);
        }

        private void RegisterEditorWithMask() {
            // Register a text editor with a phone number mask.
            EditingFieldExtensionsWin.Instance.RegisterMaskEditor("PhoneNumberEditor", "Phone Number Editor", 
                "Custom", DevExpress.XtraEditors.Mask.MaskType.Simple, "(999)000-00-00");
        }

        private XtraReport CreateReport() {
            // Create a new report instance.
            XtraReport1 report = new XtraReport1();

            // Register custom editors.
            RegisterComboBoxEditor();
            RegisterDateEditor();
            RegisterEditorWithMask();

            // Enable content editing for controls and assign the required editors.
            report.xrLabel1.EditOptions.Enabled = true;
            report.xrLabel1.EditOptions.EditorName = "ComboBoxEditor";

            report.xrLabel2.EditOptions.Enabled = true;
            report.xrLabel2.EditOptions.EditorName = "DateEditor";

            report.xrLabel3.EditOptions.Enabled = true;
            report.xrLabel3.EditOptions.EditorName = "PhoneNumberEditor";

            return report;
        }

        private void btnShowPreview_Click(object sender, EventArgs e) {
            // Show the report's print preview
            ReportPrintTool printTool = new ReportPrintTool(CreateReport());
            printTool.ShowPreview();
        }

        private void btnShowDesigner_Click(object sender, EventArgs e) {
            // Open the report in the End-User Designer.
            ReportDesignTool designTool = new ReportDesignTool(CreateReport());
            designTool.ShowRibbonDesignerDialog();
        }
    }
}
