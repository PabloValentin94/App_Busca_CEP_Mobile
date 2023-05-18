using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Busca_CEP
{

    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            MainPage = new Menu();

            //MainPage = new View.Pages.Options.Logradouro_por_Bairro_e_Cidade();

        }

        protected override void OnStart()
        {



        }

        protected override void OnSleep()
        {



        }

        protected override void OnResume()
        {



        }

    }

}
