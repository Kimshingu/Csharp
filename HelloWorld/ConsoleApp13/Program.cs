using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. 다음과 같은 결과를 출력하는 C# 프로그램을 작성하세요.
             2 4 6 8 10
            */
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) Console.Write("{0} ", i);

            }

            Console.WriteLine();


            /*
            2. 숫자를 입력하면 다음과 같이 출력하는 C# 프로그램을 작성하세요. 
            [출력]
            입력숫자 : 10
            10까지의 숫자 : 1 2 3 4 5 6 7 8 9 10
            10까지의 숫자합은 : 55
            */
            string str = Console.ReadLine();
            int num = int.Parse(str);
            Console.Write("{0}까지 숫자:", num);

            for (int i = 1; i <= num; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("{0}까지 숫자합은 {1}", num, sum);


            /*
           3. 10개의 숫자를 입력받아 입력받은 수를 출력하고 합, 평균을 구해 출력하세요. 
            Input the 10 numbers :
            숫자-1 :1
            숫자-2 :2
            숫자-3 :3
            숫자-4 :4
            숫자-5 :5
            숫자-6 :6
            숫자-7 :7
            숫자-8 :8
            숫자-9 :9
            숫자-10 :10
            합 : 55
            평균 : 5.5

             */
            int[] arr = new int[10];
            sum = 0;
            for (int i = 0; i < 10; i++) {
                Console.Write("숫자{0}:", i+1);
                string arg = Console.ReadLine();
                arr[i] = int.Parse(arg);
                sum += arr[i];
            }

            Console.WriteLine("합: {0}", sum);
            Console.WriteLine("평균: {0}", sum/10.0);


            /*
           4. 다음과 같이 출력결과를 만들어내는 C# 프로그램을 작성하세요.
            출력을 원하는 구구단 단수 : 3
            1x2 = 2, 2x2 = 4, 3x2 = 6
            1x3 = 3, 2x3 = 6, 3x3 = 9
            1x4 = 4, 2x4 = 8, 3x4 = 12
            1x5 = 5, 2x5 = 10, 3x5 = 15
            1x6 = 6, 2x6 = 12, 3x6 = 18
            1x7 = 7, 2x7 = 14, 3x7 = 21
            1x8 = 8, 2x8 = 16, 3x8 = 24
            1x9 = 9, 2x9 = 18, 3x9 = 27
             */
            Console.Write("출력을 원하는 구구단 단수:  ");
            string dansu = Console.ReadLine();
            int k = int.Parse(dansu);
            for (int i =2; i<10;i++ ) {
                for (int j=1; j<=k;j++) {
                    if(j==k) Console.Write("{0}x{1} = {2} ", j, i, j * i);
                    else Console.Write("{0}x{1} = {2}, ",j,i,j*i);
                }
                Console.WriteLine();
            }

        }
    }
}
