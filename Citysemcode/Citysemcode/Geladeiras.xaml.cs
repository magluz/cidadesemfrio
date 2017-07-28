using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citysemcode.Class;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Citysemcode
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Geladeiras : ContentPage
	{
        public Geladeiras(Cidades Cidade)
        {
            InitializeComponent();

            foreach (Cidades city in App.listaCidades)
            {
                if(city.Nome == Cidade.Nome)
                {
                    GeladeirasList.ItemsSource = city.Geladeiras;
                }
            }
        }
	}
}