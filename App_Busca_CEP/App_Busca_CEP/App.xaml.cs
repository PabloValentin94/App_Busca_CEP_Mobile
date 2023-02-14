using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP.View;

namespace App_Busca_CEP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Bairros_por_Cidade();
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
