using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data.ViewModel;
using GalaSoft.MvvmLight.Views;
using Demo1.Data;

namespace Demo1
{
	public partial class MainPage : ContentPage
	{

		public MainViewModel Vm
		{
			get
			{
				return (MainViewModel)BindingContext;
			}
		}

		public MainPage ()
		{
			BindingContext = App.Locator.Main;
			InitializeComponent ();

		}

		void OnNewPerson_Clicked(object sender, EventArgs args)
		{
			Vm._navigationService.NavigateTo (ViewModelLocator.NewPersonKey);
		}

		void OnSettings_Clicked(object sender, EventArgs args){
			Navigation.PushAsync (new SettingsPage());
		}

		void OnPersonList_Clicked(object sender, EventArgs args){
			DisplayAlert ("Hands on!", "Its time for a hands on Demo!", "Cool!");
		}


		protected override void OnAppearing(){
			 KeyPairDatabase database = new KeyPairDatabase();

			Vm.WelcomeText =  string.Format("Welcome {0} to Xamarin", database.GetValueIfExists ("UserName"));
		
		}
	}
}

