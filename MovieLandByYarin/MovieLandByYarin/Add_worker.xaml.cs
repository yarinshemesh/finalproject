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
    /// Interaction logic for Add_worker.xaml
    /// </summary>
    public partial class Add_worker : Window
                   {

        Workers emp = new Workers();
        Database1Entities db = new Database1Entities();

        public Add_worker()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = emp;
            List<Worker_types> empType = (from C in db.Worker_types select C).ToList();
            cmbType.ItemsSource = empType;
            


        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //emp.Worker_Type = 1;
            db.Workers.Add(emp);
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
