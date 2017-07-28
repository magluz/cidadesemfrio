using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citysemcode.Class;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace Citysemcode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cidade : ContentPage
    {
        public Cidade()
        {
            Geladeira _geladeirasRecife_Num1 = new Geladeira()
            {
                Rua = "Rua Doctor Saulo Suassuna"
            };

            Geladeira _geladeirasRecife_Num2 = new Geladeira()
            {
                Rua = "Rua Doctor Saulo Suassuna"
            };

            List<Geladeira> _listaGeladeirasRecife = new List<Geladeira>();
            _listaGeladeirasRecife.Add(_geladeirasRecife_Num1);
            _listaGeladeirasRecife.Add(_geladeirasRecife_Num2);

            Cidades cidadeRecife = new Cidades()
            {
                Nome = "Recife",
                Geladeiras = _listaGeladeirasRecife
            };

            App.listaCidades.Add(cidadeRecife);

            InitializeComponent();

            Cidades.ItemsSource = App.listaCidades;

            //BindingContext = this;
        }

        public async void Cidades_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new Geladeiras((Cidades) Cidades.SelectedItem));
        }
    }
}