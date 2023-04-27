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

            img_logo.Source = ImageSource.FromResource("App_Busca_CEP.View.Assets.Images.Logo_menu.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Home)));

        }

        private void btn_home_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_sobre_escola_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_sobre_curso_DS_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_sobre_turma_Clicked(object sender, EventArgs e)
        {

        }

    }

}