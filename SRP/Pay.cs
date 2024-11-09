using System;

namespace SRP
{
    internal class Pay
    {
        public int CalculatoinPay(Employee employee)
        {
            return employee.PayOfHours * employee.NumberOfHours;
        }
    }
}
