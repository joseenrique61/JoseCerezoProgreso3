using JoseCerezoProgreso3.Models;
using SQLite;

namespace JoseCerezoProgreso3.Utilities
{
	public class DatabaseConnection : IDatabaseConnection
	{
		private readonly SQLiteConnection SQLiteConnection;

		public DatabaseConnection()
		{
			SQLiteConnection = new(Path.Combine(FileSystem.CacheDirectory, "airports.db"));
			SQLiteConnection.CreateTable<DBAirport>();
		}

		public List<DBAirport> GetAllAirports()
		{
			return SQLiteConnection.Query<DBAirport>("SELECT * FROM DBAirport ORDER BY Id DESC");
		}

		public void SaveAirport(DBAirport dbAirport)
		{
			SQLiteConnection.Insert(dbAirport);
		}
	}
}
