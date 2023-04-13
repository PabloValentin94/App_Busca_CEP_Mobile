using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Busca_CEP
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opcoes : ContentPage
    {

        public Opcoes()
        {

            InitializeComponent();

            imgbtn_descobrir_endereco.Source = ImageSource.FromResource("App.View.Assets.Images.Localizacao.png");

            imgbtn_descobrir_bairros.Source = ImageSource.FromResource("App.View.Assets.Images.Localizacao.png");

            imgbtn_descobrir_ceps_logradouro.Source = ImageSource.FromResource("App.View.Assets.Images.Localizacao.png");

            imgbtn_descobrir_cidades.Source = ImageSource.FromResource("App.View.Assets.Images.Localizacao.png");

            imgbtn_descobrir_cep.Source = ImageSource.FromResource("App.View.Assets.Images.Localizacao.png");

        }

        private void imgbtn_descobrir_endereco_Clicked(object sender, EventArgs e)
        {



        }

        private void imgbtn_descobrir_bairros_Clicked(object sender, EventArgs e)
        {

        }

        private void imgbtn_descobrir_ceps_logradouro_Clicked(object sender, EventArgs e)
        {

        }

        private void imgbtn_descobrir_cidades_Clicked(object sender, EventArgs e)
        {

        }

        private void imgbtn_descobrir_cep_Clicked(object sender, EventArgs e)
        {

        }
    }

}