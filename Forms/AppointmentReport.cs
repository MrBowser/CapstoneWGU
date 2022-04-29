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
    public partial class AppointmentReport : Form
    {
        public AppointmentReport()
        {
            InitializeComponent();

            //so what we should do is datagrid view appointment types as well as have a date picker...
            //create an if where if month and if whatever cell type string name of app, fill new table with the selected dates

            // DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") should be conversion to database

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();



            string appointmentsQuery = "select appointmentId, customerId, type, start" +
                " from appointment";

            //MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            //MySqlDataReader phoneRead = phonePull.ExecuteReader();
           



            


            custtable.Close();

        }

        private void MainDashBut_MouseClick(object sender, MouseEventArgs e)
        {

            MainDashboard maindash = new MainDashboard();
            maindash.Show();
            this.Close();

        }

        List<string> AppTypes = new List<string>();
    }
}
