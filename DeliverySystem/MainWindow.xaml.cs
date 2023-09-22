using DeliverySystem.LoginAndSignup;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeliverySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int DefaultButtonWidth;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Orders();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Clients();
        }

        private void CouriersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Couriers();
        }

        private void PartnersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Partners();
        }

        private void HideMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button[] buttons = { HideMenuButton, OrdersButton, ClientsButton, CouriersButton, PartnersButton, StatisticsButton, SalaryButton, InfoButton, SettingsButton };
            TextBlock[] textBlocks = { HideTextBlock, OrderTextBlock, ClientsTextBlock, CouriersTextBlock, PartnersTextBlock, StatisticTextBlock, SalaryTextBlock, InfoTextBlock, SettingsTextBlock};
            DefaultButtonWidth = (int)HideMenuButton.Width;

            LeftListTabs.BeginAnimation(WidthProperty, AnimateStackPanel(LeftListTabs, 55, 0.15));

            foreach (var block in textBlocks)
            {
                block.Visibility = Visibility.Hidden;
            }

            HideMenuButton.Visibility = Visibility.Collapsed;
            OpenMenuButton.Visibility = Visibility.Visible;
        }

        private void OpenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button[] buttons = { HideMenuButton, OrdersButton, ClientsButton, CouriersButton, PartnersButton, StatisticsButton, SalaryButton, InfoButton, SettingsButton };
            TextBlock[] textBlocks = { HideTextBlock, OrderTextBlock, ClientsTextBlock, CouriersTextBlock, PartnersTextBlock, StatisticTextBlock, SalaryTextBlock, InfoTextBlock, SettingsTextBlock };
            foreach (var block in textBlocks)
            {
                block.Visibility = Visibility.Visible;
            }
            foreach (var button in buttons)
            {
                button.Width = DefaultButtonWidth;
            }
            
            LeftListTabs.BeginAnimation(WidthProperty, AnimateStackPanel(LeftListTabs, DefaultButtonWidth, 0.15));

            HideMenuButton.Visibility = Visibility.Visible;
            OpenMenuButton.Visibility = Visibility.Collapsed;
        }

        private DoubleAnimation AnimateStackPanel(StackPanel pan, int width, double time)
        {
            DoubleAnimation animation = new DoubleAnimation
            {
                From = pan.ActualWidth,
                To = width,
                Duration = new Duration(TimeSpan.FromSeconds(time)),
                //FillBehavior = FillBehavior.Stop
            };
            return animation;
        }

        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Statistics();
        }

        private void SalaryButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Salary();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.AboutProgram();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainWindowPages.Settings();
            this.Hide();
            Window window = new AccessingTheProgram();
            window.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
