using System;

namespace Generic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>(3, "часа ночи");
            Console.WriteLine($"{pair.Value1}, {pair.Value2}");
            Console.ReadLine();
        }
    }
}
