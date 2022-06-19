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
    /// Логика взаимодействия для BoilerListPage.xaml
    /// </summary>
    public partial class BoilerListPage : Page
    {
        bool IsDataUpdate = false;
        public BoilerListPage()
        {
            InitializeComponent();
            CbSort.Items.Add("▲Стоимость");
            CbSort.Items.Add("▼Стоимость");
            CbSort.Items.Add("▲Наименование");
            CbSort.Items.Add("▼Наименование");
            CbSort.SelectedIndex = 0;

            IsDataUpdate = true;

            UpdateData();
        }
        private void UpdateData()
        {
            IEnumerable<Boiler> boilers = EfModel.Init().Boilers
                .Where(s =>
                s.TitleB.Contains(TbSearch.Text) ||
                s.ArticleNumberB.Contains(TbSearch.Text) ||
                s.DescriptionB.Contains(TbSearch.Text));

            switch (CbSort.SelectedIndex)
            {
                case 0:
                    boilers = boilers.OrderBy(s => s.CostB);
                    break;
                case 1:
                    boilers = boilers.OrderByDescending(s => s.CostB);
                    break;
                case 2:
                    boilers = boilers.OrderBy(s => s.TitleB);
                    break;
                case 3:
                    boilers = boilers.OrderByDescending(s => s.TitleB);
                    break;
            }

            LvBoiler.ItemsSource = boilers.ToList();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserServiceListPage());
        }

        private void CartClick(object sender, RoutedEventArgs e)
        {

        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }

        private void TbSearchChange(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void CbSortChange(object sender, SelectionChangedEventArgs e)
        {
            if (IsDataUpdate)
                UpdateData();
        }
    }
}
