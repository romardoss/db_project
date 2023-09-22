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

namespace DeliverySystem.LoginAndSignup
{
    /// <summary>
    /// Interaction logic for ResetPasswordPage.xaml
    /// </summary>
    public partial class ResetPasswordPage : Page
    {
        private Frame _frame;

        private ResetPasswordPage()
        {
            InitializeComponent();
        }

        public ResetPasswordPage(Frame frame)
        {
            InitializeComponent();
            _frame = frame;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            _frame.Content = new LoginPage(_frame);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            window.Close();
        }
    }
}
