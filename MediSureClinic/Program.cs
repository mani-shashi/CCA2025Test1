using System;
using MediSureCLinic.Billing;
public class Program
{
    static PatientBill? LastBill; // store last generated patient bill
    static bool HasLastBill = false; // check if bill exist

    public static void Main(string[] args)
    {
        while (true)
        {
            #region Menu
            Console.WriteLine("\n\n=============== MediSure Clinic  Billing  ===============");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit\n\n");
            #endregion
            
            Console.WriteLine("Enter your option: ");

            string? input = Console.ReadLine();
            int.TryParse(input, out int choice); //convert user input to int

            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    LastBill = new PatientBill(); // create new PatientBill obj
                    LastBill.Register(); // Register patient details

                    HasLastBill = true; // Mark lastbill as true

                    LastBill.Calculate(); // calculate bill
                    Console.WriteLine("\nBill Created Successfully\n");
                    LastBill.Summary(); // print bill summary
                    break;

                case 2:
                    if (!HasLastBill) // check if bill exist before viewing
                    {
                        Console.WriteLine("\nNo bill available. Please create a new bill first.\n");
                    } else
                    {
                        LastBill.View(); // View Patient bill
                    }
                    break;
                    
                case 3:
                    if (!HasLastBill) //check if bill exist before clearing
                    {
                        Console.WriteLine("\nNo bill available. Please create a new bill first.\n");
                    }
                    else
                    {
                        LastBill.Clear(); // clear patient bill
                        HasLastBill=false;
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed Normally");
                    return;

                default: // if user input anything other than given
                    Console.WriteLine("\nInvalid Option. Please try again.");
                    continue;
            }
        }
    }
}