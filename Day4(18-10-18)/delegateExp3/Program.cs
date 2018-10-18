using System;


namespace delegateExp3
{
    class delegateExp3
    {
         delegate void Deli(string s);

        static void Main() {
            Action<string> d0 = (v) => Console.WriteLine(v);
            d0.Invoke("OJC");

            Action<string> d1 = (string v) => Console.WriteLine(v);
            d1.Invoke("OJC1");

            Action<string> d2 = delegate (string v) { Console.WriteLine(v); };
            d2.Invoke("OJC2");

            Deli d3 = new Deli(d);
            d3.Invoke("OJC3");
        }

        static void d(string s) {
            Console.WriteLine(s);
        }
    }
}
