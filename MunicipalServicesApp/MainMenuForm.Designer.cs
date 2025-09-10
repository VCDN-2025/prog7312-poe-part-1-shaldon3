namespace MunicipalServicesApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;

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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.BackColor = System.Drawing.Color.WhiteSmoke; // Light background
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services - Main Menu";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(30, 60, 90); // Dark blue
            this.lblHeader.Location = new System.Drawing.Point(50, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 40);
            this.lblHeader.Text = "Municipal Services";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(70, 130, 180); // Steel blue
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(100, 80);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(300, 50);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "📢 Report an Issue";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.BackColor = System.Drawing.Color.FromArgb(100, 149, 237); // Cornflower blue
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.Location = new System.Drawing.Point(100, 150);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(300, 50);
            this.btnLocalEvents.TabIndex = 2;
            this.btnLocalEvents.Text = "📅 Local Events (Coming Soon)";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.BackColor = System.Drawing.Color.FromArgb(72, 61, 139); // Dark slate blue
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceStatus.Location = new System.Drawing.Point(100, 220);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(300, 50);
            this.btnServiceStatus.TabIndex = 3;
            this.btnServiceStatus.Text = "🔧 Service Status (Coming Soon)";
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // End
            // 
            this.ResumeLayout(false);
        }

        #endregion
    }
}
