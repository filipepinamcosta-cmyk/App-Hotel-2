using Microsoft.Maui.Controls;
using AppHotelPlus.Models;
using AppHotelPlus.ViewModels;
using System;

namespace AppHotelPlus.Views
{
    public partial class CadastroPage : ContentPage
    {
        private readonly HospedeViewModel _viewModel;

        public CadastroPage(HospedeViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;
        }

        private async void BtnSalvar_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    await DisplayAlert("Aviso", "Informe o nome do hóspede.", "OK");
                    return;
                }

                if (!int.TryParse(txtIdade.Text, out int idade))
                {
                    await DisplayAlert("Aviso", "Informe uma idade válida (número).", "OK");
                    return;
                }

                var hospede = new Hospede
                {
                    Nome = txtNome.Text.Trim(),
                    Idade = idade,
                    DataCheckin = dpCheckin.Date
                };

                _viewModel.Adicionar(hospede);

                await DisplayAlert("Sucesso", $"Hóspede '{hospede.Nome}' cadastrado.", "OK");

                // Clear fields
                txtNome.Text = string.Empty;
                txtIdade.Text = string.Empty;
                dpCheckin.Date = DateTime.Today;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
