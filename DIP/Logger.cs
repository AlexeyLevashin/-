using System;

namespace DIP
{
    public class Logger:ILogger
    {
        public string ConsoleLogger()
        {
            return "Вывод на консоль";
        }
    }
}
