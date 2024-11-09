using System;

namespace DIP
{
    public class DependensiesLog
    {
        public ILogger Logger { get; set; }
        public DependensiesLog(ILogger logger) 
        {
            Logger = logger;
        }

        public void DoSomething()
        {
            Console.WriteLine($"{Logger.ConsoleLogger()}. Действие выполнено в DependensiesLog");
        }
    }
}
