﻿using FormsLibrary.Model;
using FormsLibrary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FormsLibrary
{
    public class App : Application
    {
        public static INavigation NavigationService {get; set;}

        public static int Area { get; set; }

        public App()
        {
            MainPage = new NavigationPage(new SplashScreen());
            Area = 10;
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
