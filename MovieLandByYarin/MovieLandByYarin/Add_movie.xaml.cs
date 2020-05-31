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
    /// Interaction logic for Add_movie.xaml
    /// </summary>
    public partial class Add_movie : Window
    {
       Movies emp = new Movies();
        Database1Entities db = new Database1Entities();
        public Add_movie()
        {
            InitializeComponent();
        }

        private void Add_click(object sender, RoutedEventArgs e)
          {
            db.Movies.Add(emp);
            db.SaveChanges();
            db.Dispose();
            this.Close();
         }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = emp;
            List<Directors> empType = (from C in db.Directors select C).ToList();
            cmbType.ItemsSource = empType;
        }
      

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^A-Za-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

       
    }
}
