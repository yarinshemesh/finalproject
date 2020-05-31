using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
    /// Interaction logic for WorkerHandle.xaml
    /// </summary>
    public partial class WorkerHandle : Window
    {

        Database1Entities db = new Database1Entities();



        public WorkerHandle()
        {
            InitializeComponent();
        }

        void updateDGV()
        {

            List<Workers> lst = (from s in db.Workers select s).ToList();
            dataGrid.ItemsSource = lst;

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void add_t_Click(object sender, RoutedEventArgs e)
        {
            
            Add_worker ad = new Add_worker();

            ad.ShowDialog();
            updateDGV();
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            db.Dispose();
        }
    }
}
