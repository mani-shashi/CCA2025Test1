namespace MedisureClinic.Billing
{
    public class PatientBill()
    {
        public string BillId{get; set;}
        public string PatientName{get; set;}
        public bool HasInsurance{get; set;}
        public decimal ConsultationFee{get; set;}
        public decimal LabCharges{get; set;}
        public decimal MedicineCharges{get; set;}
        public decimal GrossAmount{get; set;}
        public decimal DiscountAmount{get; set;}
        public decimal FinalPayable {get; set;}

        public static PatientBill LastBill = null;

        public void Register()
        {

           Console.WriteLine("Enter Bill Id: ");
           BillId = Console.ReadLine();

           Console.WriteLine("Enter Patient Name: ");
           PatientName = Console.ReadLine();

           Console.WriteLine("Is the patient insured? (Y/N): ");
           bool.TryParse(Console.ReadLine(), out bool HasInsurance);

           Console.WriteLine("Enter Consultation Fee: ");
           decimal.TryParse(Console.ReadLine(), out decimal ConsultationFee);


           Console.WriteLine("Enter Lab Charges: ");
           decimal.TryParse(Console.ReadLine(), out decimal LabCharges);

           Console.WriteLine("Enter Medicine Charges: ");
           decimal.TryParse(Console.ReadLine(), out decimal MedicineCharges);

           Console.WriteLine("Bill created Successfully");
           printSummary();
        }

        private void printSummary()
        {
            Console.WriteLine($"Gross Amount: {Math.Round(GrossAmount,2)}");
            Console.WriteLine($"Discount Amount: {Math.Round(DiscountAmount,2)}");
            Console.WriteLine($"Final Payable: {Math.Round(FinalPayable,2)}");
            
        }

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

        public void Clear()
        {
            
            Console.WriteLine("Last bill cleared.");
        }

        
    }

}