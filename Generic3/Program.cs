using System;

namespace Generic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Car> repository = new Repository<Car>();
            try
            {
                repository.Add(new Car { Brand = "Mers", Model = "Cls90" });
                repository.Add(new Car { Brand = "BMW", Model = "5" });
                var car = repository.Get(1);
                Console.WriteLine($"Car: {car.Brand} {car.Model}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
