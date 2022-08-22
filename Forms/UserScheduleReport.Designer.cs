
namespace SoftwareTwoProject.Forms
{
    partial class UserScheduleReport
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
            this.UserListGrid = new System.Windows.Forms.DataGridView();
            this.GenBut = new System.Windows.Forms.Button();
            this.UserSchedRepView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PLC_Logo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSchedRepView)).BeginInit();
            this.SuspendLayout();
            // 
            // DashBut
            // 
            this.DashBut.Location = new System.Drawing.Point(694, 410);
            this.DashBut.Name = "DashBut";
            this.DashBut.Size = new System.Drawing.Size(75, 23);
            this.DashBut.TabIndex = 0;
            this.DashBut.Text = "Dashboard";
            this.DashBut.UseVisualStyleBackColor = true;
            this.DashBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DashBut_MouseClick);
            // 
            // UserListGrid
            // 
            this.UserListGrid.AllowUserToAddRows = false;
            this.UserListGrid.AllowUserToDeleteRows = false;
            this.UserListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserListGrid.Location = new System.Drawing.Point(234, 42);
            this.UserListGrid.Name = "UserListGrid";
            this.UserListGrid.Size = new System.Drawing.Size(240, 150);
            this.UserListGrid.TabIndex = 1;
            // 
            // GenBut
            // 
            this.GenBut.Location = new System.Drawing.Point(299, 219);
            this.GenBut.Name = "GenBut";
            this.GenBut.Size = new System.Drawing.Size(125, 23);
            this.GenBut.TabIndex = 2;
            this.GenBut.Text = "Generate Schedule";
            this.GenBut.UseVisualStyleBackColor = true;
            this.GenBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GenBut_MouseClick);
            // 
            // UserSchedRepView
            // 
            this.UserSchedRepView.AllowUserToAddRows = false;
            this.UserSchedRepView.AllowUserToDeleteRows = false;
            this.UserSchedRepView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserSchedRepView.Location = new System.Drawing.Point(121, 268);
            this.UserSchedRepView.Name = "UserSchedRepView";
            this.UserSchedRepView.Size = new System.Drawing.Size(487, 150);
            this.UserSchedRepView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "(note: times are displayed in UTC)";
            // 
            // PLC_Logo
            // 
            this.PLC_Logo.AutoSize = true;
            this.PLC_Logo.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLC_Logo.Location = new System.Drawing.Point(26, 13);
            this.PLC_Logo.Name = "PLC_Logo";
            this.PLC_Logo.Size = new System.Drawing.Size(40, 19);
            this.PLC_Logo.TabIndex = 5;
            this.PLC_Logo.Text = "PLC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "To use this report select a user and\r\n then click generate schedule";
            // 
            // UserScheduleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PLC_Logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserSchedRepView);
            this.Controls.Add(this.GenBut);
            this.Controls.Add(this.UserListGrid);
            this.Controls.Add(this.DashBut);
            this.Name = "UserScheduleReport";
            this.Text = "UserScheduleReport";
            ((System.ComponentModel.ISupportInitialize)(this.UserListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserSchedRepView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DashBut;
        private System.Windows.Forms.DataGridView UserListGrid;
        private System.Windows.Forms.Button GenBut;
        private System.Windows.Forms.DataGridView UserSchedRepView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PLC_Logo;
        private System.Windows.Forms.Label label2;
    }
}