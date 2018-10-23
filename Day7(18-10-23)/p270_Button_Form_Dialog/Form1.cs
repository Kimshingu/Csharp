using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p270_Button_Form_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Modle Windows";
            f.Width = 200;
            f.Height = 100;
            f.BackColor = Color.Beige;

            f.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Modleless Windows";
            f.Width = 200;
            f.Height = 100;
            f.BackColor = Color.RoyalBlue;

            f.Show();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오라클자바커뮤니티", "메시지박스",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
