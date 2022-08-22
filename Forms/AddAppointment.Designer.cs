namespace SoftwareTwoProject.Forms
{
    partial class AddAppointment
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
            this.SubmitBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.AppointmentIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeLabel = new System.Windows.Forms.Label();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.ApIdBox = new System.Windows.Forms.TextBox();
            this.CusIdBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UsIdBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.DayTimeLabel = new System.Windows.Forms.Label();
            this.Colon = new System.Windows.Forms.Label();
            this.MinutesBox = new System.Windows.Forms.TextBox();
            this.DateLabelDirect = new System.Windows.Forms.Label();
            this.TimeLabelFormat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(188, 391);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(75, 23);
            this.SubmitBut.TabIndex = 0;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubmitBut_MouseClick);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(283, 391);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBut_MouseClick);
            // 
            // AppointmentIdLabel
            // 
            this.AppointmentIdLabel.AutoSize = true;
            this.AppointmentIdLabel.Location = new System.Drawing.Point(48, 50);
            this.AppointmentIdLabel.Name = "AppointmentIdLabel";
            this.AppointmentIdLabel.Size = new System.Drawing.Size(75, 13);
            this.AppointmentIdLabel.TabIndex = 2;
            this.AppointmentIdLabel.Text = "AppointmentId";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(48, 100);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(60, 13);
            this.CustomerIdLabel.TabIndex = 3;
            this.CustomerIdLabel.Text = "CustomerId";
            // 
            // AppointmentTypeLabel
            // 
            this.AppointmentTypeLabel.AutoSize = true;
            this.AppointmentTypeLabel.Location = new System.Drawing.Point(58, 229);
            this.AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            this.AppointmentTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.AppointmentTypeLabel.TabIndex = 4;
            this.AppointmentTypeLabel.Text = "Type";
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Location = new System.Drawing.Point(59, 279);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(30, 13);
            this.AppointmentDateLabel.TabIndex = 5;
            this.AppointmentDateLabel.Text = "Date";
            // 
            // ApIdBox
            // 
            this.ApIdBox.Enabled = false;
            this.ApIdBox.Location = new System.Drawing.Point(144, 50);
            this.ApIdBox.Name = "ApIdBox";
            this.ApIdBox.Size = new System.Drawing.Size(100, 20);
            this.ApIdBox.TabIndex = 6;
            // 
            // CusIdBox
            // 
            this.CusIdBox.Location = new System.Drawing.Point(144, 100);
            this.CusIdBox.Name = "CusIdBox";
            this.CusIdBox.Size = new System.Drawing.Size(100, 20);
            this.CusIdBox.TabIndex = 7;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(144, 222);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 8;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(144, 276);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 9;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(58, 156);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(38, 13);
            this.UserIdLabel.TabIndex = 10;
            this.UserIdLabel.Text = "UserId";
            // 
            // UsIdBox
            // 
            this.UsIdBox.Location = new System.Drawing.Point(144, 153);
            this.UsIdBox.Name = "UsIdBox";
            this.UsIdBox.Size = new System.Drawing.Size(100, 20);
            this.UsIdBox.TabIndex = 11;
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(144, 321);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(34, 20);
            this.HourBox.TabIndex = 12;
            this.HourBox.Text = "00";
            // 
            // DayTimeLabel
            // 
            this.DayTimeLabel.AutoSize = true;
            this.DayTimeLabel.Location = new System.Drawing.Point(48, 324);
            this.DayTimeLabel.Name = "DayTimeLabel";
            this.DayTimeLabel.Size = new System.Drawing.Size(64, 13);
            this.DayTimeLabel.TabIndex = 13;
            this.DayTimeLabel.Text = "Time of Day";
            // 
            // Colon
            // 
            this.Colon.AutoSize = true;
            this.Colon.Location = new System.Drawing.Point(185, 324);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(10, 13);
            this.Colon.TabIndex = 14;
            this.Colon.Text = ":";
            // 
            // MinutesBox
            // 
            this.MinutesBox.Location = new System.Drawing.Point(201, 321);
            this.MinutesBox.Name = "MinutesBox";
            this.MinutesBox.Size = new System.Drawing.Size(31, 20);
            this.MinutesBox.TabIndex = 15;
            this.MinutesBox.Text = "00";
            // 
            // DateLabelDirect
            // 
            this.DateLabelDirect.AutoSize = true;
            this.DateLabelDirect.Location = new System.Drawing.Point(124, 299);
            this.DateLabelDirect.Name = "DateLabelDirect";
            this.DateLabelDirect.Size = new System.Drawing.Size(139, 13);
            this.DateLabelDirect.TabIndex = 16;
            this.DateLabelDirect.Text = "Date Format: YYYY-MM-DD";
            // 
            // TimeLabelFormat
            // 
            this.TimeLabelFormat.AutoSize = true;
            this.TimeLabelFormat.Location = new System.Drawing.Point(124, 354);
            this.TimeLabelFormat.Name = "TimeLabelFormat";
            this.TimeLabelFormat.Size = new System.Drawing.Size(154, 13);
            this.TimeLabelFormat.TabIndex = 17;
            this.TimeLabelFormat.Text = "Time Format: HH : MM (military)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLC";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(370, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabelFormat);
            this.Controls.Add(this.DateLabelDirect);
            this.Controls.Add(this.MinutesBox);
            this.Controls.Add(this.Colon);
            this.Controls.Add(this.DayTimeLabel);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.UsIdBox);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CusIdBox);
            this.Controls.Add(this.ApIdBox);
            this.Controls.Add(this.AppointmentDateLabel);
            this.Controls.Add(this.AppointmentTypeLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.AppointmentIdLabel);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.SubmitBut);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label AppointmentIdLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label AppointmentTypeLabel;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private System.Windows.Forms.TextBox ApIdBox;
        private System.Windows.Forms.TextBox CusIdBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.TextBox UsIdBox;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.Label DayTimeLabel;
        private System.Windows.Forms.Label Colon;
        private System.Windows.Forms.TextBox MinutesBox;
        private System.Windows.Forms.Label DateLabelDirect;
        private System.Windows.Forms.Label TimeLabelFormat;
        private System.Windows.Forms.Label label1;
    }
}