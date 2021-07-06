using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navPage = new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Color.FromHex("ffff00");

            MainPage = navPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
