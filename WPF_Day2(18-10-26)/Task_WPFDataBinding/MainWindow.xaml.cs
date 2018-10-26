using System.Windows;

namespace Task_WPFDataBinding
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        Person person = new Person { Name = "Salman", Age = 26 };

        public MainWindow()
        {
            InitializeComponent();

            //DataContext를 이용하여 소스객체로 person을 지정
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }
    }

    public class Person
    {
        private string nameValue;
        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        private double ageValue;
        public double Age
        {
            get { return ageValue; }
            set
            {
                if (value != ageValue)
                {
                    ageValue = value;
                }
            }
        }
    }

}
