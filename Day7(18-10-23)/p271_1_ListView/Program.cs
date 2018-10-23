using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace p271_1_ListView
{
    public class Actress
    {
        public string name;
        public int year;

        public Actress(string name, int year) {
            this.name = name;
            this.year = year;
        }
    }

    class MForm: Form
    {
        private StatusBar sb;

        public MForm()
        {
            Text = "ListView"; // 타이틀
            Size = new Size(350, 300); // 윈도우 사이즈

            List<Actress> actresses = new List<Actress>();
            actresses.Add(new Actress("Jessica Alba", 1981));
            actresses.Add(new Actress("Angelina Jolie", 1975));
            actresses.Add(new Actress("Natalie Portman", 1981));
            actresses.Add(new Actress("Rachel Weiss", 1971));
            actresses.Add(new Actress("Scarlett Johansson", 1984));

            ColumnHeader name = new ColumnHeader();
            name.Text = "Name"; // 컬럼1 타이틀
            name.Width = -1;
            name.TextAlign = HorizontalAlignment.Center;

            ColumnHeader year = new ColumnHeader();
            year.Text = "Year"; // 컬럼2 타이틀
            year.TextAlign = HorizontalAlignment.Center;
            SuspendLayout();

            ListView lv = new ListView();
            lv.Parent = this;
            lv.FullRowSelect = true; 
            lv.GridLines = true; // 격자 모양의 그리드 라인
            lv.AllowColumnReorder = true; // 열 머리글을 끌어 열의 순서를 변경
            //lv.Sorting = SortOrder.Ascending;

            lv.Columns.AddRange(new ColumnHeader[] { name, year }); // 한번에 컬럼타이틀 세팅
            
            //lv.ColumnClick += new ColumnClickEventHandler(ColumnClick);
            lv.ColumnClick += ColumnClick;

            foreach (Actress act in actresses) {
                ListViewItem item = new ListViewItem();
                item.Text = act.name;
                item.SubItems.Add(act.year.ToString()); // 하나의 아이템으로 묶음
                lv.Items.Add(item);
            }

            lv.Dock = DockStyle.Fill;
            lv.Click += new EventHandler(OnChanged);

            sb = new StatusBar();
            sb.Parent = this;
            lv.View = View.Details;

            ResumeLayout();

            CenterToScreen();
        }

        void OnChanged(object sender, EventArgs e) {
            ListView lv = (ListView)sender;
            string name = lv.SelectedItems[0].SubItems[0].Text;
            string born = lv.SelectedItems[0].SubItems[1].Text;
            sb.Text = name + "," + born;
        }

        void ColumnClick(object sender, ColumnClickEventArgs e) {
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

        class MApplication {
            public static void Main() {
                Application.Run(new MForm());
            }
        }
    }
}
