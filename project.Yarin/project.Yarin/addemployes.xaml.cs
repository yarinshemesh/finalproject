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

namespace project.Yarin
{
    /// <summary>
    /// Interaction logic for addemployes.xaml
    /// </summary>
    public partial class addemployes : Window
    {
        public addemployes()
        {
            InitializeComponent();
        }

        private void Add_button(object sender, RoutedEventArgs e)
        {
            addemployes d = new addemployes();
            this.Close();
        }
    }
}
