using System;
using System.Data.Common;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Console.WriteLine( cat.MakeSound());

            Animal dog = new Dog();
            Console.WriteLine( dog.MakeSound());

            Console.ReadLine();
        }
    
        
    }
}
