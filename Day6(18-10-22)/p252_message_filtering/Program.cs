using System;
using System.Windows.Forms;

namespace p252_message_filtering
{
    class OnjMessageFilter : IMessageFilter {
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_SYSKEYDOWN = 0x0104;

            if (m.Msg == WM_SYSKEYDOWN)
            {
                bool alt = ((int)m.LParam & 0x20000000) != 0;
                if (alt && (m.WParam == new IntPtr((int)Keys.F4)))
                    Console.WriteLine("ALT+F4 Filtering됨.");
                return true; // 이벤트를 처리했으니 뒤쪽으로 넘기지 않는다.
            }

            if (m.Msg == 0x201)
            {
                Console.WriteLine("필터링됨");
                return true;
            }
            return false;
        }


    }

    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += new EventHandler(
                    (object sender, EventArgs e) =>
                    {
                        Console.WriteLine("클릭 이벤트 발생");
                        Application.Exit();
                    }
                );
            Application.Run(p);
        }
    }
}
