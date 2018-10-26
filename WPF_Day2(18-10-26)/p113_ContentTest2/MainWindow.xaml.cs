using System.Text;
using System.Windows;
using System.Windows.Input;

namespace p113_ContentTest2
{
    public partial class MainWindow : Window
    {
        StringBuilder s;

        public MainWindow()
        {
            InitializeComponent();

            Title = "사용자 입력을 Window의 Content 속성에 매핑하기";
            s = new StringBuilder("");
            Content = s;
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            string str = Content.ToString();

            if (e.Text == "\b")
            {
                if (str.Length > 0) s.Remove(s.Length - 1, 1); //글자삭제
            }
            else { s.Append(e.Text); }

            Content = null;
            Content = s;
        }
    }
}
