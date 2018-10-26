using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace p134_PanelTest3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Meet the Dockers";
            DockPanel dock = new DockPanel();
            Content = dock;

            // 메뉴
            Menu menu = new Menu();
            MenuItem item = new MenuItem();
            item.Header = "Menu";
            MenuItem item1 = new MenuItem();
            item1.Header = "File";
            item.Items.Add(item1);
            menu.Items.Add(item);

            // 상단에 메뉴 추가
            DockPanel.SetDock(menu, Dock.Top);
            dock.Children.Add(menu);

            // 툴바
            ToolBar tool = new ToolBar();
            tool.Header = "Toolbar";

            // 상단에 툴바 추가
            DockPanel.SetDock(tool, Dock.Top);
            dock.Children.Add(tool);

            // 상태바
            StatusBar status = new StatusBar();
            StatusBarItem statitem = new StatusBarItem();
            statitem.Content = "Status";
            status.Items.Add(statitem);

            //아래에 상태 바 추가
            DockPanel.SetDock(status, Dock.Bottom);
            dock.Children.Add(status);

            // 리스트박스
            ListBox lstbox = new ListBox();
            lstbox.Items.Add("List Box Item");

            // 좌측에 리스트 박스 추가
            DockPanel.SetDock(lstbox, Dock.Left);
            dock.Children.Add(lstbox);

            // 텍스트 박스
            TextBox txtbox = new TextBox();
            txtbox.AcceptsReturn = true;

            // 텍스트박스가 마지막 자식으로 나머지 부분을 다 채운다.
            // LstChildFill의 기본값은 true 이다.
            dock.Children.Add(txtbox);
            txtbox.Focus();
        }
    }
}
