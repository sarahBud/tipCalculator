using System;

namespace tipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt User for Total bill amount
            //Prompt Percentage of tip they want to tip 15,18,20
            //Calculate percentage of tip from total bill
            //Calculate Tip Tip = percent * bill /100
            //Calculate total bill = bill + tip
            //Your tip total is...
            //Your total bill...

            
            Console.WriteLine("Enter the total bill: ");
            string billInput = Console.ReadLine();
            //billInput = billInput.Trim();
            //billInput = billInput.Trim('$');
            billInput = billInput.Trim().Trim('$');

            double bill;

            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not a valid amount.");
                Console.ReadLine();
                return;
            }
                      
            Console.WriteLine("What percent would you like to tip? ");
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput.Trim('%');
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercent;
            
            if (!double.TryParse(tipPercentInput, out tipPercent))
            {
                Console.WriteLine($"The value {tipPercentInput} is not valid tip.");
            }
                       
         
            //double bill = double.Parse(billInput);
            //int tipPercent = int.Parse(tipPercentInput);

            double tipAmount = Math.Round( tipPercent * bill / 100, 2);
            double totalBill = Math.Round( bill + tipAmount, 2);
            //double roundedTipAmount = Math.Round(tipAmount, 2);
            //totalBill = Math.Round(totalBill, 2);

            Console.WriteLine($"Your tip amount is: ${tipAmount}");
            Console.WriteLine($"Your total bill amount is: ${totalBill}");

            Console.ReadLine();

        }
    }
}
