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
    public partial class UserScheduleReport : Form
    {
        public UserScheduleReport()
        {
            InitializeComponent();

            

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();


            //this will create the list of users to select

            

            string userQuery = "select userId, userName from user";

            MySqlCommand SQLappointmentcol = new MySqlCommand(userQuery, custtable);
            MySqlDataReader userQuer = SQLappointmentcol.ExecuteReader();

            while (userQuer.Read())
            {
                IDlist.Add(userQuer.GetString("userId"));
                NameList.Add(userQuer.GetString("userName"));
            }

            custtable.Close();

          


            UserListGrid.ColumnCount = 2;
            UserListGrid.Columns[0].Name = "User ID";
            UserListGrid.Columns[1].Name = "Name";

            for (int i = 0; i < IDlist.Count; i++)
            {
                var row = new DataGridViewRow();
                UserListGrid.Rows.Add(row);
                UserListGrid.Rows[i].Cells[0].Value = IDlist[i];
                UserListGrid.Rows[i].Cells[1].Value = NameList[i];

            }
        }

        private void DashBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();

        }

        private void GenBut_MouseClick(object sender, MouseEventArgs e)
        {

            //this generates the consultant's schedule

            
            try
            {
                string x = Connection.connectstring;
                MySqlConnection custtable = new MySqlConnection(x);
                custtable.Open();
                string userId = UserListGrid.SelectedRows[0].Cells[0].Value.ToString();

                string UserQuery = "select appointmentId, customerId, type, start" +
                $" from appointment where userID = '{UserListGrid.SelectedRows[0].Cells[0].Value}'";

                MySqlCommand SQLappointmentcol = new MySqlCommand(UserQuery, custtable);
                MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
                DataTable AppointmentTableInfo = new DataTable();
                appointprep.Fill(AppointmentTableInfo);
                UserSchedRepView.DataSource = AppointmentTableInfo;

                custtable.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Please select a user before running the report");
            }


            

        }

        List<string> IDlist = new List<string>();
        List<string> NameList = new List<string>();
        
    }
}
