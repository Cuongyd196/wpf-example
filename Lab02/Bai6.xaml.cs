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
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Interaction logic for Bai6.xaml
    /// </summary>
    public partial class Bai6 : Window
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            listboxNumber.Items.Add(txtSo.Text);
            txtSo.Clear();
            txtSo.Focus();
        }
    }
}
