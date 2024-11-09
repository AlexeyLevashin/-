using System;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinterWithScan printerWithScan = new PrinterWithScan();
            Console.WriteLine("Принтер со сканером: ");
            Console.WriteLine(printerWithScan.Print());
            Console.WriteLine(printerWithScan.Scan());

            Console.WriteLine();
            IPrinterWithoutScan printerWithoutScan = new PrinterWithoutScan();
            Console.WriteLine("Принтер без сканера: ");
            Console.WriteLine(printerWithoutScan.Print());

            Console.ReadLine();
        }
    }
}
