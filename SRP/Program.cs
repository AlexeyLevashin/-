using System;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "ArtyomSvechnikov";
            employee.JobTitle = "programmer";
            employee.NumberOfHours = 200;
            employee.PayOfHours = 450;

            Console.Write($"Зарплата {employee.Name}: ");
            Pay pay = new Pay();
            Console.WriteLine(pay.CalculatoinPay(employee));

            Console.ReadLine();
        }
    }
}
