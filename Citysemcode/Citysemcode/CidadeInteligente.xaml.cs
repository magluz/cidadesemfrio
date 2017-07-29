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
	public partial class CidadeInteligente : ContentPage
	{
		public CidadeInteligente (Cidades city)
		{
			InitializeComponent ();

            GeladeirasInteligentesList.ItemsSource = city.Geladeiras;
		}

        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cidade());
        }
    }
}