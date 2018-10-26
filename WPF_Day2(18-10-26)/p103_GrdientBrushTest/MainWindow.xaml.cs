using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace p103_GrdientBrushTest
{
    public partial class MainWindow : Window
    {
        RadialGradientBrush brush;
        double angle;
        DispatcherTimer tmr;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Rotate the Gradient Origin";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 384; // ie, 4 inches
            Height = 384;

            brush = new RadialGradientBrush(Colors.WhiteSmoke, Colors.SaddleBrown);
            brush.Center = brush.GradientOrigin = new Point(0.5, 0.5);
            brush.RadiusX = brush.RadiusY = 0.10;
            brush.SpreadMethod = GradientSpreadMethod.Repeat;
            Background = brush;

            // 타이머
            tmr = new DispatcherTimer();
            tmr.Interval = TimeSpan.FromMilliseconds(100);
            tmr.Tick += TimerOnTick;
            tmr.Start();
        }
        void TimerOnTick(object sender, EventArgs args)
        {
            Point pt = new Point(0.5 + 0.05 * Math.Cos(angle),
            0.5 + 0.05 * Math.Sin(angle));
            brush.GradientOrigin = pt;
            angle += Math.PI / 6; // ie, 30 degrees
        }
        protected override void OnMouseDown(MouseButtonEventArgs args)
        {
            tmr.Stop();
        }
    }
}
