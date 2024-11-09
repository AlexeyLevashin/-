using System;

namespace ISP
{
    public class PrinterWithScan:IPrinterWithScan
    {
        public string Print()
        {
            return "Печать выполнена";
        }
        public string Scan()
        {
            return "Сканирование выполнено";
        }
    }
}
