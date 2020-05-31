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
    /// Interaction logic for Supliers.xaml
    /// </summary>
    public partial class Supliers : Window
    {
        Database1Entities db = new Database1Entities();
        public Supliers()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Suppliers> lst = (from s in db.Suppliers select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void save_button(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }

        private void Add_supplier(object sender, RoutedEventArgs e)
        {
            AddSuplier sup = new AddSuplier();
            sup.ShowDialog();
            updateDGV();
        }
    }
}
