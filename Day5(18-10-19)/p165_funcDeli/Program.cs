using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p165_funcDeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine(func1());

            Func<int, int> func2 = (x) => x * x;
            Console.WriteLine("func2 :: {0}", func2(2));

            //Func<T, Tresult>에 람다식 할당
            Func<string, string> func3 = (str) => str.ToUpper();
            Console.WriteLine("func3 :: {0}", func3("oraclejavacommunity"));

            //Func<T, TResult>에 delegate할당, 문자열을 문자배열로 리턴
            Func<string, char[]> func4 = delegate (string str) { return str.ToArray(); };
            Console.WriteLine("func4 :: 배열크기={0}, 처음요소={1}", 
                func4("oraclejavacommunity").Count(), func4("oraclejavacommunity ")[0]);

            //Func<T, TResult>에서 함수를 지정
            Func<string, string> func5 = convertUpper;
            Console.WriteLine("onj를 대문자로 {0}", func5("onj"));

            Func<string, string> func6 = (str) => str.ToLower();

            string[] onjs = { "ONJ", "ORACLEJAVA", "ORACLEJAVACOMMUNITY.CO.KR" };
            IEnumerable<String> onjWords = onjs.Select(func6);

            foreach (string word in onjWords) Console.WriteLine(word);

            IEnumerable<int> squares =
            Enumerable.Range(1, 5).Select(x => x * x);

            System.Type type = squares.GetType();
            Console.WriteLine(squares);
            //System.Linq.Enumerable+WhereSelectEnumerableIterator`2[System.Int32,System.Int32]

            System.Type type2 = onjWords.GetType();
            Console.WriteLine(onjWords); 
            //System.Linq.Enumerable+WhereSelectArrayIterator`2[System.String,System.String]


            Type type3 = typeof(Program);
            Console.WriteLine(type3);

            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }

        }
        static string convertUpper(string str) { return str.ToUpper(); }
    }
}
