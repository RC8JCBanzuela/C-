using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingSystem
{
    internal class BuyerOrUser
    {
        private string userName;
        private int biddingCost;

        public string NameOfUserBuyer
        {
            get { return userName; }
            set { userName = value; }
        }

        public int StartingBid
        {
            get { return biddingCost; }
            set { biddingCost = value; }
        }

        public BuyerOrUser(string userName, int biddingCost)
        {
            NameOfUserBuyer = userName;
            StartingBid = biddingCost;
        }
        public string GetItemOfSeller(SellerInfo seller)
        {
            return $"{seller.ItemName} - {seller.PriceOfItem} - {seller.NameOfSeller}";
        }

        public void BidOnItem(SellerInfo seller)
        {
            Console.WriteLine("Enter your bid amount: ");
            int bidAmount = Convert.ToInt32(Console.ReadLine());

            if (bidAmount > seller.PriceOfItem)
            {
                Console.WriteLine($"Congratulations, {NameOfUserBuyer}! You have won the auction for {seller.ItemName}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {NameOfUserBuyer}, your bid was too low. The auction for {seller.ItemName} has gone to another buyer.");
            }
        }
    }
}
