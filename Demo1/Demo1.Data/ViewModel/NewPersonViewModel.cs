using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace Demo1.Data
{
	public class NewPersonViewModel : ViewModelBase
	{
		private INavigationService _navigationService;
		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public NewPersonViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

		}
	}
}

