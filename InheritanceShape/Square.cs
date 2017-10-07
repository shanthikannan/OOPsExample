using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Square : Shape
    {
        public Square ()
        {
            Console.WriteLine("Square Constructor Called");
        }

        public override int FindPerimeter()
        {
            Console.WriteLine("Square FindPerimeter Called");
            return 10;
        }

        public int FindSquareArea()
        {
            Console.WriteLine("Square FindSquareArea Called");
            return 0;
        }
    }
}
