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
	public partial class Cadastro : ContentPage
	{
		public Cadastro ()
		{
			InitializeComponent();
        }

        void Cadastrar(object sender, EventArgs args)
        {
            Pessoa person = new Pessoa();

            person.Cidade = Cidade.SelectedItem.ToString();
            person.Usuario = Usuario.Text;
            person.Senha = Senha.Text;
            person.Email = Email.Text;

            App.listaPessoas.Add(person);

            Navigation.PushAsync(new Login());
        }
	}
}