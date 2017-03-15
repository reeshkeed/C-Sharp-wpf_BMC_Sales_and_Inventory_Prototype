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

namespace BMC_WPF
{
    /// <summary>
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow
    {
        public OrderWindow()
        {
            InitializeComponent();

            hideMember();
        }

        public void hideMember()
        {
            btnLogGuest.Visibility = Visibility.Hidden;
            grbLogin.Visibility = Visibility.Hidden;

            btnLogMember.Visibility = Visibility.Visible;
            grbLoginGuest.Visibility = Visibility.Visible;
        }

        public void hideGuest()
        {
            btnLogMember.Visibility = Visibility.Hidden;
            grbLoginGuest.Visibility = Visibility.Hidden;

            btnLogGuest.Visibility = Visibility.Visible;
            grbLogin.Visibility = Visibility.Visible;
        }

        private void btnLCont_Click(object sender, RoutedEventArgs e)
        {
            tbcOrderWindow.SelectedItem = tbItemShipping;
        }

        private void btnSCont_Click(object sender, RoutedEventArgs e)
        {
            tbcOrderWindow.SelectedItem = tbItemPayment;
        }

        private void btnLogMember_Click(object sender, RoutedEventArgs e)
        {
            hideGuest();
        }

        private void btnLogGuest_Click(object sender, RoutedEventArgs e)
        {
            hideMember();
        }

    }
}
