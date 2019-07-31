using Newtonsoft.Json;
using Shop.Common.Helpers;
using Shop.Common.Models;
using Shop.UIForms.ViewModels;
using Shop.UIForms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop.UIForms
{
    public partial class App : Application
    {
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        public App()
        {
            InitializeComponent();

            if (Settings.IsRemember)
            {
                //INFO: Se deserializa a tipo json el string almacenado en settings en la constante token
                var token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);

                var user = JsonConvert.DeserializeObject<User>(Settings.User);

                //INFO: Se verifica que la fecha de expiracion del token sea mayor a la fecha actual
                if (token.Expiration > DateTime.Now)
                {
                    var mainViewModel = MainViewModel.GetInstance();
                    mainViewModel.Token = token;
                    mainViewModel.User = user;
                    mainViewModel.UserEmail = Settings.UserEmail;
                    mainViewModel.UserPassword = Settings.UserPassword;
                    mainViewModel.Products = new ProductsViewModel();
                    this.MainPage = new MasterPage();
                    return;
                }
            }

            //INFO: se coloca la pagina de inicio la la aplicación
            MainViewModel.GetInstance().Login = new LoginViewModel();
            this.MainPage = new NavigationPage(new LoginPage());
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
