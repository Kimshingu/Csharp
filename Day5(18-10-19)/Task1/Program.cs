using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. 콤마로 구분해서 야러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.
            Console.WriteLine("콤마를 구분으로 합할 수를 입력하세요. 예)2,3,4");
            int[] iArr = Array.ConvertAll(Console.ReadLine().Split(','), i => int.Parse(i));
            int sum = 0;
            for (int i = 0; i < iArr.Length; i++) {
                sum += iArr[i];
            }
            Console.WriteLine("모든 수를 더한 값은 {0}입니다.",sum); 
            

            // 2.하나의 숫자를 입력받아서 홀수 / 짝수를 판정하세요.
            Console.Write("하나의 숫자를 입력해주세요 :");
            int addEven = int.Parse(Console.ReadLine());
            if (addEven % 2 == 0 && addEven !=0) { Console.Write("짝수입니다."); }
            else if (addEven % 2 == 1) { Console.Write("홀수입니다."); }
            else { Console.Write("0을 입력하셨습니다."); }
            

            // 3.사용자로 부터 두수를 입력받아 변수에 넣고 변수값을 뒤짚어서 출력
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1; num1 = num2; num2 = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();

            4.아래와 같이 출력하는 프로그램을 작성하세요.
            *
            ***
            *****
            
            string star = "*";
            int count = -1;
            for (int i = 0; i < 3;i++) {
                count += 2;
                for (int j = 0; j < count;j++)
                {
                    Console.Write("{0}", star);
                }
                Console.WriteLine();
            }

            5. 실행결과가 아래와 같다.
 
            Enter a Number : 123
            Reverse of Entered Number : 321
            
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {

                int nam = num % 10;
                double pow;
                string mokTostring = (num / 10) + "";
                if (mokTostring == "0") pow = 0; else pow = mokTostring.Length;
                double chasu = nam * Math.Pow(10, pow) ;
                reverse += (int)chasu;
                num /= 10;

            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
            Console.WriteLine();

            6. 사용자로 부터 하나의 수를 입력받고 
            그수까지의 소수의 합을 구하는 프로그램을 작성하세요.
            
            Console.Write("하나의 숫자를 입력해주세요 :");
            int num = int.Parse(Console.ReadLine());
            int sum =1, count =0;
            int[] sosu = new int[num]; //int 배열 생성
            for (int i = 0; i < num; i++) { sosu[i] = 1 + i; } //배열 초기화

            Console.Write("소수 :");
            for (int i = 1; i < num; i++){ 
                for (int j = 1; j <= sosu[i]; j++) {
                    int tmp = sosu[i];
                    if (tmp % j == 0) { count ++; } 
                }
                if (count == 2)
                {
                    sum += sosu[i];
                    Console.Write("{0} ", sosu[i]);
                }
                count = 0;
            }
            //foreach (int i in sosu) { Console.WriteLine(i); }
            Console.WriteLine();
            Console.WriteLine("소수의 합은 {0} 입니다", sum);
            */


        }
    }
}
