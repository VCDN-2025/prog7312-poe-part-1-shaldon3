using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp
{
    public partial class ReportIssueForm : Form
    {
        // In-memory store for submitted issues (static so multiple instances share it)
        private static List<Issue> _issues = new List<Issue>();

        // Temporary attachments for this report
        private List<string> _attachments = new List<string>();

        // Encouragement messages
        private readonly string[] _encouragements = new[]
        {
            "Thanks — your report helps improve your neighbourhood!",
            "Almost there — attach photos for faster resolution.",
            "Good job! Clear details speed up action."
        };
        private int _encIndex = 0;

        public ReportIssueForm()
        {
            InitializeComponent();

            // Populate categories
            cmbCategory.Items.AddRange(new string[] { "Sanitation", "Roads", "Water/Utilities", "Street Lighting", "Other" });
            cmbCategory.SelectedIndex = 0;

            // Start a timer to rotate the engagement message
            var t = new Timer { Interval = 3000 };
            t.Tick += (s, e) =>
            {
                lblEngagement.Text = _encouragements[_encIndex];
                _encIndex = (_encIndex + 1) % _encouragements.Length;
            };
            t.Start();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Multiselect = true;
                dlg.Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.pdf;*.docx;*.doc|All files|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in dlg.FileNames)
                    {
                        _attachments.Add(f);
                        lstAttachments.Items.Add(Path.GetFileName(f));
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and store the issue
            var newIssue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                AttachmentPaths = new List<string>(_attachments)
            };

            _issues.Add(newIssue);

            // Provide feedback
            MessageBox.Show($"Report submitted successfully!\nReference: {newIssue.Id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form for next report
            txtLocation.Clear();
            rtbDescription.Clear();
            lstAttachments.Items.Clear();
            _attachments.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
