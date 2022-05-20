using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTwoProject.Class;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SoftwareTwoProject.Forms
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();

            //populates the basic customer record info
            string x = Connection.connectstring;
            MySqlConnection custtable = new MySqlConnection(x);
            string getCustIDinfo = $"Select customerName, customerId, address, phone, cityId from customer t1 inner join address t2 on t1.addressId = t2.addressId where customerId = {Customer.editcustomerID}";
            custtable.Open();

            MySqlCommand custIdInfo = new MySqlCommand(getCustIDinfo, custtable);
            MySqlDataReader custinfo = custIdInfo.ExecuteReader();

            while (custinfo.Read())
            {
                custId = custinfo.GetString("customerId");
                custName = custinfo.GetString("customerName");
                Phone = custinfo.GetString("phone");
                AddressE = custinfo.GetString("address");
                cityId = custinfo.GetString("cityId");
                              
            }

            custtable.Close();

            CustomerBox.Text = custId;
            NameBox.Text = custName;
            AddressBox.Text = AddressE;
            PhoneBox.Text = Phone;

            // gets the city and country info

            string getCityInfo = $"select city, countryId from city where cityId = {cityId}";
            custtable.Open();

            MySqlCommand cityIdinfo = new MySqlCommand(getCityInfo, custtable);
            MySqlDataReader cityinfor = cityIdinfo.ExecuteReader();

            while (cityinfor.Read())
            {
                cityBox.Text = cityinfor.GetString("city");
                countryId = cityinfor.GetString("countryId");
            }

            custtable.Close();

            string getCountryInfo = $"select country from country where countryId = {countryId}";
            custtable.Open();

            MySqlCommand countryidinfo = new MySqlCommand(getCountryInfo, custtable);
            MySqlDataReader countryinfo = countryidinfo.ExecuteReader();

            while (countryinfo.Read())
            {
                countryBox.Text = countryinfo.GetString("country");
            }
            custtable.Close();




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
                if (PhoneBox.Text.Length != 8)
                {
                    throw new Exception("Phone not correct format please use nnn-nnnn");
                }

                string phonetest = PhoneBox.Text.Remove(3, 1);

                if (int.TryParse(phonetest, out int tt) != true)
                {
                    throw new Exception("Phone not correct format please use nnn-nnnn");

                }

                int adID = -1;

                string x = Connection.connectstring;
                MySqlConnection custtable = new MySqlConnection(x);



                //below checks and modifies existing address


                custtable.Open();
                string addIdQuery = "select addressId, phone, address from address";
                MySqlCommand addIdPull = new MySqlCommand(addIdQuery, custtable);
                MySqlDataReader addIdRead = addIdPull.ExecuteReader();
                while (addIdRead.Read())
                {
                    addressIDlist.Add(addIdRead.GetString("addressId"));
                    phonenumbers.Add(addIdRead.GetString("phone"));
                    addresses.Add(addIdRead.GetString("address"));

                }


                custtable.Close();


                for (int i = 0; i < phonenumbers.Count; i++)
                {
                    if (PhoneBox.Text == phonenumbers[i] && AddressBox.Text == addresses[i])
                    {

                        adID = Int32.Parse(addressIDlist[i]);
                        break;
                    }

                }

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

                string updateCust = $"Update customer SET customerName='{NameBox.Text}', addressID='{adID}' Where customerId ={CustomerBox.Text}";
                custtable.Open();

                MySqlCommand updateCustName = new MySqlCommand(updateCust, custtable);

                updateCustName.ExecuteNonQuery();

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

        string custId;

        string custName;

        string Phone;

        string AddressE;

        string cityId;

        string countryId;

        List<string> phonenumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> addressIDlist = new List<string>();
        List<string> cityIdList = new List<string>();
        List<string> cityList = new List<string>();
        List<string> countrylist = new List<string>();
        List<string> countryIDlist = new List<string>();



    }
}
