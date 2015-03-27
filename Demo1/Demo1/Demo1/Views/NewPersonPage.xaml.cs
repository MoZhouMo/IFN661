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

		void OnAddPerson_Clicked(object sender, EventArgs args)
		{
			Debug.WriteLine(String.Format("Name = {0} Phone Number = {1} Address = {2}",Vm.Name,Vm.Number,Vm.Address));
		}
	}
}

