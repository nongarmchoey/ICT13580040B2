using ICT13580040B2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ICT13580040B2
{
    public partial class App : Application
    {
        public static DbHelper DbHelper { get; set; }

        public App()
        {
            InitializeComponent();
        }

        public App(string dbPath)
        {
            InitializeComponent();

            DbHelper = new DbHelper(dbPath);

            MainPage = new NavigationPage(new ICT13580040B2.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
