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

        }

        private void btn_busca_Clicked(object sender, EventArgs e)
        {



        }

        private void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {

            Picker picker_cidade = sender as Picker;

            Cidade cidade_selecionada = picker_cidade.SelectedItem as Cidade;

        }

        private void pck_bairro_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

    }

}