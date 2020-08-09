using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using hello_xamarin.Services;
using hello_xamarin.Views;

namespace hello_xamarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
