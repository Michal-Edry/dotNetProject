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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            new AddOrder().ShowDialog();
        }

        private void UpdateOrder_Button_Click(object sender, RoutedEventArgs e)
        {
          //  new UpdateOrder().ShowDialog();
        }
    }
}
