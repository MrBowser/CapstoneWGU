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

            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            
            string getCustIDMAX = "Select Max(customerID) from customer";
            custtable.Open();

            MySqlCommand custCountQuery = new MySqlCommand (getCustIDMAX, custtable);
            object getCount = custCountQuery.ExecuteScalar();
            int a = Convert.ToInt32(getCount.ToString());
            Customer.customerIDNumber = a + 1;

            CustIDBox.Text = $"{Customer.customerIDNumber}";
            
            

            
            
        }

        private void CancelBut_MouseClick(object sender, MouseEventArgs e)
        {
            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Close();
        }

        private void SubmitBut_MouseClick(object sender, MouseEventArgs e)
        {
      

            try
            {

                //verifies phone correct format means num first 3 and last 4 digits and should be 8 total with a -
                /*
                if (PhoneBox.Text.Length != 8)
                {
                    throw new Exception("Phone not correct format please use nnn-nnnn");
                }
                */

                //lambda expression number 2 (other is used in the addappointment form) primary reason again is to reduce lines of code and improve readability
                string phonelengthcheck = PhoneBox.Text.Length == 8 ? "is correct" : throw new Exception("Phone not correct format please use nnn-nnnn, it is currently not eight characters");

                string phonetest = PhoneBox.Text.Remove(3, 1);

                if(int.TryParse(phonetest, out int tt) !=true)
                {
                    throw new Exception("Phone not correct format please use nnn-nnnn");

                }


                int custID = Customer.customerIDNumber;
                Customer.customerIDNumber++;
                int adID = -1;
                string x = Connection.connectstring;
                MySqlConnection custtable = new MySqlConnection(x);




                //checks to see if it should use an already existing addressId
                custtable.Open();
                string addIdQuery = "select addressId from address";
                MySqlCommand addIdPull = new MySqlCommand(addIdQuery, custtable);
                MySqlDataReader addIdRead = addIdPull.ExecuteReader();
                while (addIdRead.Read())
                {
                    addressIDlist.Add(addIdRead.GetString("addressId"));

                }


                custtable.Close();
                custtable.Open();
                string phoneQuery = "select phone from address";
                MySqlCommand phonePull = new MySqlCommand(phoneQuery, custtable);
                MySqlDataReader phoneRead = phonePull.ExecuteReader();
                while (phoneRead.Read())
                {
                    phonenumbers.Add(phoneRead.GetString("phone"));


                }

                custtable.Close();

                custtable.Open();

                string addressQuery = "select address from address";
                MySqlCommand addressPull = new MySqlCommand(addressQuery, custtable);
                MySqlDataReader addressRead = addressPull.ExecuteReader();
                while (addressRead.Read())
                {
                    addresses.Add(addressRead.GetString("address"));
                }

                custtable.Close();

                
                

                //checks to see if we need to create a new address record

                for (int i = 0; i < phonenumbers.Count; i++)
                {
                    if (PhoneBox.Text == phonenumbers[i] && AddressBox.Text == addresses[i])
                    {

                        adID = Int32.Parse(addressIDlist[i]);
                        break;
                    }

                }





                //creates new address record if not found

                if (adID == -1)
                {

                    custtable.Open();
                    string addressCount = "Select Count(*) from address";
                    MySqlCommand addressCountQuery = new MySqlCommand(addressCount, custtable);
                    object getAdCount = addressCountQuery.ExecuteScalar();
                    int b = Convert.ToInt32(getAdCount.ToString());

                    Address.addressIDcounter = b + 1;

                    adID = Address.addressIDcounter;
                    custtable.Close();

                    custtable.Open();
                    string addAddressQuery = $"Insert Into address VALUES('{adID}','{AddressBox.Text}','test','3','12345','{PhoneBox.Text}','2013-09-09 00:00:00', 'test','2013-09-09 00:00:00','test') ";
                    MySqlCommand addAddress = new MySqlCommand(addAddressQuery, custtable);
                    addAddress.ExecuteNonQuery();
                    custtable.Close();

                }




                //adds a new customer to the database

                Customer customer = new Customer(custID, CustNameBox.Text, adID);

                custtable.Open();
                string addCusQuery = $"Insert Into customer VALUES('{customer.customerID}','{customer.customerName}','{customer.addressId}','{customer.cusActive}','2013-09-09 00:00:00','{customer.createBy}','2013-09-09 00:00:00','{customer.lastUpBy}') ";
                MySqlCommand addCus = new MySqlCommand(addCusQuery, custtable);

                addCus.ExecuteNonQuery();
                custtable.Close();

                MainDashboard mainDashboard = new MainDashboard();
                mainDashboard.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            

        }

        List<string> phonenumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> addressIDlist = new List<string>();
        
    }
}
