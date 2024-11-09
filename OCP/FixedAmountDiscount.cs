using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class FixedAmountDiscount:Discount
    {
        public double FixedAmount { get; set; }
        public override double Calculation(double price)
        {
            return price - FixedAmount;
        }
    }
}
