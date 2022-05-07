using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using SoftwareTwoProject.Forms;
using SoftwareTwoProject.Class;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;


namespace SoftwareTwoProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            //note below confirms if not english then french as culture
            //note need to add in french message boxes... should just be a simple if statement regarding what the current culture == as a string
            
           
            if(CultureInfo.CurrentCulture.ToString()=="en-US")
            {

            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr");

            }

            InitializeComponent();
            string userid = NameBox.Text;
            MySqlConnection user = new MySqlConnection("server=127.0.0.1;user id=sqlUser;database=client_schedule;port=3306;password=Passw0rd!");
            
            MessageBox.Show(CultureInfo.CurrentCulture.ToString());
            
            user.Open();
            MySqlCommand namecommand = new MySqlCommand(logNameQuery,user);
            MySqlDataReader readname = namecommand.ExecuteReader();
            while (readname.Read())
            {
                usernamelist.Add(readname.GetString("userName"));

            }
            user.Close();
            user.Open();
            MySqlCommand PWcommand = new MySqlCommand(logPWQuery, user);
            MySqlDataReader readPW = PWcommand.ExecuteReader();
            while (readPW.Read())
            {
                PWlist.Add(readPW.GetString("password"));
            }

            //MySqlConnection user = new MySqlConnection("server=127.0.0.1;user id=sqlUser;persistsecurityinfo=True;database=client_schedule");
        }

        private void LoginBut_MouseClick(object sender, MouseEventArgs e)
        {
            int y;
            for (int i = 0; i < usernamelist.Count; i++)
            {
                if(NameBox.Text == usernamelist[i] && PWBox.Text == PWlist[i])
                {
                    MessageBox.Show("success!!");
                    y = 1;

                    string x = Connection.connectstring;
                    MySqlConnection custtable = new MySqlConnection(x);
                    custtable.Open();

                    string getUsID = $"select userId from user where userName = '{NameBox.Text}'";
                    MySqlCommand getUSIDp2 = new MySqlCommand(getUsID, custtable);
                    MySqlDataReader getUSIDp3 = getUSIDp2.ExecuteReader();
                    while(getUSIDp3.Read())
                    {
                        User.UserId = getUSIDp3.GetString("userId");
                    }

                    if(File.Exists(filename)!= true)
                    {
                        File.Create(filename).Close();
                        using (StreamWriter logtime = File.AppendText(filename))
                        { 
                            logtime.WriteLine($"{DateTime.UtcNow}");
                        }

                    }
                    else
                    {
                        using (StreamWriter logtime = File.AppendText(filename))
                        {
                            logtime.WriteLine($"{DateTime.UtcNow}");
                        }

                    }

                    

                    break;
                }
                else
                {
                    y = 0;
                    MessageBox.Show("Login not detected");
                }


            }


            //MessageBox.Show(usernamelist[0]);

            MainDashboard mainDashboard = new MainDashboard();
            mainDashboard.Show();
            this.Hide();
        }
        
        public static string logNameQuery = "select userName from user";
        public static string logPWQuery = "select password from user";
        List<string> usernamelist = new List<string>();
        List<string> PWlist = new List<string>();

        string filename = "LoginTimeStamp.txt";
        
        
    }
}
