using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace JoseCerezoProgreso3.ViewModels
{
	public class RegistroBDDViewModel : INotifyPropertyChanged
	{
		public List<string> Airports => App.DBConnection.GetAllAirports().Select(x => $"Nombre: {x.Name}, País: {x.Country}, Latitud: {x.Latitude}, Longitud: {x.Longitude}, Correo: {x.Email}, Mi nombre: {x.MyName}").ToList();

		public ICommand ActualizarCommand { get; set; }

		public RegistroBDDViewModel()
		{
			ActualizarCommand = new Command(() =>
			{
				OnPropertyChanged(nameof(Airports));
			});
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
