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

            // need to setup a database grid that lists the users to select
            //then when selected run report, it should be a Where userid the above to get the list

            // DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss") should be conversion to database

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();


            //this and the below 2 for loops will create the app Types to be selected from

            

            string userQuery = "select userId, userName from user";

            MySqlCommand SQLappointmentcol = new MySqlCommand(userQuery, custtable);
            MySqlDataReader userQuer = SQLappointmentcol.ExecuteReader();

            while (userQuer.Read())
            {
                IDlist.Add(userQuer.GetString("userId"));
                NameList.Add(userQuer.GetString("userName"));
            }

            custtable.Close();

            /* note may delete this as not needed
            for (int i = 0; i < Appointmentlist.Count; i++)
            {
                if (AppTypes.Contains(Appointmentlist[i]) == false)
                {
                    AppTypes.Add(Appointmentlist[i]);
                }

            }
            */


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

        }

        List<string> IDlist = new List<string>();
        List<string> NameList = new List<string>();
        //List<string> AppTypes = new List<string>();
    }
}
