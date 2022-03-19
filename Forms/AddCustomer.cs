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
            int adID = 1;
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            custtable.Open();



            Customer customer = new Customer(custID,CustNameBox.Text,adID);

            string addCusQuery = $"Insert Into customer VALUES('{customer.customerID}','{customer.customerName}','{customer.addressId}','{customer.cusActive}','2013-09-09 00:00:00','{customer.createBy}','2013-09-09 00:00:00','{customer.lastUpBy}') ";
            MySqlCommand addCus = new MySqlCommand(addCusQuery, custtable);

            addCus.ExecuteNonQuery();
            custtable.Close();

            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();

        }
    }
}
