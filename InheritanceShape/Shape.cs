using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Constructor Called");
        }

        public abstract int FindPerimeter();

        public virtual int FindArea()
        {
            Console.WriteLine("Shape FindArea Called");
            return 0;
        }        
    }
}
