using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTwoProject.Class
{
    public class Customer
    {

        public int customerID { get; set; }
        public string customerName { get; set; }
        public int addressId { get; set; }
        public bool cusActive { get; set; }
        public string createDate
        {
            get; set;
        }
        public string createBy
        {
            get; set;
        }
        public string lastUpdate
        {
            get; set;
        }
        public string lastUpBy
        {
            get; set;
        } 

        
        

        public Customer(int ID,string Name, int adID)
        {
            this.customerID = ID;
            this.customerName = Name;
            this.addressId = adID;
            this.cusActive = true;
            this.createBy = "Null";
            this.createDate = "Null";
            this.lastUpBy = "Null";
            this.lastUpdate = "Null";

        }




    }
}
