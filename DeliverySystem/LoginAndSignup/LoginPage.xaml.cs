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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly Frame _frame;

        private LoginPage()
        {
            InitializeComponent();
        }

        public LoginPage(Frame frame)
        {
            InitializeComponent();
            _frame = frame;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Close();
            Window mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            _frame.Content = new RegistrationPage();
        }
    }
}
