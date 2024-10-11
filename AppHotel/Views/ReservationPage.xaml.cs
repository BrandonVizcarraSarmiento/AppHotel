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
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private async void OnReserveClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            // Animación de escalado
            await button.ScaleTo(1.1, 100, Easing.CubicIn);
            await button.ScaleTo(1.0, 100, Easing.CubicOut);
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(EntryName.Text) ||
                string.IsNullOrWhiteSpace(EntryEmail.Text) ||
                !singleRoomRadioButton.IsChecked && !doubleRoomRadioButton.IsChecked && !suiteRoomRadioButton.IsChecked)
            {
                await DisplayAlert("Error", "Por favor, completa todos los campos requeridos.", "Aceptar");
                return;
            }

            // Crear el popup de confirmación
            bool isConfirmed = await DisplayAlert("Confirmar Reserva", "¿Estás seguro de que quieres realizar la reserva?", "Confirmar", "Cancelar");

            if (isConfirmed)
            {
                // Mostrar mensaje de confirmación
                await DisplayAlert("Confirmación", "Reserva completada con éxito.", "Aceptar");

                // Limpiar los campos
                EntryName.Text = string.Empty;
                EntryEmail.Text = string.Empty;
                singleRoomRadioButton.IsChecked = false;
                doubleRoomRadioButton.IsChecked = false;
                suiteRoomRadioButton.IsChecked = false;

                // Cerrar la página
                await Navigation.PopAsync();
            }
        }
    }
}