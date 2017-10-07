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
            Console.WriteLine("----------SHAPE OBJECT CREATION-----------");
            Shape shape = new Shape();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------SQUARE OBJECT CREATION-----------");
            Square square = new Square();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------SHAPE FINDAREA CALL-----------");
            shape.FindArea();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------SQUARE FINDAREA CALL-----------");
            square.FindArea();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------SQUARE FINDSQUAREAREA CALL-----------");
            square.FindSquareArea();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
