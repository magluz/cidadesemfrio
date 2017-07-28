using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Citysemcode.Class;

namespace Citysemcode
{
    public partial class App : Application
    {
        public static List<Pessoa> listaPessoas = new List<Pessoa>();
        public static List<Cidades> listaCidades = new List<Cidades>();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
