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
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CancelBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {

            int custID = 55;
            int adID = 33;



            Customer customer = new Customer(custID,CustNameBox.Text,adID);

            string addCusQuery = $"Insert Into customer VALUES('{customer.customerID}','{customer.customerName}','{customer.addressId}','{customer.cusActive}','{customer.createDate}','{customer.createBy}','{customer.lastUpdate}','{customer.lastUpBy}') ";

            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();

        }
    }
}
