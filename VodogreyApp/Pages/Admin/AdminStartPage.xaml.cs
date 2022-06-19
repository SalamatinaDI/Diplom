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
using VodogreyApp.DataBase;

namespace VodogreyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminStartPage.xaml
    /// </summary>
    public partial class AdminStartPage : Page
    {
        public AdminStartPage()
        {
            InitializeComponent();
        }

        private void AdminClick(object sender, RoutedEventArgs e)
        {
            if (TbAdminCode.Text == "123")
            {
                NavigationService.Navigate(new AdminServiceListPage());
            }
            else
            {
                MessageBox.Show("Неверный код доступа!");
            }
        }
    }
}
