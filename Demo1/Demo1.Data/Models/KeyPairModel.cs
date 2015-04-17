using System;
using SQLite.Net.Attributes;

namespace Demo1.Data
{
	public class KeyPairModel
	{
		public KeyPairModel()
		{

		}
		public KeyPairModel(string key, string value)
		{
			Key = key;
			Value = value;
		}
		[PrimaryKey]
		public string Key { get; set; }
		public string Value { get; set; }
	}
}

