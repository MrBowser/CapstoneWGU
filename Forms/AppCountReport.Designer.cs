
namespace SoftwareTwoProject.Forms
{
    partial class AppCountReport
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
            this.DashBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashBut
            // 
            this.DashBut.Location = new System.Drawing.Point(683, 415);
            this.DashBut.Name = "DashBut";
            this.DashBut.Size = new System.Drawing.Size(75, 23);
            this.DashBut.TabIndex = 0;
            this.DashBut.Text = "Dashboard";
            this.DashBut.UseVisualStyleBackColor = true;
            this.DashBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DashBut_MouseClick);
            // 
            // AppCountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DashBut);
            this.Name = "AppCountReport";
            this.Text = "AppCountReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DashBut;
    }
}