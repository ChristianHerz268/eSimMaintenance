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
using System.Windows.Media;

namespace eOPS
{
    /// <summary>
    /// Interaktionslogik für FlightCheckIn.xaml
    /// </summary>
    public partial class FlightCheckIn : Window
    {
        public FlightCheckIn()
        {
            InitializeComponent();
        }


        private void TBfltno_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btnchackin_Click(object sender, RoutedEventArgs e)
        {
            if (TBfltno.Text != "LH800")
            {
                TBfltno.Background = Brushes.Red;
                MessageBox.Show("Flight Not Fount");
                TBfltno.Background = Brushes.White;
                TBfltno.Text = "";
            }
            else
            {
                
                CurrentFlight cf = new CurrentFlight();
                cf.Show();
                this.Close();
                TBfltno.Text = "FRA-ARN";
            }
        }

        private void Btncancel_Click(object sender, RoutedEventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.Show();
            this.Close();

        }
    }
}
