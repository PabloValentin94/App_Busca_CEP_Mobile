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

    }

}