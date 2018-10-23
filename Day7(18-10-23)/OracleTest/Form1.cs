using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        

        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Console.WriteLine("Form_Load OK~");
            //MessageBox.Show("Form_Load OK~");


            try {
                ds = new DataSet("emp");

                string conStr= "Provider=OraOLEDB.Oracle; data source=topcredu;" +
                    "User Id = scott; Password = tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename)" +
                    "values(9552,'Sean')", conn);
                command.ExecuteNonQuery();
                adapter = new OleDbDataAdapter("select * from emp where ename='Sean'", conn);
                adapter.Fill(ds, "EMP");
                dataGridView1.DataSource = ds.Tables["EMP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
