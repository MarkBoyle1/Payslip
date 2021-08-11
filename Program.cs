using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input
            Console.WriteLine("Welcome to the payslip generator!");
            Console.WriteLine("Please input your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please input your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Please input your annual salary:");
            double annualSalary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input your super rate:");
            double superRate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input your payment start date:");
            string paymentStartDate = Console.ReadLine();
            Console.WriteLine("Please input your payment end date:");
            string paymentEndDate = Console.ReadLine();

            // Tax
            double taxBracketSumB = 0;
            double taxBracketSumC = 3572;
            double taxBracketSumD = 19822;
            double taxBracketSumE = 54232;

            double taxBracketRateB = 0.19;
            double taxBracketRateC = 0.325;
            double taxBracketRateD = 0.37;
            double taxBracketRateE = 0.45;

            double taxBracketMinB = 18200;
            double taxBracketMinC = 37000;
            double taxBracketMinD = 87000;
            double taxBracketMinE = 180000;

            double incomeTax = 0;
            if(annualSalary > taxBracketMinE){
                incomeTax = (taxBracketSumE + ((annualSalary - taxBracketMinE) * taxBracketRateE)) / 12;
            }
            else if(annualSalary > taxBracketMinD){
                incomeTax = (taxBracketSumD + ((annualSalary - taxBracketMinD) * taxBracketRateD)) / 12;
            }
            else if(annualSalary > taxBracketMinC){
                incomeTax = (taxBracketSumC + ((annualSalary - taxBracketMinC) * taxBracketRateC)) / 12;
            }
            else if(annualSalary > taxBracketMinB){
                incomeTax = (taxBracketSumB + ((annualSalary - taxBracketMinB) * taxBracketRateB)) / 12;
            }

            // Payslip
            double grossIncome = annualSalary / 12;
            double netIncome = grossIncome - incomeTax;
            double super = netIncome * (superRate / 100);

            Console.WriteLine("Your payslip has been generated!");

            Console.WriteLine("Name: " + firstName + " " + surname);
            Console.WriteLine("Pay Period: " + paymentStartDate + " - " + paymentEndDate);
            Console.WriteLine("Gross Income: " + Convert.ToInt32(grossIncome));
            Console.WriteLine("Income Tax: " + Convert.ToInt32(incomeTax));
            Console.WriteLine("Net Income: " + Convert.ToInt32(netIncome));
            Console.WriteLine("Super: " + Convert.ToInt32(super));

            Console.WriteLine("Thank you for using MYOB!");
        }
    }
}
