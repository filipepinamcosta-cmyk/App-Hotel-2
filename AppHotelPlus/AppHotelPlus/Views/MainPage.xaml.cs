using Microsoft.Maui.Controls;
using AppHotelPlus.ViewModels;

namespace AppHotelPlus.Views
{
    public partial class MainPage : ContentPage
    {
        private HospedeViewModel _vm = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCadastrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage(_vm));
        }

        private async void BtnLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaHospedesPage(_vm));
        }
    }
}
