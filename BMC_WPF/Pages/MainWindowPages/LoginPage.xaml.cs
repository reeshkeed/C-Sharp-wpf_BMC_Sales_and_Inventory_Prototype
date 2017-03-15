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

namespace BMC_WPF.Pages.MainWindowPages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mwin = new MainWindow();

            if (txtUsername.Text.ToLower() == "o")
            {
                new OwnerWindow().Show();
                Mwin.Close();
            }
            else if (txtUsername.Text.ToLower() == "c")
            {
                new CustomersWindow().Show();
                Mwin.Close();
            }else
            {
                new CustomersWindow().Show();
                Mwin.Close();
            }
            
        }

        private void btnSignUpNow_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainWindowPages/SignupPage.xaml", UriKind.RelativeOrAbsolute)); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
