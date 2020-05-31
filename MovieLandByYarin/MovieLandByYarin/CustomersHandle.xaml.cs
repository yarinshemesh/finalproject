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
    /// Interaction logic for CustomersHandle.xaml
    /// </summary>
    public partial class CustomersHandle : Window
    {
        Database1Entities db = new Database1Entities();
        public CustomersHandle()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Costumers> lst = (from s in db.Costumers select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void add_costumer(object sender, RoutedEventArgs e)
        {
            AddCostumer ad = new AddCostumer();

            ad.ShowDialog();
            updateDGV();
        }

        private void save_data(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }
    }
}
