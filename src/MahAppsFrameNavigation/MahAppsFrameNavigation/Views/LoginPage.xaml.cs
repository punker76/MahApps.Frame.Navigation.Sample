using System;
using System.Windows;
using System.Windows.Controls;
using MahAppsFrameNavigation.Navigation;

namespace MahAppsFrameNavigation.Views
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginOnClick(object sender, RoutedEventArgs e)
        {
            var navigation = NavigationServiceEx.Instance;
            navigation.Navigate(typeof(MainPage));
            // or
            //navigation.Navigate(new Uri("Views/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}