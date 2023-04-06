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
    public partial class Logradouro_por_Bairro_e_Cidade : ContentPage
    {

        string[] estados = {"AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA",
                            "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ",
                            "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF"};

        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();

        ObservableCollection<Bairro> lista_bairros = new ObservableCollection<Bairro>();

        ObservableCollection<Logradouro> lista_logradouros = new ObservableCollection<Logradouro>();

        public Logradouro_por_Bairro_e_Cidade()
        {

            InitializeComponent();

            pck_estado.ItemsSource = this.estados;

            pck_cidade.ItemsSource = this.lista_cidades;

            pck_bairro.ItemsSource = this.lista_bairros;

        }

        private async void btn_busca_Clicked(object sender, EventArgs e)
        {

            try
            {

                btn_busca.IsEnabled = false;

                ai_carregamento.IsRunning = true;

                List<Logradouro> lista_logradouros_encontrados = this.lista_logradouros.ToList();

                listagem_logradouros.ItemsSource = lista_logradouros_encontrados;

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

        private async void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Picker picker_cidade = sender as Picker;

                Cidade cidade_selecionada = picker_cidade.SelectedItem as Cidade;

                List<Bairro> listagem_bairros = await Data_Service.GetBairrosByIDCidade(cidade_selecionada.id_cidade);

                this.lista_bairros.Clear();

                listagem_bairros.ForEach(i => this.lista_bairros.Add(i));

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void pck_bairro_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                Picker picker_bairro = sender as Picker;

                Bairro bairro_selecionado = picker_bairro.SelectedItem as Bairro;

                List<Logradouro> listagem_logradouros = 
                await Data_Service.GetLogradouroByBairroAndIDCidade(bairro_selecionado.descricao_bairro, 
                                                                    bairro_selecionado.id_cidade);

                this.lista_logradouros.Clear();

                listagem_logradouros.ForEach(i => this.lista_logradouros.Add(i));

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}