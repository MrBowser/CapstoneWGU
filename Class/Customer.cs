using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTwoProject.Class
{
    public class Customer
    {

        public static int customerIDNumber;

        //belowis not used
        public static string editcustomer;

        public int customerID { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public int cusActive { get; set; }
        public DateTime createDate
        {
            get; set;
        }
        public string createBy
        {
            get; set;
        }
        public DateTime lastUpdate
        {
            get; set;
        }
        public string lastUpBy
        {
            get; set;
        } 

        
        

        public Customer(int ID,string Name, int adID)
        {
            //DateTime x = new DateTime(2010,8,15) ;
            this.customerID = ID;
            this.customerName = Name;
            this.addressId = adID;
            this.cusActive = 6;
            this.createBy = "Mitch";
            this.createDate = DateTime.UtcNow;
            this.lastUpBy = "Mitch";
            this.lastUpdate = DateTime.UtcNow;

        }




    }
}
