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
using System.IO;

namespace eOPS
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

      {

        public string user;
        public MainWindow()
        {
            InitializeComponent();
            Networksetup network = new Networksetup();
            network.network();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TBUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void TBPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
        
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.Show();
            
            UserOutput.Content = user;

            StreamWriter s = new StreamWriter("u.txt");
            s.Write(TBUserid.Text);
            s.Close();
            //this.Close(); // Close this window
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            
        }
        private void TBUserid_TextChanged(object sender, TextChangedEventArgs e)
        {
            user=TBUserid.Text;
            
        }
        private void TBPasswort_TextChanged(object sender, TextChangedEventArgs e)
        {
         
            
        }
       
    }
}
