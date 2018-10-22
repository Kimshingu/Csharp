using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = oneToTen.Where(n => n % 2 == 0);

            foreach (int i in evenNumbers)
                Console.Write("{0} ", i);

        }
    }
}
