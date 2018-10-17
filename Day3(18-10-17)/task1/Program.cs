using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("---------------#1");
            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4
            int[][] a = 
            { new int[] {1,2},
              new int[] {1,2,3},
              new int[] {1,2,3,4}
            };
          //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)
            int[,] b = { {1,2},{3,4 },{5,6 } };
           //가변배열 출력
             foreach(int[] i in a)
             {
                 foreach(int j in i)
                 {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
             
             //이차원 배열 출력
             foreach(int i in b)
             {
             Console.Write(i + " ");
             }

             Console.WriteLine("\n---------------#2");
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //Console.Write(twoDim.Length);
            //Console.Write(twoDim[1,1]);
            for (int i = 0; i < twoDim.GetLength(0); i++)
            {
                for (int j = 0; j < twoDim.GetLength(1); j++)
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach (int i in twoDim )
            {
                Console.Write(i);
            }

            Console.WriteLine("\n---------------#3");
            Console.WriteLine(string.Join(" ", Method())); //대한민국서울

            Console.WriteLine("---------------#4");
            string[] arr = new string[] { "가", "나", "다", "라" };
            Console.WriteLine(arr[arr.Length - 1]); //라
            Console.WriteLine(arr[arr.GetLength(0) - 1]); //라

            Console.WriteLine("---------------#3");
            // This is a zero-element int array.
            var values1 = new int[] { };
            Console.WriteLine(values1.Length); //0
            // This is a zero-element int array also.
            var values2 = new int[0];
            Console.WriteLine(values2.Length); //0

            Console.WriteLine("---------------#4");
            // Loop over array of integers.
            foreach (int id in GetEmployeeIds())
            {
                Console.WriteLine(id);
            }
            // Loop over array of integers.
            int[] employees = GetEmployeeIds();
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }

            Console.WriteLine("---------------#5");
            int[] teams = new int[3];
            teams[0] = 1;
            teams[1] = 2;
            teams[2] = 3;
            Employee employee = new Employee(teams);
            foreach (int team in employee.Teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("---------------#6");
            int[] array = new int[2]; // Create an array.
            array[0] = 10;
            array[1] = 3021;

            Test(array); // 10
            Test(null); // No output.
            Test(new int[0]); // No output.

            Console.WriteLine("---------------#7");
            char[] array2 = new char[5];
            array2[0] = 'A';
            array2[1] = 'B';
            array2[2] = 'C';
            array2[3] = 'D';
            array2[4] = 'E';
            for (int i = 0; i < array2.Length; i++)
            {
                //MessageBox.Show(array2[i].ToString());
            }

            // A,B,C 만 출력되도록 괄호를 채워 주세요.
            Array.Resize(ref array2, 3);
            for (int i = 0; i < array2.Length; i++)
            {
                //MessageBox.Show(array2[i].ToString());
            }
        }
        static string[] Method()
        {
            string[] array = new string[2];
            array[0] = "대한민국";
            array[1] = "서울";
            return array;
        }
        static int[] GetEmployeeIds()
        {
            int[] employees = new int[5];
            employees[0] = 1;
            employees[1] = 3;
            employees[2] = 5;
            employees[3] = 7;
            employees[4] = 8;
            return employees;
        }
        class Employee
        {
            int[] _teams;

            public Employee(int[] teams)
            {
                _teams = teams;
            }

            public int[] Teams
            {
                get
                {
                    return _teams;
                }
            }
        }
        static void Test(int[] array)
        {
            if (array != null &&
                array.Length > 0)
            {
                int first = array[0];
                Console.WriteLine(first);
            }
        }
    }
}
