using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Citysemcode.Class;

namespace Citysemcode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

        }

        public async void Cadastrar(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Cadastro());
        }

        public async void Entrar(object sender, EventArgs args)
        {
            if (App.listaPessoas.Count == 0)
            {
                DisplayAlert("Atenção!", "Faça seu cadastro primeiro!", "OK");
            }
            else
            {
                if (EmailLogin.Text == null || SenhaLogin.Text == null)
                {
                    DisplayAlert("Atenção!", "Os campos devem ser preenchidos primeiro!", "OK");

                }

                else
                {
                    foreach (Pessoa person in App.listaPessoas)
                    {
                        if ((person.Email == EmailLogin.Text) && (person.Senha == SenhaLogin.Text))
                        {
                            if(person.Cidade != "Selecione")
                            {
                                Cidades cidade = App.listaCidades.Find(x => x.Nome == person.Cidade);
                                await Navigation.PushAsync(new CidadeInteligente(cidade));
                            } else
                            {
                                await Navigation.PushAsync(new Cidade());
                            }                            

                        }
                        else
                        {
                            DisplayAlert("Atenção!", "Suas informações estão incorretas!", "OK");
                        }
                    }
                }
            }
        }
    }
}