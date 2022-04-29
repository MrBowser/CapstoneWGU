
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainDashBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppTypeGrid
            // 
            this.AppTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppTypeGrid.Location = new System.Drawing.Point(396, 36);
            this.AppTypeGrid.Name = "AppTypeGrid";
            this.AppTypeGrid.Size = new System.Drawing.Size(240, 150);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 150);
            this.dataGridView1.TabIndex = 3;
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
            // AppointmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainDashBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReportBut);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AppTypeGrid);
            this.Name = "AppointmentReport";
            this.Text = "AppointmentReport";
            ((System.ComponentModel.ISupportInitialize)(this.AppTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AppTypeGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ReportBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MainDashBut;
    }
}