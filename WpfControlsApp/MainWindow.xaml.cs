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

namespace WpfControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn.Background = new SolidColorBrush(Colors.Green);
            btn.FontSize = 30;
            btn.Content = "New Content";

            btn.Margin = new Thickness();

            Button btn3 = new() { Content = "AAAAAA" };
            stack.Children.Add(btn3);
        }
    }
}
