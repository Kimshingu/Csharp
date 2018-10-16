using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_18_10_16_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int mok = int.Parse(str);
            string na = "";

            /*
            while (mok > 0) {
                na = (mok % 2) + na;
                mok = mok / 2;
            }
            */

            for (int i = mok; mok > 0; mok = mok / 2) {
                na = (mok % 2) + na;
            }

            Console.WriteLine("{0}", na);

        }
    }
}
