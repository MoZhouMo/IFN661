using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data.ViewModel;
using GalaSoft.MvvmLight.Views;

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
			InitializeComponent ();
			BindingContext = App.Locator.Main;


		}

		void OnNewPerson_Clicked(object sender, EventArgs args)
		{
			Vm._navigationService.NavigateTo (ViewModelLocator.NewPersonKey);
		}
	}
}

