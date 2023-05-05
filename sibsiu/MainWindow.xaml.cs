using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace sibsiu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu_mainBtn_Click(object sender, RoutedEventArgs e)
        {            
            mainFrame.Source = new Uri("Pages/MainPage.xaml", UriKind.Relative);
        }

        private void menu_plansBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("Pages/PlansPage.xaml", UriKind.Relative);
        }

        private void menu_placeBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("Pages/PlacePage.xaml", UriKind.Relative);
        }

        private void menu_libraryBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("Pages/LibraryPage.xaml", UriKind.Relative);
        }

        private void menu_documentsBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Source = new Uri("Pages/DocumentsPage.xaml", UriKind.Relative);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void minimizedBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
            
        }

        private void resizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            resizeBtn.Content = WindowState == WindowState.Maximized ? "▢" : "❐";
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            menu_mainBtn.BorderBrush = menu_plansBtn.BorderBrush = menu_placeBtn.BorderBrush = menu_documentsBtn.BorderBrush = Brushes.Transparent;

            switch (mainFrame.Source.ToString().Replace("sibsiu;component/Pages/",""))
            {
                case "MainPage.xaml":
                    menu_mainBtn.BorderBrush = Brushes.LightGray;
                    break;
                case "PlansPage.xaml":
                    menu_plansBtn.BorderBrush = Brushes.LightGray;
                    break;
                case "PlacePage.xaml":
                    menu_placeBtn.BorderBrush = Brushes.LightGray;
                    break;
                case "DocumentsPage.xaml":
                    menu_documentsBtn.BorderBrush = Brushes.LightGray;
                    break;
            }
       }

    }
}
