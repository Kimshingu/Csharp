using System.Windows;
using System.Windows.Controls;

namespace p288_EventSetter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            MessageBox.Show(btn.Content + " has been clicked", "Title이다");
        }
    }
    
}
