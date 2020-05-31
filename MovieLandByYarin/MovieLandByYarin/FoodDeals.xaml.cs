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

namespace MovieLandByYarin
{
    /// <summary>
    /// Interaction logic for FoodDeals.xaml
    /// </summary>
    public partial class FoodDeals : Window
    {

        Database1Entities db = new Database1Entities();
        public FoodDeals()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Food_Deals> lst = (from s in db.Food_Deals select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void ADD_CLICK(object sender, RoutedEventArgs e)
        {
            AddOrderFood ad = new AddOrderFood();
            ad.ShowDialog();

        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
