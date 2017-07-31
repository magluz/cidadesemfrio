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

            MainPage = new NavigationPage(new SplashPage());

            #region Geladeiras
            Geladeira _geladeirasRecife_Num1 = new Geladeira()
            {
                Rua = "Rua Doctor Saulo Suassuna"
            };

            Geladeira _geladeirasRecife_Num2 = new Geladeira()
            {
                Rua = "Rua Sol"
            };

            Geladeira _geladeirasOlinda_Num1 = new Geladeira()
            {
                Rua = "Rua Judith Neiva de Melo"
            };

            Geladeira _geladeirasOlinda_Num2 = new Geladeira()
            {
                Rua = "Rua Rondônia"
            };

            Geladeira _geladeirasPaulista_Num1 = new Geladeira()
            {
                Rua = "Rua Frei Caneca"
            };

            Geladeira _geladeirasPaulista_Num2 = new Geladeira()
            {
                Rua = "Rua 7 de Setembro"
            };

            Geladeira _geladeirasCaruaru_Num1 = new Geladeira()
            {
                Rua = "Rua São Caetano"
            };

            Geladeira _geladeirasCaruaru_Num2 = new Geladeira()
            {
                Rua = "Rua Severino Montenegro"
            };

            Geladeira _geladeirasJaboatao_Num1 = new Geladeira()
            {
                Rua = "Rua 1ª Travessa Santa Flora"
            };

            Geladeira _geladeirasJaboatao_Num2 = new Geladeira()
            {
                Rua = "Rua Doutor Júlio Lira"
            };



            #endregion

            List<Geladeira> _listaGeladeirasRecife = new List<Geladeira>();

            _listaGeladeirasRecife.Add(_geladeirasRecife_Num1);
            _listaGeladeirasRecife.Add(_geladeirasRecife_Num2);

            Cidades cidadeRecife = new Cidades()
            {
                Nome = "Recife",
                Geladeiras = _listaGeladeirasRecife
            };

            App.listaCidades.Add(cidadeRecife);

            List<Geladeira> _listaGeladeirasOlinda = new List<Geladeira>();
            _listaGeladeirasOlinda.Add(_geladeirasOlinda_Num1);
            _listaGeladeirasOlinda.Add(_geladeirasOlinda_Num2);

            Cidades cidadeOlinda = new Cidades()
            {
                Nome = "Olinda",
                Geladeiras = _listaGeladeirasOlinda
            };

            App.listaCidades.Add(cidadeOlinda);

            List<Geladeira> _listaGeladeirasPaulista = new List<Geladeira>();
            _listaGeladeirasPaulista.Add(_geladeirasPaulista_Num1);
            _listaGeladeirasPaulista.Add(_geladeirasPaulista_Num2);

            Cidades cidadePaulista = new Cidades()
            {
                Nome = "Paulista",
                Geladeiras = _listaGeladeirasPaulista
            };

            App.listaCidades.Add(cidadePaulista);

            List<Geladeira> _listaGeladeirasCaruaru = new List<Geladeira>();
            _listaGeladeirasCaruaru.Add(_geladeirasCaruaru_Num1);
            _listaGeladeirasCaruaru.Add(_geladeirasCaruaru_Num2);

            Cidades cidadeCaruaru = new Cidades()
            {
                Nome = "Caruaru",
                Geladeiras = _listaGeladeirasCaruaru
            };

            App.listaCidades.Add(cidadeCaruaru);

            List<Geladeira> _listaGeladeirasJaboatao = new List<Geladeira>();
            _listaGeladeirasJaboatao.Add(_geladeirasJaboatao_Num1);
            _listaGeladeirasJaboatao.Add(_geladeirasJaboatao_Num2);

            Cidades cidadeJaboatao = new Cidades()
            {
                Nome = "Jaboatão dos Guararapes",
                Geladeiras = _listaGeladeirasJaboatao
            };

            App.listaCidades.Add(cidadeJaboatao);

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
