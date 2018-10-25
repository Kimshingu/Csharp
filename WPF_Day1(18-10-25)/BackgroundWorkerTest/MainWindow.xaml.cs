using System;
using System.ComponentModel;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace BackgroundWorkerTest
{
    public partial class MainWindow : Window
    {
        private BackgroundWorker myThread;

        int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            myThread = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            myThread.DoWork += myThread_DoWork;

            myThread.ProgressChanged += myThread_ProgressChanged;
            myThread.RunWorkerCompleted += myThread_RunWorkerCompleted;

            MessageBox.Show("Worker 초기화");
        }

        private void myThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument;
            for(int i =1; i<=count; i++)
            {


            }



        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
