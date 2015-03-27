using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace Demo1.Data
{
	public class NewPersonViewModel : ViewModelBase
	{
		private INavigationService _navigationService;

		private string NamePropertyName = "Name";

		private string name;

		public string Name
		{
			get{return name;}
			set
			{
				if (value != null) {
					if (name != value) {
						name = value;
						RaisePropertyChanged (NamePropertyName);
					}
				}
			}
		}

		private string NumberPropertyName = "Number";

		private string number;

		public string Number
		{
			get
			{
				return number;
			}

			set
			{ 
				if (value != null) {
					if (value != number) {
						number = value;
						RaisePropertyChanged (NumberPropertyName);
					}
				}
			}
		}

		private string AddressPropertyName = "Address";

		private string address;

		public string Address 
		{
			get
			{ 
				return address;
			}

			set
			{
				if (value != null) {
					if (value != address) {
						address = value;
						RaisePropertyChanged (AddressPropertyName);
					}
				}
			}
		}

		/// <summary>
		/// Initializes a new instance of the MainViewModel class.
		/// </summary>
		public NewPersonViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

		}
	}
}

