using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageNavigationMonkeys
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Page p = new MainPage();
            p.Title = "Monkey Lists";
            MainPage = new NavigationPage(p);
            
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
