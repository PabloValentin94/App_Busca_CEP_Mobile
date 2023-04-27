using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP.Model;
using App_Busca_CEP.Service;

namespace App_Busca_CEP.View.Pages.Options
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CEPs_por_Logradouro : ContentPage
    {

        public CEPs_por_Logradouro()
        {

            InitializeComponent();

        }

        private async void btn_busca_Clicked(object sender, EventArgs e)
        {

            try
            {

                btn_busca.IsEnabled = false;

                ai_carregamento.IsRunning = true;

                List<CEP> lista_ceps_encontrados = await Data_Service.GetCEPByLogradouro(txt_logradouro.Text);

                listagem_ceps.ItemsSource = lista_ceps_encontrados;


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