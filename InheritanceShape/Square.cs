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

        public int FindSquareArea()
        {
            Console.WriteLine("Square FindArea1 Called");
            return 0;
        }
    }
}
