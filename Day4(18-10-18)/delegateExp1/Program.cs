using System;

namespace delegateExp1
{
    class OnjMath {
        internal static double MultipleByTow(double value) { return value *2;}
        internal static double Square(double value) { return value * value; }
    }
    delegate double OnjDouble(double x);

    class delegateExp1 {
        static void Main() {
            OnjDouble[] op =
            {
                new OnjDouble(OnjMath.MultipleByTow),
                new OnjDouble(OnjMath.Square)
            };

            for (int i = 0; i < op.Length; i++) {
                Console.WriteLine("op[{0}] 호출:", i);
                //CallDelegate(op[i], 3.0);
                Console.WriteLine(op[i](3.0));
            }
        }
        //static void CallDelegate(OnjDouble func, double value) {
        //    double ret = func(value);
        //    Console.WriteLine("입력된 값은 {0}이고 결과는 {1} 이다", value, ret);
        //}
    }
}
