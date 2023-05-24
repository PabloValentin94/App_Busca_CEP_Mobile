using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Busca_CEP_Mobile.View.Pages.Menu;

namespace App_Busca_CEP_Mobile
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {

        public Menu()
        {

            InitializeComponent();

            img_logo.Source = ImageSource.FromResource("App_Busca_CEP_Mobile.View.Assets.Images.Logo_menu.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

        }

        private void btn_home_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

            IsPresented = false;

        }

        private void btn_sobre_escola_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Sobre_a_Escola)));

            IsPresented = false;

        }

        private void btn_sobre_curso_DS_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Sobre_o_Curso)));

            IsPresented = false;

        }

        private void btn_sobre_turma_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Sobre_a_Turma)));

            IsPresented = false;

        }

    }

}