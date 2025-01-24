using JoseCerezoProgreso3.Models;

namespace JoseCerezoProgreso3.Utilities
{
	public interface IDatabaseConnection
	{
		public void SaveAirport(DBAirport dbAirport);

		public List<DBAirport> GetAllAirports();
	}
}
