using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP.View.Pages.Options;

namespace App_Busca_CEP.View.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opcoes : ContentPage
    {

        public Opcoes()
        {

            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void btn_descobrir_endereco_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Endereco_por_CEP());

        }

        private async void btn_descobrir_bairros_cidade_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Bairros_por_Cidade());

        }

        private async void btn_descobrir_logradouros_bairro_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Logradouro_por_Bairro_e_Cidade());

        }

        private async void btn_descobrir_cidades_estado_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Cidades_por_Estado());

        }

        private async void btn_descobrir_ceps_logradouro_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new CEPs_por_Logradouro());

        }

    }

}