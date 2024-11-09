using System;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пингвин: ");
            InterfaceAll penguine = new Penguin();
            Console.Write( penguine.BirdSay());

            Console.WriteLine();
            Console.WriteLine("Другие птицы: ");
            InterfaceAll flybird = new FlyBird();
            InterfaceFly interfacefly = new FlyBird();

            Console.Write($"{flybird.BirdSay()} и {interfacefly.Statement()}");
           
            Console.ReadLine();
        }
    }
}
