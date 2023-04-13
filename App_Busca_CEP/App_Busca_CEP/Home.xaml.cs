using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP;

namespace App_Busca_CEP
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {

            InitializeComponent();

        }

        private async void btn_opcoes_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Opcoes());

        }

    }

}