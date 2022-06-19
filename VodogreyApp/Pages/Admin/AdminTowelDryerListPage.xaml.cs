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

namespace VodogreyApp.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminTowelDryerListPage.xaml
    /// </summary>
    public partial class AdminTowelDryerListPage : Page
    {
        bool IsDataUpdate = false;
        public AdminTowelDryerListPage()
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
            IEnumerable<TowelDryer> towelDryers = EfModel.Init().TowelDryers
                .Where(s =>
                s.TitleT.Contains(TbSearch.Text) ||
                s.ArticleNumberT.Contains(TbSearch.Text) ||
                s.DescriptionT.Contains(TbSearch.Text));
            switch (CbSort.SelectedIndex)
            {
                case 0:
                    towelDryers = towelDryers.OrderBy(s => s.CostT);
                    break;
                case 1:
                    towelDryers = towelDryers.OrderByDescending(s => s.CostT);
                    break;
                case 2:
                    towelDryers = towelDryers.OrderBy(s => s.TitleT);
                    break;
                case 3:
                    towelDryers = towelDryers.OrderByDescending(s => s.TitleT);
                    break;
            }

            LvTowelDryer.ItemsSource = towelDryers.ToList();
        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminServiceListPage());
        }

        private void TbSearchChanged(object sender, TextChangedEventArgs e)
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
