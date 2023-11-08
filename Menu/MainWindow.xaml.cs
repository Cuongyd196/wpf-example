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
using Menu.control;
namespace Menu
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

        private void btnTrangChu_Click(object sender, RoutedEventArgs e)
        {
            // Đặt nội dung MainContent cho Home
            MainContent.Content = new SachUserControl();
        }

        private void btnLoaiSach_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new LoaiSachUserControl();
        }

        private void btnNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new NguoiDungUserControl();
        }
    }
}
