using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Lab_4_5
    {
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        public int Area(int side)
        {
            return side * side;
        }
        public double Area(double length, double breadth)
        {
            return length * breadth;
        }

    }
}
