using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10;
            int b = a;
            int c = 50000;
            try
            {
                short d = checked((short)c);
                Console.WriteLine("short: {0}", d);
            }
            catch (Exception e) {
                Console.WriteLine("예외: {0}", e.StackTrace);
                Console.WriteLine("예외: "+ e.StackTrace);
            }

            var i = 999; 
            // Var는 동일한 문에서 지역 변수를 선언하고 초기화하는 경우에만 사용할 수 있다. 
        }
    }
}
