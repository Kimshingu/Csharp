using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customAttr
{
    [AdditionalInfoAttribute("김신구","18/10/18", Download = "http://ojc.asia")]
    class Test
    {
        static void Main()
        {
            Type type = typeof(Test);
            foreach (Attribute attr in type.GetCustomAttributes(true)) {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;

                if (info != null) {
                    Console.WriteLine("Name={0}, Update={1}, DownLoad={2}",
                        info.Name, info.Update, info.Download);

                }
            }
        }     
    }
   
}

