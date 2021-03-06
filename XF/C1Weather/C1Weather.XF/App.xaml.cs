﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C1.Xamarin.Forms.Core;
using Xamarin.Forms;


namespace C1Weather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LicenseManager.Key = License.Key;
            MainPage = new NavigationPage( new C1Weather.WeatherPage());
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
