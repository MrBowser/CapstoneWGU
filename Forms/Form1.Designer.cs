namespace SoftwareTwoProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.LoginBut = new System.Windows.Forms.Button();
            this.PLC_logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // Passwordlabel
            // 
            resources.ApplyResources(this.Passwordlabel, "Passwordlabel");
            this.Passwordlabel.Name = "Passwordlabel";
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            // 
            // PWBox
            // 
            resources.ApplyResources(this.PWBox, "PWBox");
            this.PWBox.Name = "PWBox";
            // 
            // LoginBut
            // 
            resources.ApplyResources(this.LoginBut, "LoginBut");
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginBut_MouseClick);
            // 
            // PLC_logo
            // 
            resources.ApplyResources(this.PLC_logo, "PLC_logo");
            this.PLC_logo.Name = "PLC_logo";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.PLC_logo);
            this.Controls.Add(this.LoginBut);
            this.Controls.Add(this.PWBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Label PLC_logo;
    }
}

