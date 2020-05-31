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
    /// Interaction logic for AddSuplier.xaml
    /// </summary>
    public partial class AddSuplier : Window
    {
        Suppliers sup = new Suppliers();
        Database1Entities db = new Database1Entities();
        public AddSuplier()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = sup;
            List<supplies_type> empType = (from C in db.supplies_type select C).ToList();
            cmbType.ItemsSource = empType;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            db.Suppliers.Add(sup);
            db.SaveChanges();
            db.Dispose();
            this.Close();
        }
       

        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
