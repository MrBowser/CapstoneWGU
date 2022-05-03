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
            this.components = new System.ComponentModel.Container();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet = new SoftwareTwoProject.client_scheduleDataSet();
            this.AddCustomerBut = new System.Windows.Forms.Button();
            this.EditCustomerBut = new System.Windows.Forms.Button();
            this.DeleteCustomerBut = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet1 = new SoftwareTwoProject.client_scheduleDataSet1();
            this.AppointmentsAddBut = new System.Windows.Forms.Button();
            this.EditAppointmentsBut = new System.Windows.Forms.Button();
            this.DeleteAppointmentsBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.CalendarViewBut = new System.Windows.Forms.Button();
            this.AppRepBut = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.AppointementsLabel = new System.Windows.Forms.Label();
            this.customerTableAdapter = new SoftwareTwoProject.client_scheduleDataSetTableAdapters.customerTableAdapter();
            this.appointmentTableAdapter = new SoftwareTwoProject.client_scheduleDataSet1TableAdapters.appointmentTableAdapter();
            this.CustomerInfoGrid = new System.Windows.Forms.DataGridView();
            this.AppointmentInfoGrid = new System.Windows.Forms.DataGridView();
            this.ReportsLab = new System.Windows.Forms.Label();
            this.extraReplabel = new System.Windows.Forms.Label();
            this.AppTypeBut = new System.Windows.Forms.Button();
            this.AppTypeCount = new System.Windows.Forms.Label();
            this.UserRepBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.DeleteCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteCustomerBut_MouseClick);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.client_scheduleDataSet1;
            // 
            // client_scheduleDataSet1
            // 
            this.client_scheduleDataSet1.DataSetName = "client_scheduleDataSet1";
            this.client_scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.DeleteAppointmentsBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteAppointmentsBut_MouseClick);
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
            // CalendarViewBut
            // 
            this.CalendarViewBut.Location = new System.Drawing.Point(70, 444);
            this.CalendarViewBut.Name = "CalendarViewBut";
            this.CalendarViewBut.Size = new System.Drawing.Size(75, 23);
            this.CalendarViewBut.TabIndex = 9;
            this.CalendarViewBut.Text = "Calendar";
            this.CalendarViewBut.UseVisualStyleBackColor = true;
            this.CalendarViewBut.Click += new System.EventHandler(this.CalendarViewBut_Click);
            // 
            // AppRepBut
            // 
            this.AppRepBut.Location = new System.Drawing.Point(273, 431);
            this.AppRepBut.Name = "AppRepBut";
            this.AppRepBut.Size = new System.Drawing.Size(152, 23);
            this.AppRepBut.TabIndex = 11;
            this.AppRepBut.Text = "Appointments By Type";
            this.AppRepBut.UseVisualStyleBackColor = true;
            this.AppRepBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppRepBut_MouseClick);
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerInfoGrid
            // 
            this.CustomerInfoGrid.AllowUserToAddRows = false;
            this.CustomerInfoGrid.AllowUserToDeleteRows = false;
            this.CustomerInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfoGrid.Location = new System.Drawing.Point(70, 81);
            this.CustomerInfoGrid.Name = "CustomerInfoGrid";
            this.CustomerInfoGrid.Size = new System.Drawing.Size(274, 150);
            this.CustomerInfoGrid.TabIndex = 14;
            // 
            // AppointmentInfoGrid
            // 
            this.AppointmentInfoGrid.AllowUserToAddRows = false;
            this.AppointmentInfoGrid.AllowUserToDeleteRows = false;
            this.AppointmentInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentInfoGrid.Location = new System.Drawing.Point(516, 81);
            this.AppointmentInfoGrid.Name = "AppointmentInfoGrid";
            this.AppointmentInfoGrid.Size = new System.Drawing.Size(240, 150);
            this.AppointmentInfoGrid.TabIndex = 15;
            // 
            // ReportsLab
            // 
            this.ReportsLab.AutoSize = true;
            this.ReportsLab.Location = new System.Drawing.Point(457, 406);
            this.ReportsLab.Name = "ReportsLab";
            this.ReportsLab.Size = new System.Drawing.Size(44, 13);
            this.ReportsLab.TabIndex = 16;
            this.ReportsLab.Text = "Reports";
            // 
            // extraReplabel
            // 
            this.extraReplabel.AutoSize = true;
            this.extraReplabel.Location = new System.Drawing.Point(302, 457);
            this.extraReplabel.Name = "extraReplabel";
            this.extraReplabel.Size = new System.Drawing.Size(104, 13);
            this.extraReplabel.TabIndex = 17;
            this.extraReplabel.Text = "(extra choose report)";
            // 
            // AppTypeBut
            // 
            this.AppTypeBut.Location = new System.Drawing.Point(460, 431);
            this.AppTypeBut.Name = "AppTypeBut";
            this.AppTypeBut.Size = new System.Drawing.Size(133, 23);
            this.AppTypeBut.TabIndex = 18;
            this.AppTypeBut.Text = "Appointment Count Type";
            this.AppTypeBut.UseVisualStyleBackColor = true;
            this.AppTypeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppTypeBut_MouseClick);
            // 
            // AppTypeCount
            // 
            this.AppTypeCount.AutoSize = true;
            this.AppTypeCount.Location = new System.Drawing.Point(433, 457);
            this.AppTypeCount.Name = "AppTypeCount";
            this.AppTypeCount.Size = new System.Drawing.Size(204, 13);
            this.AppTypeCount.TabIndex = 19;
            this.AppTypeCount.Text = "(required report: app type count by month)";
            // 
            // UserRepBut
            // 
            this.UserRepBut.Location = new System.Drawing.Point(652, 431);
            this.UserRepBut.Name = "UserRepBut";
            this.UserRepBut.Size = new System.Drawing.Size(94, 23);
            this.UserRepBut.TabIndex = 20;
            this.UserRepBut.Text = "User Schedule";
            this.UserRepBut.UseVisualStyleBackColor = true;
            this.UserRepBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserRepBut_MouseClick);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.UserRepBut);
            this.Controls.Add(this.AppTypeCount);
            this.Controls.Add(this.AppTypeBut);
            this.Controls.Add(this.extraReplabel);
            this.Controls.Add(this.ReportsLab);
            this.Controls.Add(this.AppointmentInfoGrid);
            this.Controls.Add(this.CustomerInfoGrid);
            this.Controls.Add(this.AppointementsLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AppRepBut);
            this.Controls.Add(this.CalendarViewBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.DeleteAppointmentsBut);
            this.Controls.Add(this.EditAppointmentsBut);
            this.Controls.Add(this.AppointmentsAddBut);
            this.Controls.Add(this.DeleteCustomerBut);
            this.Controls.Add(this.EditCustomerBut);
            this.Controls.Add(this.AddCustomerBut);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerBut;
        private System.Windows.Forms.Button EditCustomerBut;
        private System.Windows.Forms.Button DeleteCustomerBut;
        private System.Windows.Forms.Button AppointmentsAddBut;
        private System.Windows.Forms.Button EditAppointmentsBut;
        private System.Windows.Forms.Button DeleteAppointmentsBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button CalendarViewBut;
        private System.Windows.Forms.Button AppRepBut;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label AppointementsLabel;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private client_scheduleDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private client_scheduleDataSet1 client_scheduleDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private client_scheduleDataSet1TableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridView CustomerInfoGrid;
        private System.Windows.Forms.DataGridView AppointmentInfoGrid;
        private System.Windows.Forms.Label ReportsLab;
        private System.Windows.Forms.Label extraReplabel;
        private System.Windows.Forms.Button AppTypeBut;
        private System.Windows.Forms.Label AppTypeCount;
        private System.Windows.Forms.Button UserRepBut;
    }
}