namespace QuickmartTraders.ProfitCalculator
{
    public class SaleTransaction
    {
        public string InvoiceNo;
        public string CustomerName;
        public string ItemName;
        public int Quantity;
        public decimal PurchaseAmount;
        public decimal SellingAmount;
        public decimal ProfitOrLossAmount;
        public decimal ProfitMarginPercent;
        public string ProfitOrLossStatus;

        public bool LastTransaction=false;

        public void RegisterTransaction()
        {
            Console.WriteLine("Enter Invoice No: ");
            InvoiceNo = Console.ReadLine();

            Console.WriteLine("Enter Customer Name: ");
            CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Item Name: ");
            ItemName = Console.ReadLine();

            Console.WriteLine("Enter Quantity: ");
            string? input = Console.ReadLine();
            int.TryParse(input, out Quantity);

            Console.WriteLine("Enter Purchase Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out PurchaseAmount);

            Console.WriteLine("Enter Selling Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out SellingAmount);

            LastTransaction = true;
        }
        public void ViewTransaction()
        {  
                Console.WriteLine("---------------Last Transaction--------------");
                Console.WriteLine($"Invoice No: {InvoiceNo}");
                Console.WriteLine($"Customer: {CustomerName}");
                Console.WriteLine($"Item: {ItemName}");
                Console.WriteLine($"Quantity: {Quantity}");
                Console.WriteLine($"Purchase Amount: {PurchaseAmount}");
                Console.WriteLine($"Selling Amount: {SellingAmount}");
                Console.WriteLine($"Status: {ProfitOrLossStatus}");
                Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
                Console.WriteLine($"Profit Margin(%): {ProfitMarginPercent}");
                
                Console.WriteLine("--------------------------------------");
            
        }

        public void Calculate()
        {
            if (SellingAmount > PurchaseAmount)
            {
                ProfitOrLossStatus = "Profit";
                ProfitOrLossAmount = Math.Round(SellingAmount - PurchaseAmount , 2);
                //If selling amount is greater, return sellinAmount - PurchaseAmount rounded up to 2 decimals
            } 
            else if (SellingAmount < PurchaseAmount)
            {
                ProfitOrLossStatus = "Loss";
                ProfitOrLossAmount = Math.Round(PurchaseAmount - SellingAmount, 2);
            }
            else
            {
                ProfitOrLossStatus = "Break - Even";
                ProfitOrLossAmount = 0;
            }

            ProfitMarginPercent = Math.Round ((ProfitOrLossAmount / PurchaseAmount) * 100 , 2);
        }

        public bool HasLastTransaction()
        {
            return LastTransaction;
        }

        public void printSummary()
        {
            Console.WriteLine($"Status: {ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent}");

            Console.WriteLine("--------------------------------------");
        }


    }
}