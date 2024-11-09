using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PercentageDiscount:Discount
    {
        public double Persentage { get; set; }
        public override double Calculation(double price)
        {
            return price - (price * (Persentage/100));
        }
    }
}
