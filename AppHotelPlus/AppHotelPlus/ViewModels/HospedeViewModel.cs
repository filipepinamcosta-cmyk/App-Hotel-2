using System.Collections.ObjectModel;
using AppHotelPlus.Models;

namespace AppHotelPlus.ViewModels
{
    public class HospedeViewModel
    {
        public ObservableCollection<Hospede> Hospedes { get; set; } = new();

        public void Adicionar(Hospede h)
        {
            Hospedes.Add(h);
        }
    }
}
