using System;
using QuickmartTraders.Transaction;


public class Program
{
    public static SaleTransaction? LastTransaction; //store last transaction
    public static bool HasLastTransaction = false; // check if last transaction exist
    public static void Main(String[] args)
    {
        while(true)
        {
            #region Menu
            Console.WriteLine("\n\n=============== QuickMart Traders ===============");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit\n\n");
            #endregion
            Console.WriteLine("Enter your option: ");

            string? input = Console.ReadLine();
            int.TryParse(input, out int choice);

            Console.WriteLine("\n\n");

            if (choice == 4)
            {
                Console.WriteLine("Thank you. Application closed Normally");
                return;
            } 
            else if (choice == 3)
            {
                if (!HasLastTransaction) // check if transaction exist  
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                    continue;
                }
                LastTransaction.Calculate(); // calculate last transaction

            }
            else if (choice == 2)
            {
                if (!HasLastTransaction) // check if transaction exist  
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                    continue;
                }
                LastTransaction.View();

            } 
            else if (choice == 1)
            {
                LastTransaction  = new SaleTransaction(); //create new saleTransaction obj
                LastTransaction.Register(); //register transaction

                HasLastTransaction = true; //mark transaction exist

                LastTransaction.Calculate(); // calculate last transaction
                Console.WriteLine("\nTransaction Saved Successfully\n");
                LastTransaction.Summary(); // display transaction summary
            }
            else
            {
                Console.WriteLine("\nInvalid Option. Please try again.");
            }
        }
    }
}