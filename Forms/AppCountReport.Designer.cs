
namespace SoftwareTwoProject.Forms
{
    partial class AppCountReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashBut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AppTypeReport = new System.Windows.Forms.DataGridView();
            this.ReportBut = new System.Windows.Forms.Button();
            this.AppLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DashBut
            // 
            this.DashBut.Location = new System.Drawing.Point(683, 415);
            this.DashBut.Name = "DashBut";
            this.DashBut.Size = new System.Drawing.Size(75, 23);
            this.DashBut.TabIndex = 0;
            this.DashBut.Text = "Dashboard";
            this.DashBut.UseVisualStyleBackColor = true;
            this.DashBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DashBut_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AppTypeReport
            // 
            this.AppTypeReport.AllowUserToAddRows = false;
            this.AppTypeReport.AllowUserToDeleteRows = false;
            this.AppTypeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTypeReport.Location = new System.Drawing.Point(140, 211);
            this.AppTypeReport.Name = "AppTypeReport";
            this.AppTypeReport.Size = new System.Drawing.Size(393, 169);
            this.AppTypeReport.TabIndex = 2;
            // 
            // ReportBut
            // 
            this.ReportBut.Location = new System.Drawing.Point(399, 106);
            this.ReportBut.Name = "ReportBut";
            this.ReportBut.Size = new System.Drawing.Size(75, 23);
            this.ReportBut.TabIndex = 3;
            this.ReportBut.Text = "Run Report";
            this.ReportBut.UseVisualStyleBackColor = true;
            this.ReportBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportBut_MouseClick);
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Location = new System.Drawing.Point(140, 178);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(159, 13);
            this.AppLabel.TabIndex = 4;
            this.AppLabel.Text = "Appointment Type Count Report";
            // 
            // AppCountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.ReportBut);
            this.Controls.Add(this.AppTypeReport);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DashBut);
            this.Name = "AppCountReport";
            this.Text = "AppCountReport";
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DashBut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView AppTypeReport;
        private System.Windows.Forms.Button ReportBut;
        private System.Windows.Forms.Label AppLabel;
    }
}