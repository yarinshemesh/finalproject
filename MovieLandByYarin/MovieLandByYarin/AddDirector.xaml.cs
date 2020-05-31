using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddDirector.xaml
    /// </summary>
    public partial class AddDirector : Window
    {
        Directors sup = new Directors();
        Database1Entities db = new Database1Entities();
        public AddDirector()
        {
            InitializeComponent();
        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            db.Directors.Add(sup);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = sup;
        }
        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
