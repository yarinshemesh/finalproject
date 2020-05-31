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
    /// Interaction logic for products_list.xaml
    /// </summary>
    public partial class products_list : Window
    {
        Database1Entities db = new Database1Entities();
        public products_list()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Products> lst = (from s in db.Products select s).ToList();
            dataGrid.ItemsSource = lst;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }


        private void add_product(object sender, RoutedEventArgs e)
        {
            AddProduct pro = new AddProduct();
            pro.ShowDialog();
            updateDGV();
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
