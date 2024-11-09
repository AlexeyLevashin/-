using System;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            Console.WriteLine(logger.ConsoleLogger());

            DependensiesLog dependensiesLog = new DependensiesLog(logger);
            dependensiesLog.DoSomething();

            Console.ReadLine();
        }
    }
}
