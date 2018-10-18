using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    delegate void MyDelegate(int i);
    class EventPublisher
    {
        public event MyDelegate ClapEvent;
        public void Clap(int num) {
            if (num % 2 == 0) ClapEvent(num);
        }
    }

    class EventSub {
        static void Main() {
            EventPublisher e = new EventPublisher();
            e.ClapEvent += new EventTest.MyDelegate(Caller);

            int[] iArr = Array.ConvertAll((Console.ReadLine()).Split(','), i => int.Parse(i));
            foreach (int i in iArr) {
                e.Clap(i);

            }
        }

        static void Caller(int num)
        {
            Console.WriteLine("{0}  : 짝~", num);

        }


    }
}
