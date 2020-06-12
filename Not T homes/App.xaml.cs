using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Not_T_homes.Services;
using Not_T_homes.Views;

namespace Not_T_homes
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
