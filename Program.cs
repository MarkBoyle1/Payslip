using System;

namespace payslip
{
    class Program
    {
        static void Main(string[] args)
        {
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
            
        }
    }
}
