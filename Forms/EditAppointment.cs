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

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            string getappIDinfo = $"Select appointmentId, customerId, userId, type from appointment where appointmentId = {Appointment.editAppointmentId}";
            custtable.Open();

            MySqlCommand appIdInfo = new MySqlCommand(getappIDinfo, custtable);
            MySqlDataReader appinfo = appIdInfo.ExecuteReader();

            while (appinfo.Read())
            {
                custId = appinfo.GetString("customerId");
                appId = appinfo.GetString("appointmentId");
                userId = appinfo.GetString("userId");
                appType = appinfo.GetString("type");



            }

            custtable.Close();

            AppIDBox.Text = appId;
            CustomerIdBox.Text = custId;
            UserIdBox.Text = userId;
            TypeBox.Text = appType;

        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {
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

        string appId;
        string custId;
        string userId;
        string appType;

    }
}
