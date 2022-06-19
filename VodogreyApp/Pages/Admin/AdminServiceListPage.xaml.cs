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
using VodogreyApp.Pages.Admin;

namespace VodogreyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminServiceListPage.xaml
    /// </summary>
    public partial class AdminServiceListPage : Page
    {
        public AdminServiceListPage()
        {
            InitializeComponent();
        }

        private void AdminWaterHeatingClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminWaterHeatingListPage());
        }

        private void AdminConvectorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminConvectorListPage());
        }

        private void AdminBoilerClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminBoilerListPage());
        }

        private void AdminTowelDryerClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminTowelDryerListPage());
        }

        private void BtStartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }
    }
}
