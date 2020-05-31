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
    /// Interaction logic for AddOrderFood.xaml
    /// </summary>
    public partial class AddOrderFood : Window
    {

        Food_Deals emp = new Food_Deals();
        Database1Entities db = new Database1Entities();
        public AddOrderFood()
        {
            InitializeComponent();
        }
        private void Add_click(object sender, RoutedEventArgs e)
        {
            db.Food_Deals.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();

        }
        void updateDGV()
        {

            List<Food_Deal_Details> lst = (from s in db.Food_Deal_Details where s.OrderId == emp.Id select s).ToList();
            dataGrid.ItemsSource = lst;

            int TotalPrice = 0;

            foreach (Food_Deal_Details C in lst)
            {
                TotalPrice += C.Price;
            }

            txtSum.Text = TotalPrice.ToString();
            emp.Price = TotalPrice;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = emp;
            List<Workers> worker_list = (from C in db.Workers select C).ToList();
            workers_list.ItemsSource = worker_list;
            List<Costumers> coss_list = (from C in db.Costumers select C).ToList();
            cos_list.ItemsSource = coss_list;
            updateDGV();
        }
        private void add_details(object sender, RoutedEventArgs e)
        {
            AddFoodDealDetails fdt = new AddFoodDealDetails(emp);
            fdt.ShowDialog();
            updateDGV();
        }
        private void save_click(object sender, RoutedEventArgs e)
        {
            db.Food_Deals.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
