using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace Demo1.Data.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
		public const string NamePropertyName = "Name";


		private string name;

		public string Name 
		{
			get { return name; }

			set {
				if (name == value) {
					return;
				}
				if (value != null) {
					name = value;
					RaisePropertyChanged (NamePropertyName);
				}
			}
		}

		private INavigationService _navigationService;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(INavigationService navigationService)
        {
			_navigationService = navigationService;
           
        }
    }
}