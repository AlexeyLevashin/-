using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Discount
    {
        public double Price {  get; set; }
        public virtual double Calculation(double price)
        {
            return price;
        }
    }
}
