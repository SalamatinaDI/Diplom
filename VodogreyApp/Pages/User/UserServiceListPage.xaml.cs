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
using VodogreyApp.Pages.User.Product;

namespace VodogreyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserServiceListPage.xaml
    /// </summary>
    public partial class UserServiceListPage : Page
    {
        public UserServiceListPage()
        {
            InitializeComponent();
        }

        private void BoilerClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BoilerListPage());
        }

        private void WaterHeatingClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WaterHeatingListPage());
        }

        private void ConvectorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ConvectorListPage());
        }

        private void TowelDryerClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TowelDryerListPage());
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {

        }

        private void BtStartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
    }
}