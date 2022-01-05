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
using System.IO;

namespace eOPS
{
    /// <summary>
    /// Interaktionslogik für UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {

        public UserWindow()
        {
            InitializeComponent();
            DisplayFrame.Content = new DutyPlan();
            Networksetup networks = new Networksetup();
            networks.network();
            LoadPilotName();
        
        }
        
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void BtnFlightReport_Click(object sender, RoutedEventArgs e)
        {
            DisplayFrame.Content = new FlightReport();
        }

        private void BtnCheckin_Click(object sender, RoutedEventArgs e)
        {
            FlightCheckIn flightCheckin = new FlightCheckIn();
            flightCheckin.Show();
            this.Close();

        }

        private void BtnFuelorder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTlb_Click(object sender, RoutedEventArgs e)
        {
            //Selecting Windows for opening new TLBs for different aircrafts
            SelectTLB selecttlb = new SelectTLB();
            selecttlb.Show();
        }

        private void LBPilotName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
        public void LoadPilotName()
        {
            System.Threading.Thread.Sleep(1000);
            
            StreamReader SR = new StreamReader("u.txt");
            while (!SR.EndOfStream)
            {
                string pilotnamr = SR.ReadLine();
                LBPilotName.Items.Add(pilotnamr);
            }
            SR.Close();
        }
    }
}
