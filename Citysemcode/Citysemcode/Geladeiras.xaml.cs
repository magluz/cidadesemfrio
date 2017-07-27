using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Citysemcode
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Geladeiras : ContentPage
	{
		public Geladeiras (string cidade)
		{
			InitializeComponent ();
            Cidade.Text = cidade;
		}
	}
}