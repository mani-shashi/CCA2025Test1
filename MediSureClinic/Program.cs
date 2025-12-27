using System;
using MediSureCLinic.Billing;
public class Program
{
    static PatientBill? LastBill;
    static bool HasLastBill = false;
    public static void Main(string[] args)
    {
        //loop until user does not exit
        while (true)
        {
            Console.WriteLine("\n\n\n=============== MediSure Clinic  Billing  ===============");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
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

                if (!HasLastBill)
                {
                    Console.WriteLine("\nNo bill available. Please create a new bill first.\n");
                    continue;
                }

                LastBill.Clear();

            }
            else if (choice == 2)
            {

                if (!HasLastBill)
                {
                    Console.WriteLine("\nNo bill available. Please create a new bill first.\n");
                    continue;
                }
                LastBill.View();
                
            } 
            else if (choice == 1)
            {
                
                LastBill = new PatientBill();
                LastBill.Register();

                HasLastBill = true;

                LastBill.Calculate();
                Console.WriteLine("\nBill Created Successfully\n");
                LastBill.Summary();
               
            }
            else
            {
                Console.WriteLine("\nInvalid Option. Please try again.");
            }
        }
    }
}