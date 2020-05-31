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
    /// Interaction logic for Workers_type.xaml
    /// </summary>
    public partial class Workers_type : Window
    {
        Database1Entities db = new Database1Entities();
        public Workers_type()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Worker_types> lst = (from s in db.Worker_types select s).ToList();
            dataGrid.ItemsSource = lst;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            AddWorkerType wt = new AddWorkerType();
            wt.ShowDialog();
        }
    }
}
