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
using Xamarin.Forms.Internals;

namespace App_Busca_CEP.View
{


    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Bairros_por_Cidade : ContentPage
    {

        string[] estados = {"AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", 
                            "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", 
                            "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF"};

        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();

        ObservableCollection<Bairro> lista_bairros = new ObservableCollection<Bairro>();

        public Bairros_por_Cidade()
        {

            InitializeComponent();

            pck_estado.ItemsSource = this.estados;

            pck_cidade.ItemsSource = this.lista_cidades;

        }

        private async void btn_busca_Clicked(object sender, EventArgs e)
        {

            try
            {

                btn_busca.IsEnabled = false;

                ai_carregamento.IsRunning = true;

                List<Bairro> lista_bairros_encontrados = this.lista_bairros.ToList();

                listagem_bairros.ItemsSource = lista_bairros_encontrados;

            }

            catch(Exception ex)
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

                /*for (int i = 0; i < listagem_cidades.Count; i++)
                {

                    Console.WriteLine(listagem_cidades[i].descricao);

                }*/

                this.lista_cidades.Clear();

                listagem_cidades.ForEach(i => this.lista_cidades.Add(i));

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Picker picker_cidade = sender as Picker;

                Cidade cidade_selecionada = picker_cidade.SelectedItem as Cidade;

                //Console.WriteLine(cidade_selecionada);
                //Console.WriteLine(cidade_selecionada.id_cidade);

                List<Bairro> listagem_bairros = await Data_Service.GetBairrosByIDCidade(cidade_selecionada.id_cidade);

                this.lista_bairros.Clear();

                listagem_bairros.ForEach(i => this.lista_bairros.Add(i));

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}