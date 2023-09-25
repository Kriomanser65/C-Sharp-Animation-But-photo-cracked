using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var angle = 360.0 / 5;
            Canvas.SetLeft(img1, 150 + 100 * Math.Cos(0));
            Canvas.SetTop(img1, 150 + 100 * Math.Sin(0));

            Canvas.SetLeft(img2, 150 + 100 * Math.Cos(angle));
            Canvas.SetTop(img2, 150 + 100 * Math.Sin(angle));

            Canvas.SetLeft(img3, 150 + 100 * Math.Cos(2 * angle));
            Canvas.SetTop(img3, 150 + 100 * Math.Sin(2 * angle));

            Canvas.SetLeft(img4, 150 + 100 * Math.Cos(3 * angle));
            Canvas.SetTop(img4, 150 + 100 * Math.Sin(3 * angle));

            Canvas.SetLeft(img5, 150 + 100 * Math.Cos(4 * angle));
            Canvas.SetTop(img5, 150 + 100 * Math.Sin(4 * angle));

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            rotator.Angle += 1;
        }
    }
}
