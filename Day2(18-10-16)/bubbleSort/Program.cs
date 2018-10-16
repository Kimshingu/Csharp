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
            int[] arr = { 2, 1, 9, 4 };
            for (int i = 1; i < arr.Length; i++) {
                for (int j = 0; j < i; j++) {
                    if (arr[j] > arr[i]) {
                        int tmp = arr[i] ;
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            foreach(int i in arr) {
                Console.Write("{0} ", i);
            }
        }
    }
}
