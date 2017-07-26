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
	public partial class SplashPage : ContentPage
	{

        public SplashPage ()
		{
			InitializeComponent ();

            Func<bool> convertMethod = NavigateSplash;

            Device.StartTimer(TimeSpan.FromSeconds(5), convertMethod);
        }

        public bool NavigateSplash()
        {
            Navigation.PushAsync(new MainPage());
            return true;
        }
	}
}