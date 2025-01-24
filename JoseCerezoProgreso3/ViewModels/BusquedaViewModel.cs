using JoseCerezoProgreso3.Models;
using JoseCerezoProgreso3.Utilities;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JoseCerezoProgreso3.ViewModels
{
	public class BusquedaViewModel : INotifyPropertyChanged
	{
		public string Busqueda { get; set; }

		public string Resultado { get; set; }

		public ICommand BusquedaCommand { get; set; }

		public ICommand LimpiarCommand { get; set; }

		public BusquedaViewModel()
		{
			Busqueda = "";
			Resultado = "";

			BusquedaCommand = new Command(async () =>
			{
				JSONAirport? jsonAirport = await App.APIClient.GetAirport(Busqueda);

				if (jsonAirport != null)
				{
					App.DBConnection.SaveAirport(AirportConverter.Convert(jsonAirport));
				}

				Resultado = jsonAirport == null ? "Error: No se encontró el registro" : jsonAirport.name;
				OnPropertyChanged(nameof(Resultado));
			});

			LimpiarCommand = new Command(() =>
			{
				Busqueda = "";
				Resultado = "";

				OnPropertyChanged(nameof(Busqueda));
				OnPropertyChanged(nameof(Resultado));
			});
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
