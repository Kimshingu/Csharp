using System;
using System.ComponentModel;
using System.Windows.Input;


namespace WpfOracleTest
{
    public class EmpViewModel
    {
        int empno = 0;
        string ename = string.Empty;
        string job = string.Empty;

        public int Empno
        {
            get { return empno; }
            set { this.empno = value; }
        }
        public string Ename { get; set; }
        public string Job { get; set; }
    }
}
