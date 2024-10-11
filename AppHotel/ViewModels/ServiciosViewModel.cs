using System.Collections.ObjectModel;
using System.Linq;
using AppHotel.Models;

namespace AppHotel.ViewModels
{
    public class ServicesViewModel
    {
        public ObservableCollection<Servicio> Servicios { get; set; }
        public ObservableCollection<Servicio> FilteredSecciones { get; set; }

        public ServicesViewModel()
        {
            Servicios = new ObservableCollection<Servicio>
            {
                new Servicio { Nombre = "Alojamiento", Imagen = "alojamiento.jpg", Tipo = "Alojamiento" },
                new Servicio { Nombre = "Restaurante", Imagen = "restaurante.jpg", Tipo = "Restaurante" },
                new Servicio { Nombre = "Bar", Imagen = "bar.jpg", Tipo = "Bar" }
                // Agrega más servicios según sea necesario
            };
            FilteredSecciones = new ObservableCollection<Servicio>(Servicios);
        }

        public void Filter(string searchText)
        {
            FilteredSecciones.Clear();
            var filteredItems = Servicios.Where(s => s.Nombre.ToLower().Contains(searchText.ToLower()));

            foreach (var item in filteredItems)
            {
                FilteredSecciones.Add(item);
            }
        }
    }
}
