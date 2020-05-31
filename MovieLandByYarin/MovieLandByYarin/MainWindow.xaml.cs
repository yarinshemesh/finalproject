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

namespace MovieLandByYarin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void employees_Click(object sender, RoutedEventArgs e)
        {
            WorkerHandle emp = new WorkerHandle();
            emp.ShowDialog();
        }

        private void tickets_Click(object sender, RoutedEventArgs e)
        {
            MovieDeals Mov = new MovieDeals();
            Mov.ShowDialog();
        }

        private void food_Click(object sender, RoutedEventArgs e)
        {
            FoodDeals Fod = new FoodDeals();
            Fod.ShowDialog();
        }

        private void Movies_Click(object sender, RoutedEventArgs e)
        {
            MoviesHandle mov2 = new MoviesHandle();
            mov2.ShowDialog();
        }

        private void Supplies_Click(object sender, RoutedEventArgs e)
        {
            Supliers sup = new Supliers();
            sup.ShowDialog();
        }

        private void Costumers_Click(object sender, RoutedEventArgs e)
        {
            CustomersHandle cos = new CustomersHandle();
            cos.ShowDialog();
        }

        private void Review_Click(object sender, RoutedEventArgs e)
        {
            ReviewMovie rev = new ReviewMovie();
            rev.ShowDialog();

        }

        private void director_window(object sender, RoutedEventArgs e)
        {
            Directors_list dir = new Directors_list();
            dir.ShowDialog();
        }

        private void WorkerType_window(object sender, RoutedEventArgs e)
        {
            Workers_type wt = new Workers_type();
            wt.ShowDialog();
        }

        private void product_window(object sender, RoutedEventArgs e)
        {
            products_list pro = new products_list();
            pro.ShowDialog();
        }

        private void tickets_type_Click(object sender, RoutedEventArgs e)
        {
            TicketType tk = new TicketType();
            tk.ShowDialog();
        }
    }
}
