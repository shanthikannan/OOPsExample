using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Triangle : Shape, ISides

    {
        public Triangle()
        {
            Console.WriteLine("Triangle construtor called");

        }

        public override int FindPerimeter()
        {
            Console.WriteLine("Triangle FindPerimeter called");
            return 0;
        }

        public override int FindArea()
        {
            Console.WriteLine("Triangle FindArea Called");
            return 0;
        }

        public int FindTriangleArea()
        {
            Console.WriteLine("Triangle FindTriangle Area Called");
            return 0;
        }
        public int GetSides()
        {
            Console.WriteLine("Triangle GetSides Called");
            return 5;
        }
    }
}
