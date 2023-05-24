using App_Busca_CEP_Mobile.Model;
using App_Busca_CEP_Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Busca_CEP_Mobile.View.Pages.Options
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Endereco_por_CEP : ContentPage
    {

        public Endereco_por_CEP()
        {

            InitializeComponent();

        }

        private async void btn_busca_Clicked(object sender, EventArgs e)
        {

            try
            {

                btn_busca.IsEnabled = false;

                ai_carregamento.IsRunning = true;

                Endereco endereco_encontrado = await Data_Service.GetEnderecoByCEP(txt_cep.Text);

                this.BindingContext = endereco_encontrado;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

            finally
            {

                btn_busca.IsEnabled = true;

                ai_carregamento.IsRunning = false;

            }

        }

    }

}