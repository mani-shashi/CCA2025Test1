namespace QuickmartTraders.Transaction
{
    public class SaleTransaction
    {
        #region Fields
        public string? InvoiceNo{get; set;}
        public string? CustomerName{get; set;}
        public string? ItemName{get; set;}


        public int Quantity{get; set;}
        public decimal PurchaseAmount{get; set;}
        public decimal SellingAmount{get; set;}


        public decimal ProfitOrLossAmount{get; set;}
        public decimal ProfitOrLossMarginPercent{get; set;}
        public string? ProfitOrLossStatus{get; set;}
        #endregion

        #region Method - Register()
        ///<summary>
        /// Method to register the transaction
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
            int.TryParse(input, out int tempQuantity); // parse user input as int
            Quantity = tempQuantity;

            Console.WriteLine("Enter Purchase Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out decimal tempPurchaseAmount); // safely parse user input as decimal
            PurchaseAmount = tempPurchaseAmount;

            Console.WriteLine("Enter Selling Amount (total): ");
            input = Console.ReadLine();
            Decimal.TryParse(input, out decimal tempSellingAmount);
            SellingAmount = tempSellingAmount;
        }
        #endregion

        #region Method - View()
        /// <summary>
        /// Method to view the last tranction
        /// </summary>
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
        #endregion

        #region Method - Calculate()
        /// <summary>
        /// Method to calculate the transaction
        /// </summary>
        public void Calculate()
        {
            if (SellingAmount > PurchaseAmount) // If in profit , means selling amount is greater than purchaseAmount
            {
                ProfitOrLossStatus = "PROFIT";
                ProfitOrLossAmount = Math.Round(SellingAmount - PurchaseAmount , 2); // Round ProfitAmount up to 2 decimals
                
            } 
            else if (SellingAmount < PurchaseAmount) // If in loss , means selling amount is less than purchaseAmount
            {
                ProfitOrLossStatus = "LOSS";
                ProfitOrLossAmount = Math.Round(PurchaseAmount - SellingAmount, 2); // Round LossAmount up to 2 decimals
            }
            else // if neither profit nor loss
            {
                ProfitOrLossStatus = "BREAK - EVEN";
                ProfitOrLossAmount = 0;
            }

            ProfitOrLossMarginPercent = Math.Round ((ProfitOrLossAmount / PurchaseAmount) * 100 , 2); 
            //profit or loss margin percent (rounded upto 2 decimals)
        }
        #endregion

        #region Method - Summary()
        /// <summary>
        /// Method to print summary
        /// </summary>
        public void Summary()
        {
            Console.WriteLine($"\nStatus: {ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
            Console.WriteLine($"Profit/Loss Margin (%): {ProfitOrLossMarginPercent}");

            Console.WriteLine("--------------------------------------\n");
        }
        #endregion
    }
}