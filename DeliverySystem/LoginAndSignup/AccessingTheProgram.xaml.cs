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

namespace DeliverySystem.LoginAndSignup
{
    /// <summary>
    /// Interaction logic for AccessingTheProgram.xaml
    /// </summary>
    public partial class AccessingTheProgram : Window
    {
        public AccessingTheProgram()
        {
            InitializeComponent();
            AccessingTheProgramFrame.Content = new LoginPage(AccessingTheProgramFrame);
        }
    }
}
