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
    /// Interaction logic for Add_movieDetails.xaml
    /// </summary>
    public partial class Add_movieDetails : Window
    {
        Movie_Deal_Details emp = new Movie_Deal_Details();
        Movie_Deal movie;


        Database1Entities db = new Database1Entities();

       
        public Add_movieDetails(Movie_Deal selectedMovie)
        {
            InitializeComponent();
            movie = selectedMovie;
        }

        public Add_movieDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = emp;
            List<ticket_type> empType = (from C in db.ticket_type select C).ToList();
            cmbType.ItemsSource = empType;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
    int price= (from C in db.ticket_type where C.Id == emp.Ticket_Type select C).FirstOrDefault().Price;

            emp.Price = price * emp.Quantity;






            emp.Movie_Deal = movie;
            db.Movie_Deal_Details.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
