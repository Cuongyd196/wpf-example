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

namespace ToolTip
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

        private void btnToolTipsSimpleSample_Click(object sender, RoutedEventArgs e)
        {
            ToolTipsSimpleSample toolTipsSimpleSample = new ToolTipsSimpleSample();
            toolTipsSimpleSample.Show();
        }

        private void btnToolTipsAdvancedSample_Click(object sender, RoutedEventArgs e)
        {
            ToolTipsAdvancedSample toolTipsAdvancedSample = new ToolTipsAdvancedSample();
            toolTipsAdvancedSample.Show();
        }
    }
}
