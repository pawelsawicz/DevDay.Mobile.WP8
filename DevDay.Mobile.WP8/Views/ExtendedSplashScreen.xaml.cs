using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Views
{
    public partial class ExtendedSplashScreen : PhoneApplicationPage
    {
        public ExtendedSplashScreen()
        {
            InitializeComponent();
            splash_screen();
        }

        async void splash_screen()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            NavigationService.Navigate(new Uri("/Views/MainView.xaml", UriKind.Relative));
        }
    }
}