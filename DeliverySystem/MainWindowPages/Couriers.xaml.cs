using DeliverySystem.UIClasses;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeliverySystem.MainWindowPages
{
    /// <summary>
    /// Interaction logic for Couriers.xaml
    /// </summary>
    public partial class Couriers : Page
    {
        public Couriers()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushWithMouse.BrushYellow(true, ((Border)sender));
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushWithMouse.BrushYellow(false, ((Border)sender));
        }
    }
}
