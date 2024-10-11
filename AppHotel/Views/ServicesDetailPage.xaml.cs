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
    public partial class ServicesDetailPage : ContentPage
    {
        public ServicesDetailPage(Alojamiento alojamiento)
        {
            InitializeComponent();
            BindingContext = alojamiento; // Asigna el alojamiento directamente
            Title = alojamiento.Nombre; // Establecer el título
        }

        public ServicesDetailPage(Restaurante restaurante)
        {
            InitializeComponent();
            BindingContext = restaurante;
            Title = restaurante.Nombre;
        }

        public ServicesDetailPage(Bar bar)
        {
            InitializeComponent();
            BindingContext = bar;
            Title = bar.Nombre;
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Animación de escalado
            await button.ScaleTo(1.1, 100, Easing.CubicIn);
            await button.ScaleTo(1.0, 100, Easing.CubicOut);
            await Navigation.PopAsync();
        }
    }
}