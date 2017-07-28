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
		public Login ()
		{
			InitializeComponent ();

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
                foreach (Pessoa person in App.listaPessoas)
                {
                    if ((person.Usuario == UsuarioLogin.Text) && (person.Senha == SenhaLogin.Text))
                    {
                        await Navigation.PushAsync(new Cidade());

                    }
                    else
                    {
                        DisplayAlert("Atenção!", "Suas informações estão incorretas!", "OK");
                    }
                }
            }
        }
        public void Cadastro(string usuario, string senha, string email, string cidade)
        {

        }
    }
}