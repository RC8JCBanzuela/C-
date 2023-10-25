using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:

            Console.Write("Are you a a.Seller b.User/Buyer or c.Admin?: ");
            string choices = Console.ReadLine();

            if(choices == "a")
            {
                Console.WriteLine("Welcome Seller! Do you have something to sell in auction? Please fill the required fields below.");

                Console.Write("Name: ");
                string newSeller = Console.ReadLine();

                Console.Write("Item: ");
                string newItem = Console.ReadLine();

                Console.Write("Item Price: ");
                int priceOfItem = Convert.ToInt32(Console.ReadLine());

                SellerInfo seller = new SellerInfo(newSeller, newItem, priceOfItem);

                if (priceOfItem <= 0)
                {
                    Console.WriteLine("Enter a Valid Price!");
                }
                else
                {
                    Console.WriteLine("Congratulations " + newSeller + " your item is now at auction");
                    Console.WriteLine();
                    goto Start;
                }
            }
            //USER OR BUYER
            else if (choices == "b") 
            {
                Console.WriteLine("Welcome Buyer! Do you want to buy? Enter the needed information below. ");
                Console.Write("Name: ");
                string buyerName = Console.ReadLine();

                Console.Write("Bid Budget(you need to enter this to participate in an auction): ");
                int startBid = Convert.ToInt32(Console.ReadLine());

                BuyerOrUser user1 = new BuyerOrUser(buyerName, startBid);

                SellerInfo seller = new SellerInfo("JC", "Gold", 100);
                Console.WriteLine($"This is 1st Item will go to the auction: {user1.GetItemOfSeller(seller)}");

                // Prompt the buyer to bid on the item
                Console.WriteLine("Do you want to bid on this item? (y/n)");
                string bidChoice = Console.ReadLine();

                if (bidChoice.ToLower() == "y")
                {
                    user1.BidOnItem(seller);
                }
                else
                {
                    Console.WriteLine("Thank you for your interest. Goodbye!");
                }
            }
            //ADMINSTRATOR
            else if (choices == "c") 
            {
                Console.WriteLine("null3");
            }
            else
            {
                Console.WriteLine("Error!");
                goto Start;
            }
        }
    }
}
