using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /*
     1. 임의의 수를 콤마로 구분해서 Console.ReadLine()으로 입력 받은 후 델리게이트를
     이용하여 사칙연산을 구하는 프로그램을 델리게이트 체인 및 델리게이트 멀티 캐스팅을
     이용하여 구현하세요.
     */
    delegate void myDeli(int i, int j);
    class task1
    {
        static void Main() {
            Console.Write("두 수를 콤마로 구분하여 입력하시오 : ");
            string str = Console.ReadLine();
            string[] sArr = str.Split(',');
            int[] iArr = Array.ConvertAll(sArr, i => int.Parse(i));

            myDeli callback = (myDeli)Delegate.Combine(
                new myDeli(sum),
                new myDeli(minus),
                new myDeli(mul),
                new myDeli(dvs)
                );
            myDeli callback2 = (
                new myDeli(sum)+
                new myDeli(minus)+
                new myDeli(mul)+
                new myDeli(dvs)
                );

            callback(iArr[0], iArr[1]);
            callback2(iArr[0], iArr[1]);

        }

        static void sum(int i, int j) { Console.WriteLine("{0} + {1} = {2}", i,j,i + j); }
        static void minus(int i, int j) { Console.WriteLine("{0} - {1} = {2}", i,j,i - j); }
        static void mul(int i, int j) { Console.WriteLine("{0} * {1} = {2}", i,j,i * j); }
        static void dvs(int i, int j) { Console.WriteLine("{0} / {1} = {2}", i,j,i / j); }




    }
}
