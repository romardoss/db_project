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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeliverySystem.MainWindowPages
{
    /// <summary>
    /// Interaction logic for AboutProgram.xaml
    /// </summary>
    public partial class AboutProgram : Page
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void ContactWithDeveloperButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/romardoss");
        }
    }
}
