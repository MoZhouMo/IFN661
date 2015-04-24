using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Demo1.Data.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace Demo1
{
    public class App : Application
    {
		static ViewModelLocator _locator;
		static NavigationService nav;
		static NavigationPage _navPage;

        public App()
        {
            // The root page of your application
			MainPage = GetMainPage();
            
        }

		public static Page GetMainPage(){
		
			nav = new NavigationService ();
			nav.Configure (ViewModelLocator.MainPageKey, typeof(MainPage));
			nav.Configure (ViewModelLocator.NewPersonKey, typeof(NewPersonPage));
			nav.Configure (ViewModelLocator.SettingsKey, typeof(SettingsPage));
			nav.Configure (ViewModelLocator.PersonListKey, typeof(PersonListPage));
			SimpleIoc.Default.Register<INavigationService> (() => nav, true);

			_navPage = new NavigationPage (new MainPage());
			nav.Initialize (_navPage);
			return _navPage;
		}
		public static ViewModelLocator Locator
		{
			get
			{
				return _locator ?? (_locator = new ViewModelLocator ());
			}
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
