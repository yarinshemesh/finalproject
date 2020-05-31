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
    /// Interaction logic for Directors_list.xaml
    /// </summary>
    public partial class Directors_list : Window
    {
        Database1Entities db = new Database1Entities();
        public Directors_list()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Directors> lst = (from s in db.Directors select s).ToList();
            dataGrid.ItemsSource = lst;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }
        private void add_click(object sender, RoutedEventArgs e)
        {
            AddDirector dire = new AddDirector();
            dire.ShowDialog();
            updateDGV();
        }

        private void save_data(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
