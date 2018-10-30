using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
namespace p294_TriggerSwitch
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Thread.Sleep(1000);
            Button btn = args.Source as Button;
            MessageBox.Show(btn.Content + " has been clicked", Title);
        }
    }
}
