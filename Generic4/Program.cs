using System;

namespace Generic4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=7, b=6;
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");

            Console.ReadLine();
        }
        public static void Swap<T>(ref T first, ref T second) 
        {
            T copy = first;
            first = second;
            second = copy;
        }
    }
}
