using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    internal class Pair<T, U>
    {
        public T Value1 { get; set; }
        public U Value2 { get; set; }

        public Pair(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
