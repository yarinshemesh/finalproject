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
    /// Interaction logic for TicketType.xaml
    /// </summary>
    public partial class TicketType : Window
    {
        Database1Entities db = new Database1Entities();
        public TicketType()
        {
            InitializeComponent();
        }

        private void add_click(object sender, RoutedEventArgs e)
        {
            Add_TicketType att = new Add_TicketType();
            att.ShowDialog();
            updateDGV();

        }
        void updateDGV()
        {

            List<ticket_type> lst = (from s in db.ticket_type select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void save_data(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
