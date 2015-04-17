using System;
using SQLite.Net;
using Microsoft.Practices.ServiceLocation;
using System.Linq;
using System.Diagnostics;

namespace Demo1.Data
{
	public class KeyPairDatabase
	{
	SQLiteConnection database;
	static object locker = new object();

		public KeyPairDatabase()
	{
		database = ServiceLocator.Current.GetInstance<ISqlite>().GetConnection();

		try
		{
			if(database.TableMappings.All(t => t.MappedType.Name != typeof(KeyPairModel).Name))
			{
				database.CreateTable<KeyPairModel>();
				database.Commit();
			}

		}
		catch (Exception e)
		{
			Debug.WriteLine(e);
			throw;
		}

	} 

	public string GetValueIfExists(string key)
	{
		if (Exists (key)) {
			var item = database.Table<KeyPairModel> ().FirstOrDefault (x => x.Key == key);
			return item.Value;
		} else
			return null;
	}

	public KeyPairModel GetItem(string key)
	{
		var item = database.Table<KeyPairModel>().FirstOrDefault(x => x.Key == key);
		return item;
	}

	public int DeleteItem(string key)
	{
		database.Commit();
		return database.Delete<KeyPairModel>(key);

	}

	public int InsertItem(string key, string value)
	{
		KeyPairModel newKeyPair = new KeyPairModel(key, value);

		int num = 0;
		if (database.Table<KeyPairModel>().Where(x => x.Key == key).Count() > 0)
		{
			return database.Update(newKeyPair);
		}
		else
		{
			num = database.Insert(newKeyPair);
		}
		return num;
	}
	public int InsertOrReplaceItem(string key, string value)
	{
		KeyPairModel newKeyPair = new KeyPairModel();

		newKeyPair.Key = key;
		newKeyPair.Value = value;
		database.Commit();

		return database.InsertOrReplace(newKeyPair);
	}

	public int UpdateItem(string key, string value)
	{
		KeyPairModel updateKeyPair = new KeyPairModel();
		updateKeyPair.Key = key;
		updateKeyPair.Value = value;
		database.Commit();

		return database.Update(updateKeyPair);
	}

	public bool Exists(string key)
	{
		var exists =  database.Table<KeyPairModel>().Where(x => x.Key == key).Count() > 0;
		return exists;
	}
}
}

