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
            int annualSalary = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input your super rate:");
            int superRate = Int32.Parse(Console.ReadLine());
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


        }
    }
}
