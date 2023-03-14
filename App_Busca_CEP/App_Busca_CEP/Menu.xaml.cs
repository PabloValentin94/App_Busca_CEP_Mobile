using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP.View;

namespace App_Busca_CEP
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {

        public Menu()
        {

            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

        }

        private void btn_endereco_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_bairros_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Bairros_por_Cidade)));

            IsPresented = false;

        }

        private void btn_ruas_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_cidades_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_ceps_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CEPs_por_Logradouro)));

            IsPresented = false;

        }

    }

}