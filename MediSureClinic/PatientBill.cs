namespace MediSureCLinic.Billing
{
    public class PatientBill()
    {
        #region Properties
        public string? BillId{get; set;} 
        public string? PatientName{get; set;}
        public bool HasInsurance{get; set;}

        public decimal ConsultationFee{get; set;}
        public decimal LabCharges{get; set;}
        public decimal MedicineCharges{get; set;}
        public decimal GrossAmount{get; set;}
        public decimal DiscountAmount{get; set;}
        public decimal FinalPayable {get; set;}
        #endregion

        #region Method - Register()
        /// <summary>
        /// Method to register bill
        /// </summary>
        public void Register()
        {
           Console.WriteLine("Enter Bill Id: ");
           BillId = Console.ReadLine();

           Console.WriteLine("Enter Patient Name: ");
           PatientName = Console.ReadLine();

           Console.WriteLine("Is the patient insured? (Y/N): ");
           string? insuranceInput = Console.ReadLine();
           HasInsurance = (insuranceInput?.ToUpper() == "Y");

           Console.WriteLine("Enter Consultation Fee: ");
           decimal.TryParse(Console.ReadLine(), out decimal tempConsultationFee);
           ConsultationFee = tempConsultationFee;

           Console.WriteLine("Enter Lab Charges: ");
           decimal.TryParse(Console.ReadLine(), out decimal tempLabCharges);
           LabCharges = tempLabCharges;

           Console.WriteLine("Enter Medicine Charges: ");
           decimal.TryParse(Console.ReadLine(), out decimal tempMedicineCharges);
           MedicineCharges = tempMedicineCharges;
        }
        #endregion

        #region Method - Summary()
        /// <summary>
        /// Method to print the summary of the bill
        /// </summary>
        public void Summary()
        {
            Console.WriteLine($"Gross Amount: {Math.Round(GrossAmount,2)}");
            Console.WriteLine($"Discount Amount: {Math.Round(DiscountAmount,2)}");
            Console.WriteLine($"Final Payable: {Math.Round(FinalPayable,2)}");
        }
        #endregion

        #region Method - Calculate()
        /// <summary>
        /// Method to calculate the bill
        /// </summary>
        public void Calculate()
        {
            GrossAmount = ConsultationFee + LabCharges + MedicineCharges;
            if (HasInsurance) // if patient has insurance, give discount
            {
                DiscountAmount = GrossAmount * 0.10m;
            }
            else
            {
                DiscountAmount = 0;
            }
            FinalPayable = GrossAmount - DiscountAmount;
        }
        #endregion

        #region Method - View()
        /// <summary>
        /// Method to view the bill
        /// </summary>
        public void View()
        {
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine($"BillId: {BillId}");
            Console.WriteLine($"Patient: {PatientName}");
            Console.WriteLine($"Insured: {HasInsurance}");
            Console.WriteLine($"Consultation Fee: {Math.Round(ConsultationFee, 2)}");
            Console.WriteLine($"Lab Charges: {Math.Round(LabCharges, 2)}");
            Console.WriteLine($"Medicine Charges: {Math.Round(MedicineCharges, 2)}");
            Console.WriteLine($"Gross Amount: {Math.Round(GrossAmount, 2)}");
            Console.WriteLine($"Discount Amount: {Math.Round(DiscountAmount, 2)}");
            Console.WriteLine($"Final Payable: {Math.Round(FinalPayable, 2)}");

            Console.WriteLine("--------------------------------");
        }
        #endregion

        #region Method - Clear()
        /// <summary>
        /// Method to clear the bill
        /// </summary>
        public void Clear()
        {
            BillId = null;
            PatientName = null;
            HasInsurance = false;
            ConsultationFee = 0;
            LabCharges = 0;
            MedicineCharges = 0;
            GrossAmount = 0;
            DiscountAmount = 0;
            FinalPayable = 0;
            
            Console.WriteLine("Last bill cleared.");
        }
        #endregion
    }
}