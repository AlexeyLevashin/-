using System;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount();
            discount.Price = 2000;
            Console.Write("Цена без скидки: ");
            Console.WriteLine( discount.Calculation(discount.Price));

            PercentageDiscount percentagediscount = new PercentageDiscount();
            percentagediscount.Persentage = 15;
            Console.Write($"Цена со скидкой {percentagediscount.Persentage}%: ");
            Console.WriteLine(percentagediscount.Calculation(discount.Price));


            FixedAmountDiscount fixedamountdiscount = new FixedAmountDiscount();
            fixedamountdiscount.FixedAmount = 300;
            Console.Write($"Цена со скидкой {fixedamountdiscount.FixedAmount}: ");
            Console.WriteLine(fixedamountdiscount.Calculation(discount.Price));

            Console.ReadLine();
        }
    }
}
