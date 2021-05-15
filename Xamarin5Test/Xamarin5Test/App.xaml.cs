using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin5Test.Services;
using Xamarin5Test.Views;

namespace Xamarin5Test
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
