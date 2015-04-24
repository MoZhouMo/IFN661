using System;
using SQLite.Net.Attributes;

namespace Demo1.Data
{
	public class PersonModel
	{
		public PersonModel ()
		{
		}

		public PersonModel( 
			string name, string phoneNumber, string address){
			Name = name;
			PhoneNumber = phoneNumber;
			Address = address;
		}

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Name{ get; set; }
		public string PhoneNumber{get;set;}
		public string Address { get; set; }

	}
}

