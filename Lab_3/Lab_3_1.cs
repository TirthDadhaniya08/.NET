using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Lab_3_1
    {
        int a=5,b=0;
        public void Divide()
        {
            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error Message: " + e);
            }
        }
    }
}
