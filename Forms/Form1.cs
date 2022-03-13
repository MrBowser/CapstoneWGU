using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTwoProject.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SoftwareTwoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            user.Open();

            //MySqlConnection user = new MySqlConnection("server=127.0.0.1;user id=sqlUser;persistsecurityinfo=True;database=client_schedule");
        }

        private void LoginBut_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i  <5; i++)
            {
                //
            }

            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }
        MySqlConnection user = new MySqlConnection("server=127.0.0.1;user id=sqlUser;persistsecurityinfo=True;database=client_schedule");
        
    }
}
