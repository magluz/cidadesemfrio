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
            InitializeComponent();

            Cidades.ItemsSource = App.listaCidades;
        }

        public async void Cidades_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new Geladeiras((Cidades) Cidades.SelectedItem));
        }
    }
}