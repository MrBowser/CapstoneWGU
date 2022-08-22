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
            this.AppTypeBut = new System.Windows.Forms.Button();
            this.UserRepBut = new System.Windows.Forms.Button();
            this.Customer_Search_But = new System.Windows.Forms.Button();
            this.Customer_Search = new System.Windows.Forms.TextBox();
            this.PLC_Name = new System.Windows.Forms.Label();
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
            this.CalendarViewBut.Location = new System.Drawing.Point(95, 431);
            this.CalendarViewBut.Name = "CalendarViewBut";
            this.CalendarViewBut.Size = new System.Drawing.Size(103, 23);
            this.CalendarViewBut.TabIndex = 9;
            this.CalendarViewBut.Text = "Calendar View";
            this.CalendarViewBut.UseVisualStyleBackColor = true;
            this.CalendarViewBut.Click += new System.EventHandler(this.CalendarViewBut_Click);
            // 
            // AppRepBut
            // 
            this.AppRepBut.Location = new System.Drawing.Point(245, 431);
            this.AppRepBut.Name = "AppRepBut";
            this.AppRepBut.Size = new System.Drawing.Size(180, 23);
            this.AppRepBut.TabIndex = 11;
            this.AppRepBut.Text = "Appointments By Month/Type";
            this.AppRepBut.UseVisualStyleBackColor = true;
            this.AppRepBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppRepBut_MouseClick);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(158, 51);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(94, 13);
            this.CustomerLabel.TabIndex = 12;
            this.CustomerLabel.Text = "Customer Records";
            // 
            // AppointementsLabel
            // 
            this.AppointementsLabel.AutoSize = true;
            this.AppointementsLabel.Location = new System.Drawing.Point(636, 51);
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
            this.CustomerInfoGrid.Size = new System.Drawing.Size(306, 150);
            this.CustomerInfoGrid.TabIndex = 14;
            // 
            // AppointmentInfoGrid
            // 
            this.AppointmentInfoGrid.AllowUserToAddRows = false;
            this.AppointmentInfoGrid.AllowUserToDeleteRows = false;
            this.AppointmentInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentInfoGrid.Location = new System.Drawing.Point(516, 81);
            this.AppointmentInfoGrid.Name = "AppointmentInfoGrid";
            this.AppointmentInfoGrid.Size = new System.Drawing.Size(294, 150);
            this.AppointmentInfoGrid.TabIndex = 15;
            // 
            // ReportsLab
            // 
            this.ReportsLab.AutoSize = true;
            this.ReportsLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLab.Location = new System.Drawing.Point(386, 397);
            this.ReportsLab.Name = "ReportsLab";
            this.ReportsLab.Size = new System.Drawing.Size(143, 20);
            this.ReportsLab.TabIndex = 16;
            this.ReportsLab.Text = "Reports and Views";
            // 
            // AppTypeBut
            // 
            this.AppTypeBut.Location = new System.Drawing.Point(477, 431);
            this.AppTypeBut.Name = "AppTypeBut";
            this.AppTypeBut.Size = new System.Drawing.Size(133, 23);
            this.AppTypeBut.TabIndex = 18;
            this.AppTypeBut.Text = "Appointment Count Type";
            this.AppTypeBut.UseVisualStyleBackColor = true;
            this.AppTypeBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppTypeBut_MouseClick);
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
            // Customer_Search_But
            // 
            this.Customer_Search_But.Location = new System.Drawing.Point(196, 20);
            this.Customer_Search_But.Name = "Customer_Search_But";
            this.Customer_Search_But.Size = new System.Drawing.Size(135, 23);
            this.Customer_Search_But.TabIndex = 22;
            this.Customer_Search_But.Text = "Customer Record Search";
            this.Customer_Search_But.UseVisualStyleBackColor = true;
            this.Customer_Search_But.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Customer_Search_But_MouseClick);
            // 
            // Customer_Search
            // 
            this.Customer_Search.Location = new System.Drawing.Point(70, 22);
            this.Customer_Search.Name = "Customer_Search";
            this.Customer_Search.Size = new System.Drawing.Size(100, 20);
            this.Customer_Search.TabIndex = 23;
            // 
            // PLC_Name
            // 
            this.PLC_Name.AutoSize = true;
            this.PLC_Name.Font = new System.Drawing.Font("Batang", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLC_Name.Location = new System.Drawing.Point(344, 43);
            this.PLC_Name.Name = "PLC_Name";
            this.PLC_Name.Size = new System.Drawing.Size(208, 21);
            this.PLC_Name.TabIndex = 24;
            this.PLC_Name.Text = "Puyallup Lawn Care";
            this.PLC_Name.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.PLC_Name);
            this.Controls.Add(this.Customer_Search);
            this.Controls.Add(this.Customer_Search_But);
            this.Controls.Add(this.UserRepBut);
            this.Controls.Add(this.AppTypeBut);
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
        private System.Windows.Forms.Button AppTypeBut;
        private System.Windows.Forms.Button UserRepBut;
        private System.Windows.Forms.Button Customer_Search_But;
        private System.Windows.Forms.TextBox Customer_Search;
        private System.Windows.Forms.Label PLC_Name;
    }
}