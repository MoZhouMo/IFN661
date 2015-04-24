using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Demo1.Data;

namespace Demo1
{
	public partial class PersonListPage : ContentPage
	{
		public PersonListViewModel Vm
		{
			get
			{
				return (PersonListViewModel)BindingContext;
			}
		}

		public PersonListPage ()
		{
			var database = new PersonDatabase ();
			var people = database.SelectAll ();
			InitializeComponent ();
			BindingContext = App.Locator.PersonList;
			PeopleList.ItemsSource = people;
		}
	}
}

