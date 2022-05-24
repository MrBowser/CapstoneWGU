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
            //gets appointment ID
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);

            string getappointmentIDMAX = "Select Max(appointmentId) from appointment";
            custtable.Open();

            MySqlCommand AppointMaxQuery = new MySqlCommand(getappointmentIDMAX, custtable);
            object getCount = AppointMaxQuery.ExecuteScalar();
            int a = Convert.ToInt32(getCount.ToString());
            Appointment.AppointmentIdCounter = a + 1;

            ApIdBox.Text = $"{Appointment.AppointmentIdCounter}";

            custtable.Close();

          




        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {
            

            int AppId = Appointment.AppointmentIdCounter;
            Appointment.AppointmentIdCounter++;
            int custIdDef = -1;
            int userId = -1;
            string x = Connection.connectstring;
            MySqlConnection AppTable = new MySqlConnection(x);

            //checks to see if the customer id and user id exists 

            AppTable.Open();
            string cusIDquery = "select customerId from customer";
            MySqlCommand cusIdqueryp2 = new MySqlCommand(cusIDquery, AppTable);
            MySqlDataReader cusIdqueryp3 = cusIdqueryp2.ExecuteReader();

            while(cusIdqueryp3.Read())
            {
                CusIds.Add(cusIdqueryp3.GetString("customerId"));
            }

            

            AppTable.Close();

            for (int i = 0; i < CusIds.Count; i++)
            {
                if(CusIdBox.Text == CusIds[i])
                {
                    custIdDef = int.Parse(CusIdBox.Text);
                    break;
                }


            }

            AppTable.Open();
            string userIDquery = "select userId from user";
            MySqlCommand userIDqueryp2 = new MySqlCommand(userIDquery, AppTable);
            MySqlDataReader userIDqueryp3 = userIDqueryp2.ExecuteReader();

            while(userIDqueryp3.Read())
            {
                UserIds.Add(userIDqueryp3.GetString("userId"));

            }

            AppTable.Close();

            for (int i = 0; i < UserIds.Count;i++)
            {
                if(UsIdBox.Text == UserIds[i])
                {
                    userId = int.Parse(UsIdBox.Text);
                    break;
                }
            }





            try
            {

                DateTime ConvertUtcTime = TimeZoneInfo.ConvertTimeToUtc((DateTime)DateTime.Parse($"{HourBox.Text}:{MinutesBox.Text}"), TimeZoneInfo.Local);
                DateTime ConvertUtcBox = TimeZoneInfo.ConvertTimeToUtc((DateTime)DateTime.Parse(DateBox.Text), TimeZoneInfo.Local);

                DateTime CombineUTCConv = TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse($"{DateBox.Text} {HourBox.Text}: {MinutesBox.Text} :00"), TimeZoneInfo.Local);


                //checks that the customer id exists, userid exists, and that the correct date format, business hours and overlap criteria are met
                if (custIdDef == -1)
                {
                    throw new Exception("CustomerId Doesn't Exist, Please try a valid CustomerId ");
                }

                if (userId == -1)
                {
                    throw new Exception(" userId doesn't exist, please try a valid userId");
                }

                if (TypeBox.Text.Length<1)
                {
                    throw new Exception("Type can't left blank");
                }


                DateTime test2 = ConvertUtcTime;

                int hours = test2.Hour;

                if (hours < 9 || hours >= 17)
                {
                    throw new Exception("Please submit during business hours (9-17 UTC)");
                }

                DateTime test = DateTime.Parse(DateBox.Text);

                /* This is legacy code, keeping for reference
                if(int.Parse(HourBox.Text) <9 || int.Parse(HourBox.Text)>=17 )
                {
                    throw new Exception("Please submit during business hours (9-17)");
                }
                */

                //checks scheduling overlap
                
                string getappointmenttimes = $"select start from appointment where userId = {UsIdBox.Text}";
                AppTable.Open();
                MySqlCommand getappointmenttimesp2 = new MySqlCommand(getappointmenttimes, AppTable);
                MySqlDataReader getappointmenttimesp3 = getappointmenttimesp2.ExecuteReader();
                while(getappointmenttimesp3.Read())
                {
                    scheduletimes.Add(getappointmenttimesp3.GetString("start"));
                }
                AppTable.Close();

                for (int i = 0; i < scheduletimes.Count; i++)
                {
                    
                    DateTime scheditem = DateTime.Parse(scheduletimes[i]);
                    /* Legacy code, keeping for reference
                    string schedconv = $"{DateBox.Text} {HourBox.Text}:{MinutesBox.Text}:00";
                    DateTime apptimeadd = DateTime.Parse(schedconv);
                    */

                    TimeSpan overlap = scheditem.Subtract(CombineUTCConv);
                    double numMinutes = overlap.TotalMinutes;
                    



                    //below is lambda #1 here the primary reason was to reduce lines of code from the if statement and increase readability.

                    AppOverlap appOverlap = () => numMinutes >= 60 || numMinutes <= -60 ? true : throw new Exception("This conflicts with another appointment please select a different time");
                    appOverlap();
                       
                }

                //creates the appointment in the database
                string StringUTCConvert = CombineUTCConv.ToString("yyyy'-'MM'-'dd' 'HH:mm:ss ");

                string addAppointmentQuery = $"insert into appointment VALUES ('{ApIdBox.Text}','{CusIdBox.Text}','{UsIdBox.Text}','not needed','not needed','not needed','not needed','{TypeBox.Text}','not needed','{StringUTCConvert}','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')";
                AppTable.Open();
                MySqlCommand addAppointmentCom = new MySqlCommand(addAppointmentQuery, AppTable);
                addAppointmentCom.ExecuteNonQuery();

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
        int custIdDef = -1;

        delegate bool AppOverlap();
    }
}
