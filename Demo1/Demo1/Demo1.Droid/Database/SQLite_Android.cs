using System;
using Demo1.Data;
using System.IO;
using SQLite.Net;

namespace Demo1.Droid
{
	public class SQLite_Android : ISqlite
	{
		public SQLite_Android() { }
		public static ISqlite SQLite { get { return new SQLite_Android(); } }

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "Fixit.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

			var path = Path.Combine(documentsPath, sqliteFilename);
			if (!File.Exists(path))
			{
				File.Create(path);
			}
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();

			var x = File.Exists(path);
			var conn = new SQLiteConnection(plat, path);

			return conn;

		}
	}
}

