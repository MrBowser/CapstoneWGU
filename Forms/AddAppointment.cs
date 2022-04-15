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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);

            string getappointmentIDMAX = "Select Max(appointmentId) from appointment";
            custtable.Open();

            MySqlCommand AppointMaxQuery = new MySqlCommand(getappointmentIDMAX, custtable);
            object getCount = AppointMaxQuery.ExecuteScalar();
            int a = Convert.ToInt32(getCount.ToString());
            Appointment.AppointmentIdCounter = a + 1;

            ApIdBox.Text = $"{Appointment.AppointmentIdCounter}";

        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {
            //

            int AppId = Appointment.AppointmentIdCounter;
            Appointment.AppointmentIdCounter++;
            int custId = -1;
            int userId = -1;
            string x = Connection.connectstring;
            MySqlConnection AppTable = new MySqlConnection(x);

            //checks to see if the customer id exists otherwise error

            AppTable.Open();
            string cusIDquery = "select customerId from customer";
            MySqlCommand cusIdqueryp2 = new MySqlCommand(cusIDquery, AppTable);
            MySqlDataReader cusIdqueryp3 = cusIdqueryp2.ExecuteReader();

            while(cusIdqueryp3.Read())
            {
                CusIds.Add(cusIdqueryp3.GetString("customerId"));
            }

            //note incomplete need to check if text box is in list.

            AppTable.Close();

            for (int i = 0; i < CusIds.Count; i++)
            {
                if(CusIdBox.Text == CusIds[i])
                {
                    custId = int.Parse(CusIdBox.Text);
                }
                else
                {
                    //need to have custId = a max custID+1
                }

            }


            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        private void CancelBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        List<string> CusIds = new List<string>();
    }
}
