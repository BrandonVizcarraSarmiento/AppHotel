using AppHotel.Models;
using AppHotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SectionDetailPage : ContentPage
    {
        public SectionDetailPage(Servicio servicio)
        {
            InitializeComponent();
            BindingContext = new SectionDetailViewModel(servicio);

            Title = servicio.Nombre;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            // Obtén el elemento seleccionado
            var selectedItem = e.Item as dynamic; // Usar dynamic para manejar múltiples tipos

            // Verifica si el elemento es Alojamiento, Restaurante o Bar
            if (selectedItem is Alojamiento alojamiento)
            {
                await Navigation.PushAsync(new ServicesDetailPage(alojamiento));
            }
            else if (selectedItem is Restaurante restaurante)
            {
                await Navigation.PushAsync(new ServicesDetailPage(restaurante));
            }
            else if (selectedItem is Bar bar)
            {
                await Navigation.PushAsync(new ServicesDetailPage(bar));
            }

             ((ListView)sender).SelectedItem = null;
        }
    }
}