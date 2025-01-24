using JoseCerezoProgreso3.Models;

namespace JoseCerezoProgreso3.Utilities
{
	public interface IAPIClient
	{
		public Task<JSONAirport?> GetAirport(string name);
	}
}
