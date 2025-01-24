using JoseCerezoProgreso3.Models;

namespace JoseCerezoProgreso3.Utilities
{
	public class AirportConverter
	{
		public static DBAirport Convert(JSONAirport jsonAirport)
		{
			return new()
			{
				Name = jsonAirport.name,
				Country = jsonAirport.country,
				Latitude = jsonAirport.location.latitude,
				Longitude = jsonAirport.location.longitude,
				Email = jsonAirport.contact_info.email
			};
		}
	}
}
