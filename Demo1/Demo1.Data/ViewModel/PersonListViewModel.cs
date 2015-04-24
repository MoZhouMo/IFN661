using System;
using System.ComponentModel;
using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace Demo1.Data
{
	public class PersonListViewModel : ViewModelBase
	{
		

		private List<PersonModel> persons;

		public List<PersonModel> Persons
		{
			get{ return persons; }

			set {
				if (value != null) {
					if (persons == value) {
						persons = value;
						RaisePropertyChanged ("Persons");
						
					}
				}
			}
		}

		private string PersonCountPropertyName = "PersonCount";
		private int personCount;

		public int PersonCount{
			get{ return personCount; }

			set{
				if (value != null) {
					if (value != personCount) {
						personCount = value;
						RaisePropertyChanged (PersonCountPropertyName);
					}
				}
			}
		}

		public PersonListViewModel ()
		{
			
		}
	}
}

