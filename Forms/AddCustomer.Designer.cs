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
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 459);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.SubmitBut);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitBut;
        private System.Windows.Forms.Button CancelBut;
    }
}