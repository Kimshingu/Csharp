
using System;

namespace Akadia.NoDelegate
{
    /*
    델리게이트를 사용하여 호출하는 예제로 재작성 하세요.
    1. 델리게이트를 별도로 선언하여
    2. Action 델리게이트를 이용하여 
    */
    delegate void Deli();

    public class MyClass
    {
        public void Process()
        {
            Console.WriteLine("Process() begin");
            Console.WriteLine("Process() end");
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Deli d0 = myClass.Process;
            d0();

            Action d1 =  myClass.Process;
            d1();
        }
    }
}

