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

namespace Static_methods
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

        private void btnLeapYear_Click(object sender, RoutedEventArgs e)
        {

            lblLeapYear.Content = LeapYear.IsLeapYear(Convert.ToInt32(txtLeapYear.Text));
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblConversion.Content = EuroConversion.ToEuro(Convert.ToDecimal(txtConversion.Text)).ToString("F2") + " \u20AC" + Environment.NewLine + EuroConversion.ToBEF(Convert.ToDecimal(txtConversion.Text)).ToString("F2") + " BEF";
        }
    }
}
