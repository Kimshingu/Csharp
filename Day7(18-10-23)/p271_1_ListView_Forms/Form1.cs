using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p271_1_ListView_Forms
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        public class Actress
        {
            public string name;
            public int year;

            public Actress(string name, int year)
            {
                this.name = name;
                this.year = year;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Actress> actresses = new List<Actress>();
            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            foreach (Actress act in actresses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString()); // 하나의 아이템으로 묶음
                lv.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ListView lv = (ListView)sender;
            ListView lv = sender as ListView;

            if (lv.Sorting == SortOrder.Ascending)
            {
                lv.Sorting = SortOrder.Descending;
            }
            else
            {
                lv.Sorting = SortOrder.Ascending;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string born = lv.SelectedItems[0].SubItems[1].Text;
            sb.Text = name + "," + born;
        }
    }
}
