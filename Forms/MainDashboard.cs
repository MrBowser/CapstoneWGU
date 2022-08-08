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

            // NOTE: This creates and fills the customer table with the needed columns
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();

            string CustJoinQuery = "select customerName, customerType, companysize, lotSize, billRate, customerId, address, phone, city, country" +
                " from customer t1 inner join address t2 on t1.addressId = t2.addressId" +
                " inner join city t3 on t3.cityId = t2.cityId" +
                " inner join country t4 on t4.countryId = t3.countryId";

            MySqlCommand runCusjoin = new MySqlCommand(CustJoinQuery, custtable);
            MySqlDataAdapter Cusprep = new MySqlDataAdapter(runCusjoin);
            DataTable CusTableInfo = new DataTable();
            Cusprep.Fill(CusTableInfo);
            CustomerInfoGrid.DataSource = CusTableInfo;

            custtable.Close();




            // NOTE: This creates and fills the appointments table with the needed columns from appointments

            custtable.Open();
            string appointmentsQuery = "select appointmentId, t2.customerId, type, start, userId, customerName" +
                " from customer t1 inner join appointment t2 on t1.customerId = t2.customerId";

            MySqlCommand SQLappointmentcol = new MySqlCommand(appointmentsQuery, custtable);
            MySqlDataAdapter appointprep = new MySqlDataAdapter(SQLappointmentcol);
            DataTable AppointmentTableInfo = new DataTable();
            appointprep.Fill(AppointmentTableInfo);
            AppointmentInfoGrid.DataSource = AppointmentTableInfo;


            // NOTE: this is the code for localization that fills the table with updated times for appointments based on timezone
            for (int i = 0; i < AppointmentInfoGrid.Rows.Count; i++)
            {
                AppointmentInfoGrid.Rows[i].Cells[3].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentInfoGrid.Rows[i].Cells[3].Value, TimeZoneInfo.Local).ToString();
                

            }



            //NOTE: this is the code required to setup 15 minute login alert. This has been changed to no longer be UserId specific.

            if(Appointment.AppAlertShown ==false)
            {
                for (int i = 0; i < AppointmentInfoGrid.Rows.Count; i++)
                {
                    //if (AppointmentInfoGrid.Rows[i].Cells[4].Value.ToString() == User.UserId)
                    //{

                        DateTime getcellval = (DateTime)AppointmentInfoGrid.Rows[i].Cells[3].Value;
                        DateTime gettimenow = DateTime.Now;

                        TimeSpan alert = getcellval.Subtract(gettimenow);


                        Double numMinutestillApp = alert.TotalMinutes;

                        if (numMinutestillApp <= 15 && numMinutestillApp >= 0)
                        {
                            MessageBox.Show($"You have an appointment in " + numMinutestillApp.ToString() + " minutes!");
                            Appointment.AppAlertShown = true;
                            break;
                        }

                    //}

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



            //MessageBox.Show(Convert.ToString(editId));

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
            
            this.appointmentTableAdapter.Fill(this.client_scheduleDataSet1.appointment);
            
            this.customerTableAdapter.Fill(this.client_scheduleDataSet.customer);

        }

        private void DeleteCustomerBut_MouseClick(object sender, MouseEventArgs e)
        {
            // this deletes the customer
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


            



        }

        private void DeleteAppointmentsBut_MouseClick(object sender, MouseEventArgs e)
        {
            //this deletes appointments
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

        private void UserRepBut_MouseClick(object sender, MouseEventArgs e)
        {
            UserScheduleReport userSchedule = new UserScheduleReport();
            userSchedule.Show();
            this.Close();
        }

        private void Customer_Search_But_MouseClick(object sender, MouseEventArgs e)
        {

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();

            string CustJoinQuery = "select customerName, customerType, companySize, lotSize, billRate, customerId, address, phone, city, country" +
                   " from customer t1 inner join address t2 on t1.addressId = t2.addressId" +
                   " inner join city t3 on t3.cityId = t2.cityId" +
                   " inner join country t4 on t4.countryId = t3.countryId" +
                   $" where customerName = '{Customer_Search.Text}' or customerId = '{Customer_Search.Text}' or " +
                   $" address = '{Customer_Search.Text}' or phone = '{Customer_Search.Text}' or " +
                   $" city = '{Customer_Search.Text}' or country = '{Customer_Search.Text}'";

            MySqlCommand runCusjoin = new MySqlCommand(CustJoinQuery, custtable);
            MySqlDataAdapter Cusprep = new MySqlDataAdapter(runCusjoin);
            DataTable CusTableInfo = new DataTable();
            Cusprep.Fill(CusTableInfo);
            CustomerInfoGrid.DataSource = CusTableInfo;

            custtable.Close();

            //in progress need to do a query that is a select all that matches the searchbox text. with that we then populate the table if not found table resets/
            int y = CustomerInfoGrid.Rows.Count;
            
            if(y==0)
            {

                custtable.Open();

                string CustJoinQuery1 = "select customerName, customerId, address, phone, city, country" +
                    " from customer t1 inner join address t2 on t1.addressId = t2.addressId" +
                    " inner join city t3 on t3.cityId = t2.cityId" +
                    " inner join country t4 on t4.countryId = t3.countryId";

                MySqlCommand runCusjoin1 = new MySqlCommand(CustJoinQuery1, custtable);
                MySqlDataAdapter Cusprep1 = new MySqlDataAdapter(runCusjoin1);
                DataTable CusTableInfo1 = new DataTable();
                Cusprep1.Fill(CusTableInfo1);
                CustomerInfoGrid.DataSource = CusTableInfo1;

                custtable.Close();

                MessageBox.Show("Customer Not Found, Showing Full Table");

            }
            else
            {

                

            }

        }
    }
}
