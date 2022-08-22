namespace SoftwareTwoProject.Forms
{
    partial class EditCustomer
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
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CustomerBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLbael = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.CusType_Label = new System.Windows.Forms.Label();
            this.Cus_TypeBox = new System.Windows.Forms.TextBox();
            this.Size_Label = new System.Windows.Forms.Label();
            this.Size_Box = new System.Windows.Forms.TextBox();
            this.PLC_Logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(194, 439);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(75, 23);
            this.SubmitBut.TabIndex = 0;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubmitBut_MouseClick);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(287, 439);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBut_MouseClick);
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(58, 51);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(60, 13);
            this.CustomerIdLabel.TabIndex = 2;
            this.CustomerIdLabel.Text = "CustomerId";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 132);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(55, 174);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(58, 217);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            // 
            // CustomerBox
            // 
            this.CustomerBox.Enabled = false;
            this.CustomerBox.Location = new System.Drawing.Point(138, 51);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(138, 132);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 7;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(138, 174);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 8;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(138, 214);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 20);
            this.AddressBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(58, 293);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City";
            // 
            // countryLbael
            // 
            this.countryLbael.AutoSize = true;
            this.countryLbael.Location = new System.Drawing.Point(55, 352);
            this.countryLbael.Name = "countryLbael";
            this.countryLbael.Size = new System.Drawing.Size(43, 13);
            this.countryLbael.TabIndex = 11;
            this.countryLbael.Text = "Country";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(138, 290);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(100, 20);
            this.cityBox.TabIndex = 12;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(138, 352);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 20);
            this.countryBox.TabIndex = 13;
            // 
            // CusType_Label
            // 
            this.CusType_Label.AutoSize = true;
            this.CusType_Label.Location = new System.Drawing.Point(40, 85);
            this.CusType_Label.Name = "CusType_Label";
            this.CusType_Label.Size = new System.Drawing.Size(78, 13);
            this.CusType_Label.TabIndex = 14;
            this.CusType_Label.Text = "Customer Type";
            // 
            // Cus_TypeBox
            // 
            this.Cus_TypeBox.Enabled = false;
            this.Cus_TypeBox.Location = new System.Drawing.Point(138, 82);
            this.Cus_TypeBox.Name = "Cus_TypeBox";
            this.Cus_TypeBox.Size = new System.Drawing.Size(100, 20);
            this.Cus_TypeBox.TabIndex = 15;
            // 
            // Size_Label
            // 
            this.Size_Label.AutoSize = true;
            this.Size_Label.Location = new System.Drawing.Point(44, 397);
            this.Size_Label.Name = "Size_Label";
            this.Size_Label.Size = new System.Drawing.Size(74, 13);
            this.Size_Label.TabIndex = 16;
            this.Size_Label.Text = "Company Size";
            // 
            // Size_Box
            // 
            this.Size_Box.Location = new System.Drawing.Point(138, 397);
            this.Size_Box.Name = "Size_Box";
            this.Size_Box.Size = new System.Drawing.Size(100, 20);
            this.Size_Box.TabIndex = 17;
            // 
            // PLC_Logo
            // 
            this.PLC_Logo.AutoSize = true;
            this.PLC_Logo.Font = new System.Drawing.Font("Batang", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLC_Logo.Location = new System.Drawing.Point(22, 9);
            this.PLC_Logo.Name = "PLC_Logo";
            this.PLC_Logo.Size = new System.Drawing.Size(43, 19);
            this.PLC_Logo.TabIndex = 18;
            this.PLC_Logo.Text = "PLC";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(388, 485);
            this.Controls.Add(this.PLC_Logo);
            this.Controls.Add(this.Size_Box);
            this.Controls.Add(this.Size_Label);
            this.Controls.Add(this.Cus_TypeBox);
            this.Controls.Add(this.CusType_Label);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.countryLbael);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.SubmitBut);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CustomerBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLbael;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label CusType_Label;
        private System.Windows.Forms.TextBox Cus_TypeBox;
        private System.Windows.Forms.Label Size_Label;
        private System.Windows.Forms.TextBox Size_Box;
        private System.Windows.Forms.Label PLC_Logo;
    }
}