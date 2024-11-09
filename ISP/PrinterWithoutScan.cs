using System;

namespace ISP
{
    internal class PrinterWithoutScan:IPrinterWithoutScan
    {
        public string Print()
        {
            return "Печать выполнена";
        }
    }
}
