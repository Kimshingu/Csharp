using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Controls.Primitives;

namespace p153_BindingLabelToScroll
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bind = new Binding();
            bind.Source = scrollbar;
            bind.Path = new PropertyPath(ScrollBar.ValueProperty);
            label.SetBinding(Label.ContentProperty, bind);
        }
    }
}
