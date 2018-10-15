using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MYConstanrt
    {
        public const double PI = 3.14; // java의 static final
        public const int MYAGE = 28;
    }
    class Program
    {
        static void Main(string[] args)
        {   
            double radius = 2;
            double area = MYConstanrt.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age={1}", area, MYConstanrt.MYAGE);

            const String name = "홍길동";
            Console.WriteLine("name = " + name);

        }
    }
}
