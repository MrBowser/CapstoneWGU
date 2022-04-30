using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoftwareTwoProject.Class;
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class AppCountReport : Form
    {
        public AppCountReport()
        {
            InitializeComponent();
        }

        private void DashBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard Main = new MainDashboard();
            Main.Show();
            this.Close();


        }
    }
}
