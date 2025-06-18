using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    //7.(B) Write a program to create interface named Shape.In this interface, we have three methods Circle(), Triangle() and Square()
    //which calculates area of Circle, Triangle and Square respectively.Implement Shape interface.
    interface Shape1
    {
        double Circle(double radius);
        double Triangle(double baseLength, double height);
        double Square(double sideLength);
    }
    class Shape : Shape1
    {
        public double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double Triangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
        public double Square(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
    class Lab_3_7
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine("Area of Circle is = " + shape.Circle(5));
            Console.WriteLine("Area of Triangle is = " + shape.Triangle(4, 3));
            Console.WriteLine("Area of Square is = " + shape.Square(2));
        }
    }

}
