using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p106
{
    class Test<T>
    {
        public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }
    }

    class TestMain
    {
        static void Main(string[] args)
        {
            Test<double> t = new Test<double>();
            double i = 10.2, j = 20.2;
            Console.WriteLine("{0} + {1} = {2}", i, j, t.Sum(i, j));

        }
    }

}
