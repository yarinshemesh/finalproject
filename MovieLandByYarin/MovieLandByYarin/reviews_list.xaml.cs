﻿using System;
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
    /// Interaction logic for reviews_list.xaml
    /// </summary>
    public partial class reviews_list : Window
    {
        Database1Entities db = new Database1Entities();
        public reviews_list()
        {
            InitializeComponent();
        }
        void updateDGV()
        {

            List<Review> lst = (from s in db.Review select s).ToList();
            dataGrid.ItemsSource = lst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            updateDGV();

        }

        private void add_review(object sender, RoutedEventArgs e)
        {
            ReviewMovie rm = new ReviewMovie();
            rm.ShowDialog();
            updateDGV();
        }
    }
}