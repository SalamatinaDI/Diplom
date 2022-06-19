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
    /// Логика взаимодействия для ConvectorListPage.xaml
    /// </summary>
    public partial class ConvectorListPage : Page
    {
        bool IsDataUpdate = false;
        public ConvectorListPage()
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
            IEnumerable<Convector> convectors = EfModel.Init().Convectors
                .Where(s =>
                s.TitleC.Contains(TbSearch.Text) ||
                s.ArticleNumderC.Contains(TbSearch.Text) ||
                s.DescriptionC.Contains(TbSearch.Text));

            switch (CbSort.SelectedIndex)
            {
                case 0:
                    convectors = convectors.OrderBy(s => s.CostC);
                    break;
                case 1:
                    convectors = convectors.OrderByDescending(s => s.CostC);
                    break;
                case 2:
                    convectors = convectors.OrderBy(s => s.TitleC);
                    break;
                case 3:
                    convectors = convectors.OrderByDescending(s => s.TitleC);
                    break;
            }

            LvConvector.ItemsSource = convectors.ToList();
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
