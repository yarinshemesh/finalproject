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
    /// Interaction logic for MoviesHandle.xaml
    /// </summary>
    public partial class MoviesHandle : Window
    {
        Database1Entities db = new Database1Entities();
       
        public MoviesHandle()
        {
            InitializeComponent();
        }

        void updateDGV()
        {

            List<Movies> lst = (from s in db.Movies select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add_movie mov = new Add_movie();

            mov.ShowDialog();
            updateDGV();
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
