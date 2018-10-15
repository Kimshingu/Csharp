using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Emp {
        public override string ToString()
        {
            return "Emp";
        }
    }
    class Programmer : Emp {
        public override string ToString()
        {
            return "Programmer";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            Emp e = p as Emp;
            if (e != null) {
                Console.WriteLine(e.ToString());
                
            }
        }
    }
}
