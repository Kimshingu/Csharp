using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Emp
    {
        // 같은 어셈블리(프로젝트) 안에서 접근가능하다.
        // public > internal > protected > private(defult)
        //string name; //멤버,필드
        public string Name {
            get;
            set;
        }

        //public void SetName(String name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return this.name;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name = "KIM";
            Console.WriteLine(e.Name);
        }
    }

    

}
