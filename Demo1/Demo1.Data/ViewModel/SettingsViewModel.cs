using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace Demo1.Data
{
	public class SettingsViewModel : ViewModelBase
	{
		private INavigationService _navigationService;

		private string UserNamePropertyName = "UserName";

		private string userName;
		private KeyPairDatabase database = new KeyPairDatabase();
		public string UserName
		{
			get{return userName;}
			set
			{
				if (value != null) {
					if (userName != value) {
						userName = value;
						database.InsertOrReplaceItem ("UserName", value);
						RaisePropertyChanged (UserNamePropertyName);
					}
				}
			}
		}

		public SettingsViewModel (INavigationService navigationService)
		{
			_navigationService = navigationService;
			UserName = database.GetValueIfExists ("UserName");
		}
	}
}

