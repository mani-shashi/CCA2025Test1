namespace QuickmartTraders.Transaction
{
    public class SaleTransaction
    {
        public string? InvoiceNo{get; set;}
        public string? CustomerName{get; set;}
        public string? ItemName{get; set;}


        public int Quantity{get; set;}
        public decimal PurchaseAmount{get; set;}
        public decimal SellingAmount{get; set;}


        public decimal ProfitOrLossAmount{get; set;}
        public decimal ProfitOrLossMarginPercent{get; set;}
        public string? ProfitOrLossStatus{get; set;}


        ///<summary>
        /// </summary>
        public void Register()
        {
            Console.WriteLine("Enter Invoice No: ");
            InvoiceNo = Console.ReadLine();

            Console.WriteLine("Enter Customer Name: ");
            CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Item Name: ");
            ItemName = Console.ReadLine();

            Console.WriteLine("Enter Quantity: ");
            string? input = Console.ReadLine();
            int.TryParse(input, out int tempQuantity);
            Quantity = tempQuantity;

            Console.WriteLine("Enter Purchase Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out decimal tempPurchaseAmount);
            PurchaseAmount = tempPurchaseAmount;

            Console.WriteLine("Enter Selling Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out decimal tempSellingAmount);
            SellingAmount = tempSellingAmount;
        }
        public void View()
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
                Console.WriteLine($"Profit/Loss Margin(%): {ProfitOrLossMarginPercent}");
                
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
                //If purchase amount is greater, return purchaseAmount - sellingAmount rounded up to 2 decimals
            }
            else
            {
                ProfitOrLossStatus = "Break - Even";
                ProfitOrLossAmount = 0;
            }

            ProfitOrLossMarginPercent = Math.Round ((ProfitOrLossAmount / PurchaseAmount) * 100 , 2);
        }


        public void Summary()
        {
            Console.WriteLine($"\nStatus: {ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
            Console.WriteLine($"Profit/Loss Margin (%): {ProfitOrLossMarginPercent}");

            Console.WriteLine("--------------------------------------\n");
        }
    }
}