using JoseCerezoProgreso3.Models;
using System.Net.Http.Json;

namespace JoseCerezoProgreso3.Utilities
{
	public class APIClient : IAPIClient
	{
		private readonly HttpClient HttpClient = new();

		public async Task<JSONAirport?> GetAirport(string name)
		{
			List<JSONAirport> airports = (await HttpClient.GetFromJsonAsync<List<JSONAirport>>($"https://www.freetestapi.com/api/v1/airports?search={name}&limit=1"))!;

			if (airports.Count == 0)
			{
				return null;
			}
			return airports[0];
		}
	}
}
