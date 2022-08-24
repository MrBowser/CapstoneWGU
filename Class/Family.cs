using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTwoProject.Class
{
    public class Family : Customer
    {
        public int LotSize { get; set; }

        public Family(int ID, string Name, int adID)
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

        public int FamilyBilling()
        {

            if(LotSize > 2500)
            {
                
                return LotSize / 5 + 500;
            }
            else if (LotSize < 100)
            {
                return 300;
            }
            else
            {
                return LotSize / 5;

            }

            
        }

    }
}
