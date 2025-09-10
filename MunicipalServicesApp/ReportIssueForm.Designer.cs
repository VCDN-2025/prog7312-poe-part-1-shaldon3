namespace MunicipalServicesApp
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.ProgressBar progressEngagement;
        private System.Windows.Forms.GroupBox grpIssueDetails;
        private System.Windows.Forms.GroupBox grpAttachments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.progressEngagement = new System.Windows.Forms.ProgressBar();
            this.grpIssueDetails = new System.Windows.Forms.GroupBox();
            this.grpAttachments = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();

            // === Group: Issue Details ===
            this.grpIssueDetails.Text = "Issue Details";
            this.grpIssueDetails.Location = new System.Drawing.Point(20, 20);
            this.grpIssueDetails.Size = new System.Drawing.Size(540, 220);

            // lblLocation
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(20, 35);
            this.lblLocation.Text = "Location:";

            // txtLocation
            this.txtLocation.Location = new System.Drawing.Point(120, 32);
            this.txtLocation.Size = new System.Drawing.Size(380, 23);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 75);
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(120, 72);
            this.cmbCategory.Size = new System.Drawing.Size(220, 23);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 115);
            this.lblDescription.Text = "Description:";

            // rtbDescription
            this.rtbDescription.Location = new System.Drawing.Point(120, 112);
            this.rtbDescription.Size = new System.Drawing.Size(380, 90);

            // add to group
            this.grpIssueDetails.Controls.Add(this.lblLocation);
            this.grpIssueDetails.Controls.Add(this.txtLocation);
            this.grpIssueDetails.Controls.Add(this.lblCategory);
            this.grpIssueDetails.Controls.Add(this.cmbCategory);
            this.grpIssueDetails.Controls.Add(this.lblDescription);
            this.grpIssueDetails.Controls.Add(this.rtbDescription);

            // === Group: Attachments ===
            this.grpAttachments.Text = "Attachments";
            this.grpAttachments.Location = new System.Drawing.Point(20, 250);
            this.grpAttachments.Size = new System.Drawing.Size(540, 120);

            // btnAttach
            this.btnAttach.Location = new System.Drawing.Point(20, 40);
            this.btnAttach.Size = new System.Drawing.Size(140, 30);
            this.btnAttach.Text = "Attach Media";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            // lstAttachments
            this.lstAttachments.Location = new System.Drawing.Point(180, 30);
            this.lstAttachments.Size = new System.Drawing.Size(330, 64);

            // add to group
            this.grpAttachments.Controls.Add(this.btnAttach);
            this.grpAttachments.Controls.Add(this.lstAttachments);

            // === Engagement Label + ProgressBar ===
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new System.Drawing.Point(20, 390);
            this.lblEngagement.Text = "Thanks for reporting — you are making a difference!";

            this.progressEngagement.Location = new System.Drawing.Point(20, 415);
            this.progressEngagement.Size = new System.Drawing.Size(540, 20);
            this.progressEngagement.Value = 50; // example halfway filled

            // === Buttons ===
            this.btnBack.Location = new System.Drawing.Point(120, 450);
            this.btnBack.Size = new System.Drawing.Size(160, 35);
            this.btnBack.Text = "← Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.btnSubmit.Location = new System.Drawing.Point(320, 450);
            this.btnSubmit.Size = new System.Drawing.Size(160, 35);
            this.btnSubmit.Text = "✔ Submit Report";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // === Form ===
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.grpIssueDetails);
            this.Controls.Add(this.grpAttachments);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressEngagement);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Issues";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
