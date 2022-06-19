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
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void AdminStartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminStartPage());
        }

        private void UserClick(object sender, RoutedEventArgs e)
        {
           // User user = EfModel.Init().Users.FirstOrDefault(u => u.Login == TbLogin.Text && u.Pass == TbPass.Password);
           // if (user != null)
           // {
                NavigationService.Navigate(new UserServiceListPage());
           // }
           // else
          //  {
           //     MessageBox.Show("Неправильный логин или пароль!");
           // }
        }
    }
}
