using System;
using SQLite.Net;
using Microsoft.Practices.ServiceLocation;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace Demo1.Data
{
	public class PersonDatabase
	{
		SQLiteConnection database;
		static object locker = new object();

		public PersonDatabase()
		{
			database = ServiceLocator.Current.GetInstance<ISqlite>().GetConnection();

			try
			{
				if(database.TableMappings.All(t => t.MappedType.Name != typeof(PersonModel).Name))
				{
					database.CreateTable<PersonModel>();
					database.Commit();
				}

			}
			catch (Exception e)
			{
				Debug.WriteLine(e);
				throw;
			}

		} 





		public int DeleteItem(string key)
		{
			database.Commit();
			return database.Delete<PersonModel>(key);

		}

		public int InsertItem(PersonModel person)
		{
			

			var num = database.Insert(person);

			return num;
		}
		public int InsertOrReplaceItem(PersonModel person)
		{
			


			return database.InsertOrReplace(person);
		}

		public int UpdateItem(PersonModel person)
		{
			PersonModel updateKeyPair = new PersonModel();

	
			return database.Update(person);
		}

		public bool Exists(int id)
		{
			var exists =  database.Table<PersonModel>().Where(x => x.ID == id).Count() > 0;
			return exists;
		}

		public List<PersonModel> Query(string query){
		
			var result = database.Query<PersonModel> (query, null);
			return result;
		}

		public List<PersonModel> SelectAll(){

		}
	}
}

