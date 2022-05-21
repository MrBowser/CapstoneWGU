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
    public partial class EditAppointment : Form
    {
        public EditAppointment()
        {
            InitializeComponent();
            //prepopulates the appointment data
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            string getappIDinfo = $"Select appointmentId, customerId, userId, type, start from appointment where appointmentId = {Appointment.editAppointmentId}";
            custtable.Open();

            MySqlCommand appIdInfo = new MySqlCommand(getappIDinfo, custtable);
            MySqlDataReader appinfo = appIdInfo.ExecuteReader();

            while (appinfo.Read())
            {
                custId = appinfo.GetString("customerId");
                appId = appinfo.GetString("appointmentId");
                userId = appinfo.GetString("userId");
                appType = appinfo.GetString("type");
                appointmentTime = DateTime.Parse(appinfo.GetString("start"));



            }

            custtable.Close();

            AppIDBox.Text = appId;
            CustomerIdBox.Text = custId;
            UserIdBox.Text = userId;
            TypeBox.Text = appType;

            //DateTime.Now.ToString("yyyy'-'MM'-'dd")

            DateBox.Text = appointmentTime.ToString("yyyy'-'MM'-'dd");
            TimeBox.Text = appointmentTime.ToString("HH:mm");

        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {

            int custIdDef = -1;
            int userId = -1;
            string x = Connection.connectstring;
            MySqlConnection AppTable = new MySqlConnection(x);

            //checks to see if the customer and user id exists and that it is within business hours

            AppTable.Open();
            string cusIDquery = "select customerId from customer";
            MySqlCommand cusIdqueryp2 = new MySqlCommand(cusIDquery, AppTable);
            MySqlDataReader cusIdqueryp3 = cusIdqueryp2.ExecuteReader();

            while (cusIdqueryp3.Read())
            {
                CusIds.Add(cusIdqueryp3.GetString("customerId"));
            }



            AppTable.Close();

            for (int i = 0; i < CusIds.Count; i++)
            {
                if (CustomerIdBox.Text == CusIds[i])
                {
                    custIdDef = int.Parse(CustomerIdBox.Text);
                    break;
                }


            }

            AppTable.Open();
            string userIDquery = "select userId from user";
            MySqlCommand userIDqueryp2 = new MySqlCommand(userIDquery, AppTable);
            MySqlDataReader userIDqueryp3 = userIDqueryp2.ExecuteReader();

            while (userIDqueryp3.Read())
            {
                UserIds.Add(userIDqueryp3.GetString("userId"));

            }

            AppTable.Close();

            for (int i = 0; i < UserIds.Count; i++)
            {
                if (UserIdBox.Text == UserIds[i])
                {
                    userId = int.Parse(UserIdBox.Text);
                    break;
                }
            }


            try
            {

                if (custIdDef == -1)
                {
                    throw new Exception("CustomerId Doesn't Exist, Please try a valid CustomerId ");
                }

                if (userId == -1)
                {
                    throw new Exception(" userId doesn't exist, please try a valid userId");
                }

                if (TypeBox.Text.Length < 1)
                {
                    throw new Exception("Type can't left blank");
                }

                DateTime test1 = DateTime.Parse(DateBox.Text);
                DateTime test2 = DateTime.Parse(TimeBox.Text);

                int hours = test2.Hour;

                if (hours < 9 || hours >= 17)
                {
                    throw new Exception("Please submit during business hours (9-17)");
                }

                //checks scheduling overlap
                
                string getappointmenttimes = $"select start from appointment where userId = {UserIdBox.Text}";
                AppTable.Open();
                MySqlCommand getappointmenttimesp2 = new MySqlCommand(getappointmenttimes, AppTable);
                MySqlDataReader getappointmenttimesp3 = getappointmenttimesp2.ExecuteReader();
                while (getappointmenttimesp3.Read())
                {
                    scheduletimes.Add(getappointmenttimesp3.GetString("start"));
                }
                AppTable.Close();

                for (int i = 0; i < scheduletimes.Count; i++)
                {
                    DateTime scheditem = DateTime.Parse(scheduletimes[i]);
                    string schedconv = $"{DateBox.Text} {TimeBox.Text}:00";
                    DateTime apptimeadd = DateTime.Parse(schedconv);

                    TimeSpan overlap = scheditem.Subtract(apptimeadd);
                    double numMinutes = overlap.TotalMinutes;

                    if (numMinutes < 60 && numMinutes > -60)
                    {
                        throw new Exception("This conflicts with another appointment please select a different time");
                    }

                }

                //submits the updated appointment data

                MySqlConnection custtable = new MySqlConnection(x);
                string updateApp = $"Update appointment SET customerId='{CustomerIdBox.Text}', userId='{UserIdBox.Text}', type= '{TypeBox.Text}', start ='{DateBox.Text} {TimeBox.Text}:00' Where appointmentId ={AppIDBox.Text}";
                custtable.Open();

                

                MySqlCommand updateApptName = new MySqlCommand(updateApp, custtable);

                updateApptName.ExecuteNonQuery();

                custtable.Close();

                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.Show();
                this.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void CancelBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        List<string> CusIds = new List<string>();
        List<string> UserIds = new List<string>();
        List<string> scheduletimes = new List<string>();

        string appId;
        string custId;
        string userId;
        string appType;
        DateTime appointmentTime;

    }
}
