namespace SoftwareTwoProject.Forms
{
    partial class EditAppointment
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
            this.AppIDLabel = new System.Windows.Forms.Label();
            this.AppIDBox = new System.Windows.Forms.TextBox();
            this.CustIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdBox = new System.Windows.Forms.TextBox();
            this.UsIdLabel = new System.Windows.Forms.Label();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateFormatLabel = new System.Windows.Forms.Label();
            this.TimeFormatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(212, 471);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(75, 23);
            this.SubmitBut.TabIndex = 0;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubmitBut_MouseClick);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(304, 471);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBut_MouseClick);
            // 
            // AppIDLabel
            // 
            this.AppIDLabel.AutoSize = true;
            this.AppIDLabel.Location = new System.Drawing.Point(49, 57);
            this.AppIDLabel.Name = "AppIDLabel";
            this.AppIDLabel.Size = new System.Drawing.Size(78, 13);
            this.AppIDLabel.TabIndex = 2;
            this.AppIDLabel.Text = "Appointment Id";
            // 
            // AppIDBox
            // 
            this.AppIDBox.Enabled = false;
            this.AppIDBox.Location = new System.Drawing.Point(145, 54);
            this.AppIDBox.Name = "AppIDBox";
            this.AppIDBox.Size = new System.Drawing.Size(100, 20);
            this.AppIDBox.TabIndex = 3;
            // 
            // CustIdLabel
            // 
            this.CustIdLabel.AutoSize = true;
            this.CustIdLabel.Location = new System.Drawing.Point(52, 104);
            this.CustIdLabel.Name = "CustIdLabel";
            this.CustIdLabel.Size = new System.Drawing.Size(63, 13);
            this.CustIdLabel.TabIndex = 4;
            this.CustIdLabel.Text = "Customer Id";
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.Location = new System.Drawing.Point(145, 101);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIdBox.TabIndex = 5;
            // 
            // UsIdLabel
            // 
            this.UsIdLabel.AutoSize = true;
            this.UsIdLabel.Location = new System.Drawing.Point(55, 153);
            this.UsIdLabel.Name = "UsIdLabel";
            this.UsIdLabel.Size = new System.Drawing.Size(41, 13);
            this.UsIdLabel.TabIndex = 6;
            this.UsIdLabel.Text = "User Id";
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(145, 150);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(100, 20);
            this.UserIdBox.TabIndex = 7;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(58, 194);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 8;
            this.TypeLabel.Text = "Type";
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(145, 194);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 9;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(66, 311);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(30, 13);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(145, 308);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 11;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(61, 253);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(145, 250);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 13;
            // 
            // DateFormatLabel
            // 
            this.DateFormatLabel.AutoSize = true;
            this.DateFormatLabel.Location = new System.Drawing.Point(128, 282);
            this.DateFormatLabel.Name = "DateFormatLabel";
            this.DateFormatLabel.Size = new System.Drawing.Size(139, 13);
            this.DateFormatLabel.TabIndex = 14;
            this.DateFormatLabel.Text = "Date Format: YYYY-MM-DD";
            // 
            // TimeFormatLabel
            // 
            this.TimeFormatLabel.AutoSize = true;
            this.TimeFormatLabel.Location = new System.Drawing.Point(128, 346);
            this.TimeFormatLabel.Name = "TimeFormatLabel";
            this.TimeFormatLabel.Size = new System.Drawing.Size(146, 13);
            this.TimeFormatLabel.TabIndex = 15;
            this.TimeFormatLabel.Text = "Time Format: HH:mm (military)";
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 515);
            this.Controls.Add(this.TimeFormatLabel);
            this.Controls.Add(this.DateFormatLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.UsIdLabel);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.CustIdLabel);
            this.Controls.Add(this.AppIDBox);
            this.Controls.Add(this.AppIDLabel);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.SubmitBut);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label AppIDLabel;
        private System.Windows.Forms.TextBox AppIDBox;
        private System.Windows.Forms.Label CustIdLabel;
        private System.Windows.Forms.TextBox CustomerIdBox;
        private System.Windows.Forms.Label UsIdLabel;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateFormatLabel;
        private System.Windows.Forms.Label TimeFormatLabel;
    }
}