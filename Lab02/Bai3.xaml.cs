using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Interaction logic for Bai3.xaml
    /// </summary>
    public partial class Bai3 : Window
    {
        public Bai3()
        {
            InitializeComponent();
            txtNhapTen.Focus();
        }

        private void check_NhapTen()
        {
            if (txtNhapTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                txtNhapTen.Focus();
                return;
            }
        }
        private void radioBtnBlack_Checked(object sender, RoutedEventArgs e)
        {
            check_NhapTen();
            // Lấy ra tên được nhập từ textbox txtNhapTen và gán vào label: lblTen
            textblockTen.Text = txtNhapTen.Text;
            // Đặt màu chữ là Black
            lblLapTrinh.Foreground = Brushes.Black;
            lblTen.Foreground = Brushes.Black;
        }

        private void radioBtnOrange_Checked(object sender, RoutedEventArgs e)
        {
            check_NhapTen();
            // Lấy ra tên được nhập từ textbox txtNhapTen và gán vào label: lblTen
            textblockTen.Text = txtNhapTen.Text;
            // Đặt màu chữ là Orange
            lblLapTrinh.Foreground = Brushes.Orange;
            lblTen.Foreground = Brushes.Orange;
        }

        private void txtNhapTen_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void cbBold_Checked(object sender, RoutedEventArgs e)
        {
            lblLapTrinh.FontWeight = FontWeights.Bold;
            lblTen.FontWeight = FontWeights.Bold;
        }

        private void cbItalic_Checked(object sender, RoutedEventArgs e)
        {
            lblLapTrinh.FontStyle = FontStyles.Italic;
            lblTen.FontStyle = FontStyles.Italic;
        }

        private void cbUnderline_Checked(object sender, RoutedEventArgs e)
        {
            textblockLaptrinh.TextDecorations = TextDecorations.Underline;
            textblockTen.Text = txtNhapTen.Text;
            textblockTen.TextDecorations = TextDecorations.Underline;
        }

        private void cbBold_Unchecked(object sender, RoutedEventArgs e)
        {
            lblLapTrinh.FontWeight = FontWeights.Normal;
            lblTen.FontWeight = FontWeights.Normal;
        }

        private void cbItalic_Unchecked(object sender, RoutedEventArgs e)
        {
            lblLapTrinh.FontStyle = FontStyles.Normal;
            lblTen.FontStyle = FontStyles.Normal;
        }

        private void cbUnderline_Unchecked(object sender, RoutedEventArgs e)
        {
            textblockLaptrinh.TextDecorations = null;
            textblockTen.Text = txtNhapTen.Text;
            textblockTen.TextDecorations = null;
        }
    }
}
