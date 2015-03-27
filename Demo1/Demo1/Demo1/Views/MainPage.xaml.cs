using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data.ViewModel;

namespace Demo1
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			BindingContext = App.Locator.Main;
		}
	}
}

