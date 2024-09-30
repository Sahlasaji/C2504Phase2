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

namespace Example14Project
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

       

        private void btnSolidColor_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmSolid.ShowDialog();
        }

        private void btnLinear_Gradient_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmLinearGradient.Show();
        }

        private void btnRadial_Gradient_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmRadialGradient.Show();
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmImage.Show();
        }

        private void btnVisual_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmVisual.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnStack_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmStack.Show();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmGrid.Show();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmDock.Show(); 
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmCanvas.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            FormConfig.FrmWrapPanel .Show();
        }
    }
}
