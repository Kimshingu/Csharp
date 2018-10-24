using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections;
using System.Text;
using System.Windows.Forms;


namespace ChatServer
{
    delegate void SetTextCallback(string s);

    public partial class Form1 : Form
    {
        
        TcpListener lit_Listener = new TcpListener(IPAddress.Parse("192.168.0.213"), 5001);
        public static ArrayList soketArray = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        public void SetText(string text) {

            if (this.txt_Chat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else {
                this.txt_Chat.AppendText(text);
            }
        }

        private void cmd_Start_Click(object sender, EventArgs e)
        {

            if (lbl_Message.Tag.ToString() == "Stop")
            {
                lit_Listener.Start();
                Thread thd_WaitSocket = new Thread(new ThreadStart(Wait_Socket));
                thd_WaitSocket.Start();
                lbl_Message.Text = "Server Start 상태 입니다.";
                lbl_Message.Tag = "Start";
                cmd_Start.Text = "Server Stop";
                cmd_Start.BackColor = System.Drawing.Color.Red;
            }
            
            else
            {
                lit_Listener.Stop();
                foreach (Socket soket in Form1.soketArray)
                {
                    soket.Close();
                }
                Form1.soketArray.Clear();
                lbl_Message.Text = "Server Stop 상태 입니다.";
                lbl_Message.Tag = "Stop";
                cmd_Start.Text = "Server Start";
                cmd_Start.BackColor = System.Drawing.Color.Green;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            lit_Listener.Stop();
        }

        private void Wait_Socket()
        {
            Socket sktClient = null;
            while (true)
            {
                try
                {
                    sktClient = lit_Listener.AcceptSocket();
                    Chat_Class cht_Class = new Chat_Class();
                    cht_Class.Chat_Class_Setup(this, sktClient, this.txt_Chat);
                    Thread thd_ChatProcess = new Thread(new ThreadStart(cht_Class.Chat_Process));
                    thd_ChatProcess.Start();
                }
                catch (System.Exception)
                {
                    Form1.soketArray.Remove(sktClient); break;
                }
            }
        }
    }

    public class Chat_Class
    {
        private Encoding ecd_Encode = Encoding.GetEncoding("KS_C_5601-1987");
        private TextBox txt_Chat;
        private Socket sktClient;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;

        public void Chat_Class_Setup(Form1 form1, Socket sktClient, TextBox txt_Chat)
        {
            this.txt_Chat = txt_Chat;
            this.sktClient = sktClient;
            this.netStream = new NetworkStream(sktClient);
            Form1.soketArray.Add(sktClient);
            this.strReader = new StreamReader(netStream, ecd_Encode);
            this.form1 = form1;

        }

        public void Chat_Process()
        {
            while (true)
            {
                try
                {
                    string lstMessage = strReader.ReadLine();
                    if (lstMessage != null && lstMessage != "")
                    {
                        form1.SetText(lstMessage + "\r\n");
                        byte[] bytSand_Data = Encoding.Default.GetBytes(lstMessage+ "\r\n");

                        ArrayList remove_soketArray = new ArrayList();
                        lock (Form1.soketArray)
                        {
                            foreach (Socket soket in Form1.soketArray)
                            {
                                NetworkStream stream = new NetworkStream(soket);
                                stream.Write(bytSand_Data, 0, bytSand_Data.Length);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Form1.soketArray.Remove(sktClient);
                    break;
                }
            }
        }
    }
}
