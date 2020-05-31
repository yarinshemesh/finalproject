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
    /// Interaction logic for MovieDeals.xaml
    /// </summary>
    public partial class MovieDeals : Window
    {
        Database1Entities db = new Database1Entities();
        public MovieDeals()
        {
            InitializeComponent();
        }

        void updateDGV()
        {

            List<Movie_Deal> lst = (from s in db.Movie_Deal select s).ToList();
            dataGrid1.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            AddMovieDeal rm = new AddMovieDeal();
            rm.ShowDialog();
            updateDGV();
        }

        private void save_button(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
