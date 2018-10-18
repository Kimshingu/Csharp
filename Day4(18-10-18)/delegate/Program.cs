using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    public class Program
    {

        static void Main(string[] args)
        {
            Action<int, int> myMethod =
                (i,j) => Console.Write("{0}", i + j);
            Console.Write("두수 합:");
            myMethod(10,30);
        }

         
    }
}
