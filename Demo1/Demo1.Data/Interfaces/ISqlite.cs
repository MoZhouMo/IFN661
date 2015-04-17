using System;
using SQLite.Net;

namespace Demo1.Data
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}

