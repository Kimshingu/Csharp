using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(",를 기준으로 정렬할 숫자를 입력하세요. : ");
            string s = Console.ReadLine();
            string[] sArr = s.Split(',');
            int[] iArr = Array.ConvertAll(sArr, i => int.Parse(i));

            for (int i = 1; i < iArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (iArr[j] > iArr[i])
                    {
                        int tmp = iArr[i];
                        iArr[i] = iArr[j];
                        iArr[j] = tmp;
                    }
                }

            foreach (int i in iArr)
            {
                Console.Write("{0} ", i);
            }

            int minindex;
            for (int i = 0; i < iArr.Length - 1; i++)
            {
                minindex = iArr[i];

                for (int j = i + 1; j < iArr.Length; j++)
                {
                    if (iArr[j] < minindex)
                    {
                        minindex = iArr[j];

                        int tmp = iArr[i];
                        iArr[i] = iArr[j];
                        iArr[j] = tmp;

                    }
                }
            }
            foreach (int k in iArr)
            {
                Console.Write("{0} ", k);
            }



        }
    }
}
