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
    /// Interaction logic for ReviewMovie.xaml
    /// </summary>
    public partial class ReviewMovie : Window
    {
        Review emp = new Review();
        Database1Entities db = new Database1Entities();

        public ReviewMovie()
        {
            InitializeComponent();
        }

        private void add_review(object sender, RoutedEventArgs e)
        {
            db.Review.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = emp;
            List<Movies> empType = (from C in db.Movies select C).ToList();
            cmbType.ItemsSource = empType;

            List<Costumers> cos_list = (from C in db.Costumers select C).ToList();
            cmbType.ItemsSource = cos_list;
        }
    }
}
