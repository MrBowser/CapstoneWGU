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

            // needs to create a month value query based off of a date time picker
            // is what I need to do create a sql query?
            // type count where month value? select type, Count type and then a group by type after the where clause
        }

        private void DashBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard Main = new MainDashboard();
            Main.Show();
            this.Close();


        }

        private void ReportBut_MouseClick(object sender, MouseEventArgs e)
        {

            DateTime WeekCal = dateTimePicker1.Value;
            string MonthSQL = WeekCal.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            string MonthSQL2 = WeekCal.ToString("yyyy'-'MM'-'dd");

            MessageBox.Show(MonthSQL);

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();



            string AppCount = "select type, COUNT(type) as Type_Count" +
                $" from appointment where MONTH(DATE(start)) = MONTH('{MonthSQL2}') AND YEAR(DATE(start)) = YEAR('{MonthSQL2}') GROUP BY type";
            MySqlCommand SQLappointmentcol = new MySqlCommand(AppCount, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            AppTypeReport.DataSource = AppointmentTableInfo;



        }
    }
}
