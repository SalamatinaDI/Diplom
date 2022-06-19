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
    /// Логика взаимодействия для AdminWaterHeatingListPage.xaml
    /// </summary>
    public partial class AdminWaterHeatingListPage : Page
    {
        bool IsDataUpdate = false;
        public AdminWaterHeatingListPage()
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
            IEnumerable<WaterHeating> waterHeatings = EfModel.Init().WaterHeatings
                .Where(s =>
                s.TitleW.Contains(TbSearch.Text) ||
                s.ArticleNumberW.Contains(TbSearch.Text) ||
                s.DescriptionW.Contains(TbSearch.Text));
            switch (CbSort.SelectedIndex)
            {
                case 0:
                    waterHeatings = waterHeatings.OrderBy(s => s.CostW);
                    break;
                case 1:
                    waterHeatings = waterHeatings.OrderByDescending(s => s.CostW);
                    break;
                case 2:
                    waterHeatings = waterHeatings.OrderBy(s => s.TitleW);
                    break;
                case 3:
                    waterHeatings = waterHeatings.OrderByDescending(s => s.TitleW);
                    break;
            }

            LvWaterHeating.ItemsSource = waterHeatings.ToList();
        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartPage());
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminServiceListPage());
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
           
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
