using AppHotel.Models;
using AppHotel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Collections.Specialized.BitVector32;

namespace AppHotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SectionListPage : ContentPage
    {
        private ServicesViewModel viewModel;
        public SectionListPage()
        {
            InitializeComponent();
            viewModel = new ServicesViewModel();
            BindingContext = viewModel;
            SectionListView.ItemsSource = viewModel.FilteredSecciones;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.Filter(e.NewTextValue);
            SectionListView.ItemsSource = viewModel.FilteredSecciones;
        }

        private async void OnSectionTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var selectedSection = e.Item as Servicio;

            await Navigation.PushAsync(new SectionDetailPage(selectedSection));

            ((ListView)sender).SelectedItem = null;
        }
    }
}