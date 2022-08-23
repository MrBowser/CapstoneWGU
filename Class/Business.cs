using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTwoProject.Class
{
    public class Business : Customer
    {

        public int CompanySize { get; set; }

        public Business(int ID, string Name, int adID)
        {

            this.customerID = ID;
            this.customerName = Name;
            this.addressId = adID;
            this.cusActive = 6;
            this.createBy = "Mitch";
            this.createDate = DateTime.UtcNow;
            this.lastUpBy = "Mitch";
            this.lastUpdate = DateTime.UtcNow;

        }


        public int CompanyBilling()
        {

            if(CompanySize>0)
            {
                return 300 + CompanySize * 10;

            }
            else
            {
                return 1000;
            }

            

        }


    }
}
