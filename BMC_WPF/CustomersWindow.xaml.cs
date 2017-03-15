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
using BMC_WPF.Pages.MainWindowPages;

namespace BMC_WPF
{
    /// <summary>
    /// Interaction logic for CustomersWindow.xaml
    /// </summary>
    public partial class CustomersWindow
    {
        public CustomersWindow()
        {
            InitializeComponent();
        }

        MainWindow main = new MainWindow();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            new OrderWindow().Show();
        }

        private void btnLoginC_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Close();
            main.MainFrame.Navigate(new LoginPage());
            
        }

        private void btnSignupC_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            main.MainFrame.Navigate(new SignupPage());
        }

        private void btnLogoutC_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LooksLikeALabel_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Close();
            main.MainFrame.Navigate(new LoginPage());
        }
    }
}
