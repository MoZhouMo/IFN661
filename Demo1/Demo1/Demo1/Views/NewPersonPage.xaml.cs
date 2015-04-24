using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data;
using System.Diagnostics;

namespace Demo1
{
	public partial class NewPersonPage : ContentPage
	{
		public NewPersonViewModel Vm 
		{
			get 
			{
				return (NewPersonViewModel)BindingContext;
			}
		}

		public NewPersonPage ()
		{
			InitializeComponent ();
			BindingContext = App.Locator.NewPerson;
		}

		async void OnAddPerson_Clicked(object sender, EventArgs args)
		{
			var database = new PersonDatabase ();

			var person = new PersonModel (Vm.Name, Vm.Number, Vm.Address);

			var insertedNumber = database.InsertItem (person);

			await DisplayAlert ("Success", String.Format ("{0} persons added", insertedNumber), "Cool");

			Navigation.PopAsync ();

		}
	}
}

