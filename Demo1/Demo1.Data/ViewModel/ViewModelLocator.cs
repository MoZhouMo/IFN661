/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Demo1.Data"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Views;

namespace Demo1.Data.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
		public const string MainPageKey = "MainPage";
		public const string NewPersonKey = "NewPersonPage";
		public const string SettingsKey = "SettingsPage";
		public const string PersonListKey = "PersonListPage";
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}


			var nav = SimpleIoc.Default.GetInstance<INavigationService> ();
			SimpleIoc.Default.Register<MainViewModel>(() => new MainViewModel (nav));
			SimpleIoc.Default.Register<NewPersonViewModel>(() => new NewPersonViewModel (nav));
			SimpleIoc.Default.Register<SettingsViewModel> (() => new SettingsViewModel (nav));
			SimpleIoc.Default.Register<PersonListViewModel>(() => new PersonListViewModel());
        }

		public MainViewModel Main
		{
			get
			{
				return ServiceLocator.Current.GetInstance<MainViewModel>();
			}
		}

		public NewPersonViewModel NewPerson 
		{
			get
			{ 
				return ServiceLocator.Current.GetInstance<NewPersonViewModel> ();
			}
		}

		public SettingsViewModel Settings
		{
			get
			{
				return ServiceLocator.Current.GetInstance<SettingsViewModel> ();
			}
		}
        
		public PersonListViewModel PersonList
		{
			get
			{
				return ServiceLocator.Current.GetInstance<PersonListViewModel>();
			}	
		}
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}