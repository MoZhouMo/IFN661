using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data;

namespace Demo1
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsViewModel Vm
		{
			get
			{
				return (SettingsViewModel)BindingContext;
			}
		}
		public SettingsPage ()
		{
			BindingContext = App.Locator.Settings;
			InitializeComponent ();
		}
	}
}

