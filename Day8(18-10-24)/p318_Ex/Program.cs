using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace p318_Ex
{
    class Program
    {
        static void Main()
        {
            string str = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
            (CONNECT_DATA =
            (SERVER = DEDICATED)
            (SERVICE_NAME = topcredu)
            )) ; User Id = scott; Password = tiger";

            OracleConnection Conn = new OracleConnection(str);
            Conn.Open();

            OracleDataAdapter adapter = new OracleDataAdapter("select * from emp order by empno", Conn);
            DataSet ds = new DataSet("myemp");
            adapter.Fill(ds, "사원");

            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"],
                r["ename"], r["sal"]);
            }


            ds.Tables["사원"].Rows[0]["ename"] = "김신구";

            // 어뎁터에 커맨드를 만들어준다.
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds, "사원");

            Console.WriteLine("-------------------------------------");
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("empno: {0}, ename : {1}, sal:{2}",
                    r["empno"], r["ename"], r["sal"]);
            }

            DataRow row = ds.Tables["사원"].NewRow();
            row["empno"] = 9559; row["ename"] = "87길동"; row["sal"] = 7777;

            ds.Tables["사원"].Rows.Add(row);

            //adapter.Update(ds, "사원");

            adapter = new OracleDataAdapter("select * from emp order by empno", Conn);
            adapter.Fill(ds, "사원");

            Console.WriteLine("-------------------------------------");
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
               r["sal"]);
            }
            Console.WriteLine(" 총 {0} 건 입니다.", ds.Tables["사원"].Rows.Count);
        }
    }
}
