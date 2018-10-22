using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_18_10_19_
{
    class Program
    {
        delegate int Calc(int i, int j);

        static void Main() {
            Calc c = new Calc(Mysum);
            Console.WriteLine("1+2={0}", c(1, 2));

            Calc c1 = delegate (int i, int j) { return i + j; };
            Console.WriteLine("1+2={0}", c1(1, 2));

            Calc c2 = (i, j) => i + j;
            Console.WriteLine("1+2={0}", c2(1, 2));

        }

        static int Mysum(int i, int j)
        {
            return i + j;
        }
    }

    
}
