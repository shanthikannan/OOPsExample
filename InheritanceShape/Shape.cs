using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape
{
    class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Constructor Called");
        }

        public virtual int FindArea()
        {
            Console.WriteLine("Shape FindArea Called");
            return 0;
        }        
    }
}
