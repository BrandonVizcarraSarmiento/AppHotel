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
    public partial class ServicesPage : ContentPage
    {
        public ServicesPage()
        {
            InitializeComponent();
            BindingContext = new ServicesViewModel();
        }

        private async void OnServiciosTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var servicioSeleccionado = e.Item as Servicio;
            await Navigation.PushAsync(new SectionDetailPage(servicioSeleccionado));
            ((ListView)sender).SelectedItem = null;
        }

        private async void OnSearchSectionClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Animación de escalado
            await button.ScaleTo(1.1, 100, Easing.CubicIn);
            await button.ScaleTo(1.0, 100, Easing.CubicOut);
            await Navigation.PushAsync(new SectionListPage());
        }
    }
}