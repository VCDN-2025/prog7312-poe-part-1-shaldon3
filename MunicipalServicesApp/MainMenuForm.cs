using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            // Disable features not yet implemented
            btnLocalEvents.Enabled = false;
            btnServiceStatus.Enabled = false;
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            using (var reportForm = new ReportIssueForm())
            {
                reportForm.ShowDialog();
            }
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Local Events will be implemented later.", "Info");
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status will be implemented later.", "Info");
        }
    }
}
