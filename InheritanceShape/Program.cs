using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("----------SHAPE OBJECT CREATION-----------");
            //Shape shape = new Shape();
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("----------SQUARE OBJECT CREATION-----------");
            Square square = new Square();
            Console.WriteLine();
            Console.WriteLine();

          
            Console.WriteLine("----------Square FindArea CALL-----------");
            square.FindArea();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------Square FindSquareArea CALL-----------");
            square.FindSquareArea();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------Square FindPerimeter CALL-----------");
            square.FindPerimeter();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------Square GetSides CALL-----------");
            square.GetSides();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------POLYMORPHISM-----------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------Shape new Square FindArea and FindPerimeter CALL-----------");
            Shape shape = square;
            int result = shape.FindArea();
            shape.FindPerimeter();
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------ISides new Square GetSides CALL-----------");
            ISides sides = new Square();
            result = sides.GetSides();
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------ISides GetSides CALL-----------");
            ISides sides1 = square;
            result = sides1.GetSides();
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------ISides GetSides CALL-----------");
            shape = square;
            shape.FindArea();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------Triangle object created-----------");

            Triangle triangle = new Triangle();
            triangle.FindArea();
            triangle.FindTriangleArea();
            triangle.GetSides();
            triangle.FindPerimeter();




        }
    }
}
