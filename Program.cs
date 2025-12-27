// See https://aka.ms/new-console-template for more information

using QuickmartTraders.ProfitCalculator;

public class Program
{
    public static void Main(String[] args)
    {
        while(true){
        
        Console.WriteLine("=============== QuickMart Traders ===============");
        Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
        Console.WriteLine("2. View Last Transaction");
        Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Enter your option: ");
        string? input = Console.ReadLine();
        int.TryParse(input, out int choice);

        if (choice == 4)
        {
            Console.WriteLine("Thank you. Application closed Normally");
            return;
        } 
        else if (choice == 3)
        {
            SaleTransaction saleTransaction = new SaleTransaction();
            saleTransaction.ViewTransaction();
        }
        else if (choice == 2)
        {
            SaleTransaction saleTransaction = new SaleTransaction();
            saleTransaction.ViewTransaction();

        } 
        else if (choice == 1)
        {
            SaleTransaction saleTransaction = new SaleTransaction();
            saleTransaction.RegisterTransaction();
            Console.WriteLine("Transaction Saved Successfully");

            saleTransaction.Calculate();
            
        }
        }


    //     while (true)
    //     {
    //         Console.WriteLine("=============== MediSure Clinic  Billing  ===============");
    //         Console.WriteLine("1. Create New Bill (Enter Patient Details)");
    //         Console.WriteLine("2. View Last Bill");
    //         Console.WriteLine("3. Clear Last Bill");
    //         Console.WriteLine("4. Exit");
    //         Console.WriteLine("Enter your option: ");
    //         string? input = Console.ReadLine();
    //         int.TryParse(input, out int choice);

    //         if (choice == 4)
    //         {
    //             Console.WriteLine("Thank you. Application closed Normally");
    //             return;
    //         } 
    //         else if (choice == 3)
    //         {
    //             SaleTransaction saleTransaction = new SaleTransaction();
    //             saleTransaction.ViewTransaction();
    //         }
    //         else if (choice == 2)
    //         {
    //             SaleTransaction saleTransaction = new SaleTransaction();
    //             saleTransaction.ViewTransaction();

    //         } 
    //         else if (choice == 1)
    //         {
    //             SaleTransaction saleTransaction = new SaleTransaction();
    //             saleTransaction.RegisterTransaction();
    //             Console.WriteLine("Transaction Saved Successfully");

    //             saleTransaction.Calculate();
                
    //         }
    //     }


       


    // }
}
}

