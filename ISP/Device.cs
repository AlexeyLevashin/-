using System;

namespace ISP
{
    public abstract class Device
    {
        public virtual string Print()
        {
            return "Печать";
        }
        public virtual string Scan()
        {
            return "Сканирование";
        }
    }
}
