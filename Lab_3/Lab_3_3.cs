using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class Lab_3_3
    {
        public abstract void SumOfTwo(int a,int b);

        public abstract void SumOfThree(int a,int b,int c);

    }

    class Calculate : Lab_3_3
    {
        public override void SumOfTwo(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of two numbers is: " + c);
        }
        public override void SumOfThree(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("Sum of three numbers is: " + d);
        }
    }
}
