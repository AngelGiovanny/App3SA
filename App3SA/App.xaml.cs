using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3SA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Navegacion entre ventanas
            MainPage = new NavigationPage(new MainPage());
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
