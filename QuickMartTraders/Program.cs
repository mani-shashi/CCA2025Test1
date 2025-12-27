using System;
using QuickmartTraders.Transaction;


public class Program
{
    public static SaleTransaction? LastTransaction;
    public static bool HasLastTransaction = false;
    public static void Main(String[] args)
    {
        while(true)
        {
        
            Console.WriteLine("\n\n=============== QuickMart Traders ===============");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit\n\n");
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

                if (!HasLastTransaction)
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                    continue;
                }
                LastTransaction.Calculate();

            }
            else if (choice == 2)
            {

                if (!HasLastTransaction)
                {
                    Console.WriteLine("No transaction available. Please create a new transaction first.");
                    continue;
                }
                LastTransaction.View();

            } 
            else if (choice == 1)
            {

                LastTransaction  = new SaleTransaction();
                LastTransaction.Register();

                HasLastTransaction = true;

                LastTransaction.Calculate();
                Console.WriteLine("\nTransaction Saved Successfully\n");
                LastTransaction.Summary();
                
            }
            else
            {
                Console.WriteLine("\nInvalid Option. Please try again.");
            }
        }
    }
}