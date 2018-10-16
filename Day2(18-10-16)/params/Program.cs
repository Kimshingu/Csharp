using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //명명된 인수
            Console.WriteLine(p.sum2(j:1, i:2));
            Console.WriteLine(p.sum2());
        }

        static int sum(params int[] iArray)
        {
            int sum = 0;
            foreach (int i in iArray) sum += i;
            return sum;
        }

        int sum2(int i = 0 , int j = 0 ) //선택적 인수
        {
            return i+j;
        }
    }



}
