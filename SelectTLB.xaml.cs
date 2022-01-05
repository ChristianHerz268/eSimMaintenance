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
    /// Interaktionslogik für SelectTLB.xaml
    /// </summary>
    public partial class SelectTLB : Window
    {
        public SelectTLB()
        {
            InitializeComponent();
         //   CheckForUserAuthorze();      
        }

        private void CheckForUserAuthorze()
        {
            MainWindow mainWindow = new MainWindow();
            /*
            if (mainWindow.CheckLoginApproval(true))
            {
                TlbOpen.Visibility = Visibility.Visible;
            
            } if (mainWindow.CheckLoginApproval(false))
            {
                TlbOpen.Visibility = Visibility.Collapsed;
            }
            */
        }

        private void TBreg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TlbOpen_Click(object sender, RoutedEventArgs e)
        {
            

        }

        //Btn for closing this window in case for cancelation this action
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
