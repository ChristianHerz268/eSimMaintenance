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

namespace eOPS
{
    /// <summary>
    /// Interaktionslogik für CurrentFlight.xaml
    /// </summary>
    public partial class CurrentFlight : Window
    {
        public CurrentFlight()
        {
            InitializeComponent();
        }
        private void BtnTechnicallog_Click(object sender, RoutedEventArgs e)
        {
            TechnicalLog tlb = new TechnicalLog();
            tlb.Show();

        }
        private void btnTimesreportin_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnCrewlist_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Btnnotoc_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Btnreturn_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userwindow = new UserWindow();
            userwindow.Show();
            this.Close();
        }
    }
}
