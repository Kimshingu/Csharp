using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    interface Dog
    {
        string name { get; set; }
        //public virtual void jitda()
        //{
        //Console.WriteLine(name + "가 짖다.");
        //}
        void jitda();
    }

    public class Pudle : Dog
    {
        public string name { get; set; }
        public void work() { Console.WriteLine(name + "가 일한다."); }
        public void jitda() {Console.WriteLine(name + "  푸들푸들~");}
        
    }

    public class Jindo : Dog
    {
        public string name { get; set; }
        public void jitda() {Console.WriteLine(name + "  진도진도~~");}
        public void run() { Console.WriteLine(name + "가 달린다."); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).work();

            Dog j = new Jindo();
            j.name = "진도이";
            j.jitda();
            ((Jindo)j).run();
        }
    }
}
