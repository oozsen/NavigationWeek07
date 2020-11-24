using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationWeek07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Page1());
            MainPage = new Tabbed();
            //var tabbedPage = new Tabbed();

            //tabbedPage.Children.Add(new Page1());
            //tabbedPage.Children.Add(new Page2());
            //tabbedPage.Children.Add(new Page3());

            //MainPage = tabbedPage;
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
