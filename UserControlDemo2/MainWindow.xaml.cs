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
using UserControlDemo2.control;
using UserControlDemo2.screen;
namespace UserControlDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.ShowDialog();
        }

        private void btnScreen1_Click(object sender, RoutedEventArgs e)
        {
            Screen1 screen1 = new Screen1();
            screen1.ShowDialog();
        }

        private void btnScreen2_Click(object sender, RoutedEventArgs e)
        {
            Screen2 screen2 = new Screen2();
            screen2.ShowDialog();
        }
    }
}
