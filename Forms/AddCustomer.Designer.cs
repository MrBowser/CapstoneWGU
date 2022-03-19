namespace SoftwareTwoProject.Forms
{
    partial class AddCustomer
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
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CustIDBox = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.CustNameBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitBut
            // 
            this.SubmitBut.Location = new System.Drawing.Point(190, 413);
            this.SubmitBut.Name = "SubmitBut";
            this.SubmitBut.Size = new System.Drawing.Size(75, 23);
            this.SubmitBut.TabIndex = 0;
            this.SubmitBut.Text = "Submit";
            this.SubmitBut.UseVisualStyleBackColor = true;
            this.SubmitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SubmitBut_MouseClick);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(286, 413);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelBut_MouseClick);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(51, 48);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(62, 13);
            this.CustIDLabel.TabIndex = 2;
            this.CustIDLabel.Text = "CustomerID";
            // 
            // CustIDBox
            // 
            this.CustIDBox.Location = new System.Drawing.Point(124, 45);
            this.CustIDBox.Name = "CustIDBox";
            this.CustIDBox.Size = new System.Drawing.Size(100, 20);
            this.CustIDBox.TabIndex = 3;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Location = new System.Drawing.Point(56, 85);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CustNameLabel.TabIndex = 4;
            this.CustNameLabel.Text = "Name";
            // 
            // CustNameBox
            // 
            this.CustNameBox.Location = new System.Drawing.Point(124, 82);
            this.CustNameBox.Name = "CustNameBox";
            this.CustNameBox.Size = new System.Drawing.Size(100, 20);
            this.CustNameBox.TabIndex = 5;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(51, 128);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 8;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(124, 128);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 9;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(56, 169);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(124, 166);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 20);
            this.AddressBox.TabIndex = 11;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 459);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.CustNameBox);
            this.Controls.Add(this.CustNameLabel);
            this.Controls.Add(this.CustIDBox);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.SubmitBut);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CustIDBox;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.TextBox CustNameBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressBox;
    }
}