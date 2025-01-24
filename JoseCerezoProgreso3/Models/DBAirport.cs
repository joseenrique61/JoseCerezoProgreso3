using SQLite;

namespace JoseCerezoProgreso3.Models
{
	public class DBAirport
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Country { get; set; }
		
		public float Longitude { get; set; }

		public float Latitude { get; set; }

		public string Email { get; set; }

		public string MyName => "JCerezo";
	}
}
