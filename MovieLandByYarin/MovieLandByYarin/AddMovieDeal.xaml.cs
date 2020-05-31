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
    /// Interaction logic for AddMovieDeal.xaml
    /// </summary>
    public partial class AddMovieDeal : Window
    {
        Movie_Deal emp = new Movie_Deal();
        Database1Entities db = new Database1Entities();
        String Age;
        int CustAge;


        public AddMovieDeal()
        {
            InitializeComponent();

        }

        private void Add_click(object sender, RoutedEventArgs e)
        {
            db.Movie_Deal.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                     dtNow.DisplayDate = DateTime.Now;

            this.DataContext = emp;
            List<Movies> empType = (from C in db.Movies select C).ToList();
            cmbMovies.ItemsSource = empType;
            List<Workers> worker_list = (from C in db.Workers select C).ToList();
            workers_list.ItemsSource = worker_list;
            List<Costumers> coss_list = (from C in db.Costumers select C).ToList();
            cos_list.ItemsSource = coss_list;
            updateDGV();
        }
        void updateDGV()
        {

            List<Movie_Deal_Details> lst = (from s in db.Movie_Deal_Details where s.DealID==emp.Id select s).ToList();
            dataGrid.ItemsSource = lst;

            int TotalPrice= 0;

            foreach (Movie_Deal_Details C in lst)
            {
                TotalPrice += C.Price;
            }

            txtSum.Text = TotalPrice.ToString();

        }

        private void add_details(object sender, RoutedEventArgs e)
        {
            Add_movieDetails amd = new Add_movieDetails(emp);
            amd.ShowDialog();
            updateDGV();
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            db.Movie_Deal.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }

        private void cmbMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Movies MovieAge = (Movies)cmbMovies.SelectedItem;
           Age = MovieAge.Age_Limit;


        }

        private void cmbCust_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Costumers Cust = (Costumers)cos_list.SelectedItem;
            int.TryParse(Cust.Age, out CustAge);

            switch (Age)
            {
                case "8+":
                    if (CustAge < 8) {
                        string message = "Invalid Age";
                        MessageBox.Show(message);
                    }
                    break;
                case "14+":
                    if (CustAge < 14)
                    {
                        string message = "Invalid Age";
                        MessageBox.Show(message);
                    }
                    break;
                case "18+":
                    if (CustAge < 18)
                    {
                        string message = "Invalid Age";
                        MessageBox.Show(message);
                    }
                    break;

            }
        }
    }
}
