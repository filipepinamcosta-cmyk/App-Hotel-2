using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;

namespace AppHotelPlus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.MainPage())
            {
                BarBackgroundColor = (Color)Current.Resources["Primary"],
                BarTextColor = Colors.White
            };
        }
    }
}
