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
            

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();


            //this gets a types list and populates the first selection datagrid

            string appointmentsQuery = "select type" +
                " from appointment";

            MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            MySqlDataReader appointpull = SQLappointmentcol.ExecuteReader();

            while(appointpull.Read())
            {
                Appointmentlist.Add(appointpull.GetString("type"));
            }

            custtable.Close();

            for (int i = 0; i < Appointmentlist.Count; i++)
            {
                if(AppTypes.Contains(Appointmentlist[i]) == false)
                {
                    AppTypes.Add(Appointmentlist[i]);
                }

            }


            AppTypeGrid.ColumnCount = 1;
            AppTypeGrid.Columns[0].Name = "Appointment Type";

            for (int i = 0; i < AppTypes.Count; i++)
            {
                var row = new DataGridViewRow();
                AppTypeGrid.Rows.Add(row);
                AppTypeGrid.Rows[i].Cells[0].Value = AppTypes[i];

            }
            
          
           



            


            custtable.Close();

        }

        private void MainDashBut_MouseClick(object sender, MouseEventArgs e)
        {

            MainDashboard maindash = new MainDashboard();
            maindash.Show();
            this.Close();

        }
        List<string> Appointmentlist = new List<string>();
        List<string> AppTypes = new List<string>();

        private void ReportBut_MouseClick(object sender, MouseEventArgs e)
        {
            //populates the report based on selected date and row from the first datagrid

            DateTime WeekCal = dateTimePicker1.Value;
            string MonthSQL = WeekCal.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            string MonthSQL2 = WeekCal.ToString("yyyy'-'MM'-'dd");

            MessageBox.Show(MonthSQL);

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();



            string weeksQuery = "select appointmentId, customerId, type, start" +
                $" from appointment where MONTH(DATE(start)) = MONTH('{MonthSQL2}') AND YEAR(DATE(start)) = YEAR('{MonthSQL2}')";

            MySqlCommand SQLappointmentcol = new MySqlCommand(weeksQuery, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            ReportView.DataSource = AppointmentTableInfo;
            
            if(ReportView.Rows.Count>0)
            {
                string type1 = AppTypeGrid.SelectedRows[0].Cells[0].Value.ToString();
                
                for (int i = ReportView.Rows.Count; i > 0; i--)
                {
                    if (ReportView.Rows[i-1].Cells[2].Value.ToString() != type1)
                    {
                        ReportView.Rows.RemoveAt(i-1);
                    }

                }

            }
            
            


        }
    }
}
