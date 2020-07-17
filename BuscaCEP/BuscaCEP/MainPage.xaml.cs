using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BuscaCEP.Service;
using BuscaCEP.Service.Model;

namespace BuscaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Buscar_Clicked(object sender, EventArgs e)
        {
            string cep = Cep.Text.Trim();
            Endereco endereco = ViaCEP.BuscarEnderecoViaCEP(cep);

            Resultado.Text = $"Endereço: {endereco.Localidade}, {endereco.UF}, {endereco.Logradouro}";
        }
    }
}
