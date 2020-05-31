using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddFoodDealDetails.xaml
    /// </summary>
    public partial class AddFoodDealDetails : Window
    {
        Food_Deal_Details emp = new Food_Deal_Details();
        Database1Entities db = new Database1Entities();
        Food_Deals deal;

        public AddFoodDealDetails(Food_Deals tmp)
        {
            InitializeComponent();
            deal = tmp;
            this.DataContext = emp;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            emp.Food_Deals = deal;
            Products prd = (from c in db.Products where c.Id == emp.ProductID select c).First();

            emp.Price =(int) prd.Price * emp.Quantity;

            db.Food_Deal_Details.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Products> coss_list = (from C in db.Products select C).ToList();
            cmbType.ItemsSource = coss_list;
        }
    }
}
