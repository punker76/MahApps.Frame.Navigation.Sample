using System;
using System.Windows.Navigation;
using MahApps.Metro.Controls;
using MahAppsFrameNavigation.Navigation;

namespace MahAppsFrameNavigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly Navigation.NavigationServiceEx _navigationServiceEx;

        public MainWindow()
        {
            InitializeComponent();

            this._navigationServiceEx = NavigationServiceEx.Instance;
            this._navigationServiceEx.Navigated += this.NavigationServiceEx_OnNavigated;
            this.RootGrid.Children.Add(this._navigationServiceEx.Frame);

            // Navigate to login page.
            this.Loaded += (sender, args) =>
                this._navigationServiceEx.Navigate(new Uri("Views/LoginPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NavigationServiceEx_OnNavigated(object sender, NavigationEventArgs e)
        {
        }
    }
}