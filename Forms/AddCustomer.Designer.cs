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
            this.AddressIdLabel = new System.Windows.Forms.Label();
            this.AddressIdBox = new System.Windows.Forms.TextBox();
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
            this.CustIDLabel.Location = new System.Drawing.Point(56, 65);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(62, 13);
            this.CustIDLabel.TabIndex = 2;
            this.CustIDLabel.Text = "CustomerID";
            // 
            // CustIDBox
            // 
            this.CustIDBox.Location = new System.Drawing.Point(124, 62);
            this.CustIDBox.Name = "CustIDBox";
            this.CustIDBox.Size = new System.Drawing.Size(100, 20);
            this.CustIDBox.TabIndex = 3;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Location = new System.Drawing.Point(59, 98);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(35, 13);
            this.CustNameLabel.TabIndex = 4;
            this.CustNameLabel.Text = "Name";
            // 
            // CustNameBox
            // 
            this.CustNameBox.Location = new System.Drawing.Point(124, 95);
            this.CustNameBox.Name = "CustNameBox";
            this.CustNameBox.Size = new System.Drawing.Size(100, 20);
            this.CustNameBox.TabIndex = 5;
            // 
            // AddressIdLabel
            // 
            this.AddressIdLabel.AutoSize = true;
            this.AddressIdLabel.Location = new System.Drawing.Point(56, 136);
            this.AddressIdLabel.Name = "AddressIdLabel";
            this.AddressIdLabel.Size = new System.Drawing.Size(57, 13);
            this.AddressIdLabel.TabIndex = 6;
            this.AddressIdLabel.Text = "Address Id";
            this.AddressIdLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddressIdBox
            // 
            this.AddressIdBox.Location = new System.Drawing.Point(124, 133);
            this.AddressIdBox.Name = "AddressIdBox";
            this.AddressIdBox.Size = new System.Drawing.Size(100, 20);
            this.AddressIdBox.TabIndex = 7;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 459);
            this.Controls.Add(this.AddressIdBox);
            this.Controls.Add(this.AddressIdLabel);
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
        private System.Windows.Forms.Label AddressIdLabel;
        private System.Windows.Forms.TextBox AddressIdBox;
    }
}