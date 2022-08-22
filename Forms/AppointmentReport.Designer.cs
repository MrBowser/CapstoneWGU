
namespace SoftwareTwoProject.Forms
{
    partial class AppointmentReport
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
            this.AppTypeGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReportBut = new System.Windows.Forms.Button();
            this.ReportView = new System.Windows.Forms.DataGridView();
            this.MainDashBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // AppTypeGrid
            // 
            this.AppTypeGrid.AllowUserToAddRows = false;
            this.AppTypeGrid.AllowUserToDeleteRows = false;
            this.AppTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTypeGrid.Location = new System.Drawing.Point(396, 36);
            this.AppTypeGrid.Name = "AppTypeGrid";
            this.AppTypeGrid.Size = new System.Drawing.Size(215, 150);
            this.AppTypeGrid.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // ReportBut
            // 
            this.ReportBut.Location = new System.Drawing.Point(308, 208);
            this.ReportBut.Name = "ReportBut";
            this.ReportBut.Size = new System.Drawing.Size(75, 23);
            this.ReportBut.TabIndex = 2;
            this.ReportBut.Text = "Run Report";
            this.ReportBut.UseVisualStyleBackColor = true;
            this.ReportBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportBut_MouseClick);
            // 
            // ReportView
            // 
            this.ReportView.AllowUserToAddRows = false;
            this.ReportView.AllowUserToDeleteRows = false;
            this.ReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportView.Location = new System.Drawing.Point(57, 252);
            this.ReportView.Name = "ReportView";
            this.ReportView.Size = new System.Drawing.Size(554, 150);
            this.ReportView.TabIndex = 3;
            // 
            // MainDashBut
            // 
            this.MainDashBut.Location = new System.Drawing.Point(664, 412);
            this.MainDashBut.Name = "MainDashBut";
            this.MainDashBut.Size = new System.Drawing.Size(75, 23);
            this.MainDashBut.TabIndex = 4;
            this.MainDashBut.Text = "Dashboard";
            this.MainDashBut.UseVisualStyleBackColor = true;
            this.MainDashBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainDashBut_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Extra Report: A list of appointments of a specific type by month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "(note: times are displayed in UTC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLC";
            // 
            // AppointmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainDashBut);
            this.Controls.Add(this.ReportView);
            this.Controls.Add(this.ReportBut);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AppTypeGrid);
            this.Name = "AppointmentReport";
            this.Text = "AppointmentReport";
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppTypeGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ReportBut;
        private System.Windows.Forms.DataGridView ReportView;
        private System.Windows.Forms.Button MainDashBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}