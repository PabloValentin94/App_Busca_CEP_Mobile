using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

using App_Busca_CEP.Model;
using App_Busca_CEP.Service;

namespace App_Busca_CEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cidades_por_Estado : ContentPage
    {

        string[] estados = {"AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA",
                            "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ",
                            "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF"};

        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();

        public Cidades_por_Estado()
        {

            InitializeComponent();

            pck_estado.ItemsSource = this.estados;

        }

        private async void btn_busca_Clicked(object sender, EventArgs e)
        {

            try
            {

                btn_busca.IsEnabled = false;

                ai_carregamento.IsRunning = true;

                List<Cidade> lista_cidades_encontradas = this.lista_cidades.ToList();

                listagem_cidades.ItemsSource = lista_cidades_encontradas;

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

        private async void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Picker picker_estado = sender as Picker;

                string estado = picker_estado.SelectedItem as string;

                List<Cidade> listagem_cidades = await Data_Service.GetCidadesByUF(estado);

                this.lista_cidades.Clear();

                listagem_cidades.ForEach(i => this.lista_cidades.Add(i));

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}