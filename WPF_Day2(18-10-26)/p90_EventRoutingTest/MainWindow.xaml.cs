using System.Windows;
using System.Windows.Media;
namespace p90_EventRoutingTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
            e.Handled = true;
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
            
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
            
        }

        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
        }
    }
}
