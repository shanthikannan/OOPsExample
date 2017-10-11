using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    public class Square : Shape, ISides
    {
        private int number = 0;
        public int i, j, k;
        public Square ()
        {
            Console.WriteLine("Square Constructor Called");
        }

        public override int FindPerimeter()
        {
            Console.WriteLine("Square FindPerimeter Called");
            return 10;
        }

        public override int FindArea()
        {
            number++;
            Console.WriteLine("Square FindArea Called");
            return number;
        }

        public int FindSquareArea()
        {
            Console.WriteLine("Square FindSquareArea Called");
            return 0;
        }

        public int GetSides()
        {
            number ++;
            Console.WriteLine("Square GetSides Called");
            return number;
        }
    }
}
