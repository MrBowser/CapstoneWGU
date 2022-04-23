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

            custtable.Close();

           /* string custIdMax = "Select Max(customerId) from customer";
            custtable.Open();

            MySqlCommand custMaxQuery = new MySqlCommand(custIdMax, custtable);
            object getCustMax = custMaxQuery.ExecuteScalar();
            int b = Convert.ToInt32(getCustMax.ToString());
            custIdDef = b;

            custtable.Close();

            */




        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {
            //

            int AppId = Appointment.AppointmentIdCounter;
            Appointment.AppointmentIdCounter++;
            
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
                if (custIdDef == -1)
                {
                    throw new Exception("CustomerId Doesn't Exist, Please try a valid CustomerId ");
                }

                if (userId == -1)
                {
                    throw new Exception(" userId doesn't exist, please try a valid userId");
                }

                string addAppointmentQuery = $"insert into appointment VALUES ('{ApIdBox.Text}','{CusIdBox.Text}','{UsIdBox.Text}','not needed','not needed','not needed','not needed','{TypeBox.Text}','not needed','{DateBox.Text} {HourBox.Text}:{MinutesBox.Text}:00','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')";
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

            //note need to remember to potential do something with scheduling and need to put error handing in for time

            
            




            
        }

        private void CancelBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        List<string> CusIds = new List<string>();
        List<string> UserIds = new List<string>();
        int custIdDef = -1;
    }
}
