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
                int cityID = -1;
                int countryID = -1;
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

                custtable.Open();

                string countryQuery = "select countryId, country from country";
                MySqlCommand countryPull = new MySqlCommand(countryQuery, custtable);
                MySqlDataReader countryRead = countryPull.ExecuteReader();
                while (countryRead.Read())
                {
                    countrylist.Add(countryRead.GetString("country"));
                    countryIDlist.Add(countryRead.GetString("countryId"));

                }

                custtable.Close();

                custtable.Open();

                string cityQuery = "select cityId, city from city";
                MySqlCommand cityPull = new MySqlCommand(cityQuery, custtable);
                MySqlDataReader cityRead = cityPull.ExecuteReader();
                while (cityRead.Read())
                {
                    cityList.Add(cityRead.GetString("city"));
                    cityIdList.Add(cityRead.GetString("cityId"));

                }

                custtable.Close();
                //checks to see if new country

                for (int i=0; i <countrylist.Count; i++)
                {
                    if(countryBox.Text == countrylist[i])
                    {
                        countryID = Int32.Parse(countryIDlist[i]);
                    }

                }


                //creates new country if not found

                if(countryID ==-1)
                {
                    custtable.Open();
                    string countryCount = "Select Count(*) from country";
                    MySqlCommand countrycountQuery = new MySqlCommand(countryCount, custtable);
                    object getcountryCount = countrycountQuery.ExecuteScalar();
                    int z = Convert.ToInt32(getcountryCount.ToString());

                    countryID = z + 1;
                    custtable.Close();

                    custtable.Open();
                    string newCountry = $"Insert Into country VALUES('{countryID}','{countryBox.Text}','2013-09-09 00:00:00','test','2013-09-09 00:00:00','test')";
                    MySqlCommand addCountry = new MySqlCommand(newCountry, custtable);
                    addCountry.ExecuteNonQuery();
                    custtable.Close();
                }

                //checks to see if we need to create a new city record

                for (int i = 0; i < cityList.Count; i++)
                {
                    if (cityBox.Text == cityList[i])
                    {
                        cityID = Int32.Parse(cityIdList[i]);
                    }

                }

                //creates new city if not found

                if(cityID ==-1)
                {

                    custtable.Open();
                    string cityCount = "Select Count(*) from city";
                    MySqlCommand citycountQuery = new MySqlCommand(cityCount, custtable);
                    object getcityCount = citycountQuery.ExecuteScalar();
                    int m = Convert.ToInt32(getcityCount.ToString());

                    cityID = m + 1;
                    custtable.Close();

                    custtable.Open();
                    string newCity = $"Insert Into city VALUES('{cityID}','{cityBox.Text}','{countryID}','2013-09-09 00:00:00','test','2013-09-09 00:00:00','test')";
                    MySqlCommand addCity = new MySqlCommand(newCity, custtable);
                    addCity.ExecuteNonQuery();
                    custtable.Close();

                }

                //checks to see if we need to create a new address record noteeeee need to add city id into the new address

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
                    string addAddressQuery = $"Insert Into address VALUES('{adID}','{AddressBox.Text}','test','{cityID}','12345','{PhoneBox.Text}','2013-09-09 00:00:00','test','2013-09-09 00:00:00','test') ";
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
        List<string> cityIdList = new List<string>();
        List<string> cityList = new List<string>();
        List<string> countrylist = new List<string>();
        List<string> countryIDlist = new List<string>();
        
    }
}
