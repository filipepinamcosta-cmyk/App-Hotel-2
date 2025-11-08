using Microsoft.Maui.Controls;
using AppHotelPlus.ViewModels;

namespace AppHotelPlus.Views
{
    public partial class ListaHospedesPage : ContentPage
    {
        public ListaHospedesPage(HospedeViewModel vm)
        {
            InitializeComponent();
            cvHospedes.ItemsSource = vm.Hospedes;
        }
    }
}
