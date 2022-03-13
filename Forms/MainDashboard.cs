using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTwoProject.Forms;
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
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

        }
    }
}
