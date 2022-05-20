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
                cityIdm = custinfo.GetString("cityId");
                              
            }

            custtable.Close();

            CustomerBox.Text = custId;
            NameBox.Text = custName;
            AddressBox.Text = AddressE;
            PhoneBox.Text = Phone;

            // gets the city and country info

            string getCityInfo = $"select city, countryId from city where cityId = {cityIdm}";
            custtable.Open();

            MySqlCommand cityIdinfo = new MySqlCommand(getCityInfo, custtable);
            MySqlDataReader cityinfor = cityIdinfo.ExecuteReader();

            while (cityinfor.Read())
            {
                cityBox.Text = cityinfor.GetString("city");
                countryIdm = cityinfor.GetString("countryId");
            }

            custtable.Close();

            string getCountryInfo = $"select country from country where countryId = {countryIdm}";
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

                if (NameBox.Text.Length<1 ||AddressBox.Text.Length<1 || cityBox.Text.Length<1 || countryBox.Text.Length<1 )
                {
                    throw new Exception("Nothing can be left blank");
                }

                int adID = -1;
                int cityID = -1;
                int countryID = -1;

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

                for (int i = 0; i < countrylist.Count; i++)
                {
                    if (countryBox.Text == countrylist[i])
                    {
                        countryID = Int32.Parse(countryIDlist[i]);
                    }

                }


                //creates new country if not found

                if (countryID == -1)
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

                if (cityID == -1)
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
                    string addAddressQuery = $"Insert Into address VALUES('{adID}','{AddressBox.Text}','test','{cityID}','12345','{PhoneBox.Text}','2013-09-09 00:00:00', 'test','2013-09-09 00:00:00','test') ";
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

        string cityIdm;

        string countryIdm;

        List<string> phonenumbers = new List<string>();
        List<string> addresses = new List<string>();
        List<string> addressIDlist = new List<string>();
        List<string> cityIdList = new List<string>();
        List<string> cityList = new List<string>();
        List<string> countrylist = new List<string>();
        List<string> countryIDlist = new List<string>();



    }
}
