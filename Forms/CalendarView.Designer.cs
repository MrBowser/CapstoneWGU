
namespace SoftwareTwoProject.Forms
{
    partial class CalendarView
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
            this.button1 = new System.Windows.Forms.Button();
            this.MonthBut = new System.Windows.Forms.RadioButton();
            this.WeeklyBut = new System.Windows.Forms.RadioButton();
            this.AppCalGrid = new System.Windows.Forms.DataGridView();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.allviewNoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppCalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Main Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthBut
            // 
            this.MonthBut.AutoSize = true;
            this.MonthBut.Location = new System.Drawing.Point(41, 379);
            this.MonthBut.Name = "MonthBut";
            this.MonthBut.Size = new System.Drawing.Size(62, 17);
            this.MonthBut.TabIndex = 2;
            this.MonthBut.Text = "Monthly";
            this.MonthBut.UseVisualStyleBackColor = true;
            // 
            // WeeklyBut
            // 
            this.WeeklyBut.AutoSize = true;
            this.WeeklyBut.Location = new System.Drawing.Point(142, 379);
            this.WeeklyBut.Name = "WeeklyBut";
            this.WeeklyBut.Size = new System.Drawing.Size(61, 17);
            this.WeeklyBut.TabIndex = 3;
            this.WeeklyBut.Text = "Weekly";
            this.WeeklyBut.UseVisualStyleBackColor = true;
            // 
            // AppCalGrid
            // 
            this.AppCalGrid.AllowUserToAddRows = false;
            this.AppCalGrid.AllowUserToDeleteRows = false;
            this.AppCalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppCalGrid.Location = new System.Drawing.Point(303, 72);
            this.AppCalGrid.Name = "AppCalGrid";
            this.AppCalGrid.Size = new System.Drawing.Size(435, 254);
            this.AppCalGrid.TabIndex = 4;
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(323, 346);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateBut.TabIndex = 5;
            this.UpdateBut.Text = "Update";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateBut_MouseClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(31, 189);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // allviewNoteLabel
            // 
            this.allviewNoteLabel.AutoSize = true;
            this.allviewNoteLabel.Location = new System.Drawing.Point(362, 38);
            this.allviewNoteLabel.Name = "allviewNoteLabel";
            this.allviewNoteLabel.Size = new System.Drawing.Size(287, 13);
            this.allviewNoteLabel.TabIndex = 7;
            this.allviewNoteLabel.Text = "Note: Before the table is updated all appointments will show";
            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allviewNoteLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.AppCalGrid);
            this.Controls.Add(this.WeeklyBut);
            this.Controls.Add(this.MonthBut);
            this.Controls.Add(this.button1);
            this.Name = "CalendarView";
            this.Text = "CalendarView";
            ((System.ComponentModel.ISupportInitialize)(this.AppCalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton MonthBut;
        private System.Windows.Forms.RadioButton WeeklyBut;
        private System.Windows.Forms.DataGridView AppCalGrid;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label allviewNoteLabel;
    }
}