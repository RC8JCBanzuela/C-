using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingSystem
{
    internal class SellerInfo
    {
        private string seller;
        private string itemName;
        private int itemPrice;

        public string NameOfSeller
        {
            get { return seller; }
            set { seller = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int PriceOfItem

        {
            get { return itemPrice; }   
            set { itemPrice = value; }
        }

     public SellerInfo(string seller, string itemName, int itemPrice) 
        {
            NameOfSeller = seller;
            ItemName = itemName;
            PriceOfItem = itemPrice;

        }
    }
}
