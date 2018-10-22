using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


class Program :Form
{
    static void Main(string[] args)
    {
        Program form = new Program();
        form.Click += new EventHandler(
            (object sender, EventArgs e) =>
            {
                Console.WriteLine("폼클릭 이벤트...");
                Application.Exit();
            });
        Console.WriteLine("윈도우 시작");
        Application.Run(form);
        Console.WriteLine("윈도우 종류");

    }
    /*
    void Form_Click(object sender, EventArgs e) {
        Console.WriteLine("폼클릭 이벤트...");
        Application.Exit();
    }
    */


}

