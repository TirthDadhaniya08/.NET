using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Lab_3_4
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    class Calculate1 : Lab_3_4
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
