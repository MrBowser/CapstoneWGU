namespace SoftwareTwoProject.Forms
{
    partial class MainDashboard
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
            this.CustomerRecordsGrid = new System.Windows.Forms.DataGridView();
            this.AddCustomerBut = new System.Windows.Forms.Button();
            this.EditCustomerBut = new System.Windows.Forms.Button();
            this.DeleteCustomerBut = new System.Windows.Forms.Button();
            this.AppointmentsListGrid = new System.Windows.Forms.DataGridView();
            this.AppointmentsAddBut = new System.Windows.Forms.Button();
            this.EditAppointmentsBut = new System.Windows.Forms.Button();
            this.DeleteAppointmentsBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.WeeklyViewBut = new System.Windows.Forms.Button();
            this.MonthlyViewBut = new System.Windows.Forms.Button();
            this.ReportsMenuBut = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.AppointementsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerRecordsGrid
            // 
            this.CustomerRecordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerRecordsGrid.Location = new System.Drawing.Point(47, 81);
            this.CustomerRecordsGrid.Name = "CustomerRecordsGrid";
            this.CustomerRecordsGrid.Size = new System.Drawing.Size(310, 150);
            this.CustomerRecordsGrid.TabIndex = 0;
            // 
            // AddCustomerBut
            // 
            this.AddCustomerBut.Location = new System.Drawing.Point(47, 261);
            this.AddCustomerBut.Name = "AddCustomerBut";
            this.AddCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.AddCustomerBut.TabIndex = 1;
            this.AddCustomerBut.Text = "Add";
            this.AddCustomerBut.UseVisualStyleBackColor = true;
            this.AddCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddCustomerBut_MouseClick);
            // 
            // EditCustomerBut
            // 
            this.EditCustomerBut.Location = new System.Drawing.Point(47, 302);
            this.EditCustomerBut.Name = "EditCustomerBut";
            this.EditCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.EditCustomerBut.TabIndex = 2;
            this.EditCustomerBut.Text = "Edit";
            this.EditCustomerBut.UseVisualStyleBackColor = true;
            this.EditCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditCustomerBut_MouseClick);
            // 
            // DeleteCustomerBut
            // 
            this.DeleteCustomerBut.Location = new System.Drawing.Point(47, 343);
            this.DeleteCustomerBut.Name = "DeleteCustomerBut";
            this.DeleteCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteCustomerBut.TabIndex = 3;
            this.DeleteCustomerBut.Text = "Delete";
            this.DeleteCustomerBut.UseVisualStyleBackColor = true;
            // 
            // AppointmentsListGrid
            // 
            this.AppointmentsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsListGrid.Location = new System.Drawing.Point(477, 81);
            this.AppointmentsListGrid.Name = "AppointmentsListGrid";
            this.AppointmentsListGrid.Size = new System.Drawing.Size(330, 150);
            this.AppointmentsListGrid.TabIndex = 4;
            // 
            // AppointmentsAddBut
            // 
            this.AppointmentsAddBut.Location = new System.Drawing.Point(477, 261);
            this.AppointmentsAddBut.Name = "AppointmentsAddBut";
            this.AppointmentsAddBut.Size = new System.Drawing.Size(75, 23);
            this.AppointmentsAddBut.TabIndex = 5;
            this.AppointmentsAddBut.Text = "Add";
            this.AppointmentsAddBut.UseVisualStyleBackColor = true;
            this.AppointmentsAddBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppointmentsAddBut_MouseClick);
            // 
            // EditAppointmentsBut
            // 
            this.EditAppointmentsBut.Location = new System.Drawing.Point(477, 302);
            this.EditAppointmentsBut.Name = "EditAppointmentsBut";
            this.EditAppointmentsBut.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentsBut.TabIndex = 6;
            this.EditAppointmentsBut.Text = "Edit";
            this.EditAppointmentsBut.UseVisualStyleBackColor = true;
            this.EditAppointmentsBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditAppointmentsBut_MouseClick);
            // 
            // DeleteAppointmentsBut
            // 
            this.DeleteAppointmentsBut.Location = new System.Drawing.Point(477, 343);
            this.DeleteAppointmentsBut.Name = "DeleteAppointmentsBut";
            this.DeleteAppointmentsBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteAppointmentsBut.TabIndex = 7;
            this.DeleteAppointmentsBut.Text = "Delete";
            this.DeleteAppointmentsBut.UseVisualStyleBackColor = true;
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(788, 444);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(75, 23);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitBut_MouseClick);
            // 
            // WeeklyViewBut
            // 
            this.WeeklyViewBut.Location = new System.Drawing.Point(211, 444);
            this.WeeklyViewBut.Name = "WeeklyViewBut";
            this.WeeklyViewBut.Size = new System.Drawing.Size(75, 23);
            this.WeeklyViewBut.TabIndex = 9;
            this.WeeklyViewBut.Text = "Weekly";
            this.WeeklyViewBut.UseVisualStyleBackColor = true;
            // 
            // MonthlyViewBut
            // 
            this.MonthlyViewBut.Location = new System.Drawing.Point(307, 444);
            this.MonthlyViewBut.Name = "MonthlyViewBut";
            this.MonthlyViewBut.Size = new System.Drawing.Size(75, 23);
            this.MonthlyViewBut.TabIndex = 10;
            this.MonthlyViewBut.Text = "Monthly";
            this.MonthlyViewBut.UseVisualStyleBackColor = true;
            // 
            // ReportsMenuBut
            // 
            this.ReportsMenuBut.Location = new System.Drawing.Point(477, 444);
            this.ReportsMenuBut.Name = "ReportsMenuBut";
            this.ReportsMenuBut.Size = new System.Drawing.Size(75, 23);
            this.ReportsMenuBut.TabIndex = 11;
            this.ReportsMenuBut.Text = "Reports";
            this.ReportsMenuBut.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(110, 51);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(94, 13);
            this.CustomerLabel.TabIndex = 12;
            this.CustomerLabel.Text = "Customer Records";
            // 
            // AppointementsLabel
            // 
            this.AppointementsLabel.AutoSize = true;
            this.AppointementsLabel.Location = new System.Drawing.Point(607, 51);
            this.AppointementsLabel.Name = "AppointementsLabel";
            this.AppointementsLabel.Size = new System.Drawing.Size(71, 13);
            this.AppointementsLabel.TabIndex = 13;
            this.AppointementsLabel.Text = "Appointments";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.AppointementsLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ReportsMenuBut);
            this.Controls.Add(this.MonthlyViewBut);
            this.Controls.Add(this.WeeklyViewBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.DeleteAppointmentsBut);
            this.Controls.Add(this.EditAppointmentsBut);
            this.Controls.Add(this.AppointmentsAddBut);
            this.Controls.Add(this.AppointmentsListGrid);
            this.Controls.Add(this.DeleteCustomerBut);
            this.Controls.Add(this.EditCustomerBut);
            this.Controls.Add(this.AddCustomerBut);
            this.Controls.Add(this.CustomerRecordsGrid);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerRecordsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerRecordsGrid;
        private System.Windows.Forms.Button AddCustomerBut;
        private System.Windows.Forms.Button EditCustomerBut;
        private System.Windows.Forms.Button DeleteCustomerBut;
        private System.Windows.Forms.DataGridView AppointmentsListGrid;
        private System.Windows.Forms.Button AppointmentsAddBut;
        private System.Windows.Forms.Button EditAppointmentsBut;
        private System.Windows.Forms.Button DeleteAppointmentsBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button WeeklyViewBut;
        private System.Windows.Forms.Button MonthlyViewBut;
        private System.Windows.Forms.Button ReportsMenuBut;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label AppointementsLabel;
    }
}