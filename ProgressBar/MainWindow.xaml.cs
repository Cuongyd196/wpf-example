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

namespace ProgressBar
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

        private void btnProgressBarSample_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarSample progressBarSample = new ProgressBarSample();
            progressBarSample.Show();
        }

        private void btnTaskOnUiThread_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarTaskOnUiThread progressBarTaskOnUiThread = new ProgressBarTaskOnUiThread();
            progressBarTaskOnUiThread.Show();

        }

        private void btnTaskOnWorkerThread_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarTaskOnWorkerThread progressBarTaskOnWorkerThread = new ProgressBarTaskOnWorkerThread();
            progressBarTaskOnWorkerThread.Show();
        }

        private void btnIndeterminateSample_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarIndeterminateSample progressBarIndeterminateSample = new ProgressBarIndeterminateSample();
            progressBarIndeterminateSample.Show();
        }

        private void btnTextSample_Click(object sender, RoutedEventArgs e)
        {
            ProgressBarTextSample progressBarTextSample = new ProgressBarTextSample();
            progressBarTextSample.Show();
        }
    }
}
