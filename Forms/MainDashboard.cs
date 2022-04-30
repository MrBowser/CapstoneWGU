using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTwoProject.Forms;
using SoftwareTwoProject.Class;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();

            // NOTE: This creates and fills the customer table with the needed columns from bother customer and address
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();

            string CustJoinQuery = "select customerName, customerId, address, phone" +
                " from customer t1 inner join address t2 on t1.addressId = t2.addressId " ;

            MySqlCommand runCusjoin = new MySqlCommand(CustJoinQuery, custtable);
            MySqlDataAdapter Cusprep = new MySqlDataAdapter(runCusjoin);
            DataTable CusTableInfo = new DataTable();
            Cusprep.Fill(CusTableInfo);
            CustomerInfoGrid.DataSource = CusTableInfo;

            custtable.Close();




            // NOTE: This creates and fills the appointments table with the needed columns from appointments

            custtable.Open();
            string appointmentsQuery = "select appointmentId, customerId, type, start, userId" +
                " from appointment";

            MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            AppointmentInfoGrid.DataSource = AppointmentTableInfo;


            // note below should work for localization
            for (int i = 0; i < AppointmentInfoGrid.Rows.Count; i++)
            {
                AppointmentInfoGrid.Rows[i].Cells[3].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentInfoGrid.Rows[i].Cells[3].Value, TimeZoneInfo.Local).ToString(); ;

            }



            //note below need to figure out alerts and notifications based on time
            //run a for loop to get list of userID appointments ... substract? 

            if(Appointment.AppAlertShown ==false)
            {
                for (int i = 0; i < AppointmentInfoGrid.Rows.Count; i++)
                {
                    if (AppointmentInfoGrid.Rows[i].Cells[4].Value.ToString() == User.UserId)
                    {

                        DateTime getcellval = (DateTime)AppointmentInfoGrid.Rows[i].Cells[3].Value;
                        DateTime gettimenow = DateTime.Now;

                        TimeSpan alert = getcellval.Subtract(gettimenow);


                        Double numMinutestillApp = alert.TotalMinutes;

                        if (numMinutestillApp < 15 && numMinutestillApp > 0)
                        {
                            MessageBox.Show($"You have an appointment in " + numMinutestillApp.ToString() + " minutes!");
                            Appointment.AppAlertShown = true;
                            break;

                        }




                    }

                }

            }
            


        }

        private void ExitBut_MouseClick(object sender, MouseEventArgs e)
        {
           Application.Exit();
        }

        private void AddCustomerBut_MouseClick(object sender, MouseEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show(); 
            this.Close();
        }

        private void EditCustomerBut_MouseClick(object sender, MouseEventArgs e)
        {

             int selectedRowIndex = CustomerInfoGrid.CurrentCell.RowIndex;

            

            DataGridViewRow selectedRow = CustomerInfoGrid.Rows[selectedRowIndex];

            string editId = Convert.ToString(selectedRow.Cells[1].Value);



            MessageBox.Show(Convert.ToString(editId));

            Customer.editcustomerID = editId;


            
            EditCustomer editCustomer = new EditCustomer();
            editCustomer.Show();
            this.Close();
        }

        private void AppointmentsAddBut_MouseClick(object sender, MouseEventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
            this.Close();
        }

        private void EditAppointmentsBut_MouseClick(object sender, MouseEventArgs e)
        {

            int selectedRowIndex = AppointmentInfoGrid.CurrentCell.RowIndex;



            DataGridViewRow selectedRow = AppointmentInfoGrid.Rows[selectedRowIndex];

            string editId = Convert.ToString(selectedRow.Cells[0].Value);



            MessageBox.Show(Convert.ToString(editId));

            Appointment.editAppointmentId = editId;


            EditAppointment editAppointment = new EditAppointment();
            editAppointment.Show();
            this.Close();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_scheduleDataSet1.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.client_scheduleDataSet1.appointment);
            // TODO: This line of code loads data into the 'client_scheduleDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.client_scheduleDataSet.customer);

        }

        private void DeleteCustomerBut_MouseClick(object sender, MouseEventArgs e)
        {

            int selectedRowIndex = CustomerInfoGrid.CurrentCell.RowIndex;



            DataGridViewRow selectedRow = CustomerInfoGrid.Rows[selectedRowIndex];

            string editId = Convert.ToString(selectedRow.Cells[1].Value);

            MessageBox.Show(Convert.ToString(editId));

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();

            string appointdel = $"delete from appointment where customerId = {editId} ";

            MySqlCommand sqlappointdel = new MySqlCommand(appointdel, custtable);

            sqlappointdel.ExecuteNonQuery();

            custtable.Close();

            custtable.Open();

            string custdel = $"delete from customer where customerId = {editId}";
            MySqlCommand sqlcustdel = new MySqlCommand(custdel, custtable);
            sqlcustdel.ExecuteNonQuery();

            custtable.Close();

            string CustJoinQuery = "select customerName, customerId, address, phone" +
               " from customer t1 inner join address t2 on t1.addressId = t2.addressId ";

            custtable.Open();

            MySqlCommand runCusjoin = new MySqlCommand(CustJoinQuery, custtable);
            MySqlDataAdapter Cusprep = new MySqlDataAdapter(runCusjoin);
            DataTable CusTableInfo = new DataTable();
            Cusprep.Fill(CusTableInfo);
            CustomerInfoGrid.DataSource = CusTableInfo;

            custtable.Close();


            //delete from appointments where customerId = editID;
            // delete from customer where customerID = editID



        }

        private void DeleteAppointmentsBut_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedRowIndex = AppointmentInfoGrid.CurrentCell.RowIndex;



            DataGridViewRow selectedRow = AppointmentInfoGrid.Rows[selectedRowIndex];

            string editId = Convert.ToString(selectedRow.Cells[0].Value);

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();

            string appointdel = $"delete from appointment where appointmentId = {editId} ";

            MySqlCommand sqlappointdel = new MySqlCommand(appointdel, custtable);

            sqlappointdel.ExecuteNonQuery();

            custtable.Close();

            custtable.Open();
            string appointmentsQuery = "select appointmentId, customerId, type, start" +
                " from appointment";

            MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            AppointmentInfoGrid.DataSource = AppointmentTableInfo;

            custtable.Close();
        }

        private void CalendarViewBut_Click(object sender, EventArgs e)
        {
            CalendarView calview = new CalendarView();
            calview.Show();
            this.Close();

        }

        private void AppRepBut_MouseClick(object sender, MouseEventArgs e)
        {
            AppointmentReport Appview = new AppointmentReport();
            Appview.Show();
            this.Close();
        }

        private void AppTypeBut_MouseClick(object sender, MouseEventArgs e)
        {
            AppCountReport Appcountview = new AppCountReport();
            Appcountview.Show();
            this.Close();
        }
    }
}
