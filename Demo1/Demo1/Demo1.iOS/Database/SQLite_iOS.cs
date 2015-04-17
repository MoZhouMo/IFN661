using System;
using Demo1.Data;
using SQLite.Net;
using System.IO;

namespace Demo1.iOS
{
	public class SQLite_iOS : ISqlite
	{
		private static ISqlite _db;
		private SQLiteConnection _connection;

		public SQLite_iOS() { }
		public static ISqlite SQLite { 
			get 
			{ 
				if(_db == null)
					_db = new SQLite_iOS();

				return _db; 
			} 
		}

		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			if (_connection == null) {

				const string sqliteFilename = "FixIt.db";
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
				string libraryPath = Path.Combine (documentsPath, "..", "Library");

				var path = Path.Combine (libraryPath, sqliteFilename);

				var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS ();

				_connection = new SQLite.Net.SQLiteConnection (plat, path);
			}

			return _connection;
		}

	}
}

