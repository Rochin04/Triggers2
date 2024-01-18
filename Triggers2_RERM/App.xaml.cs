using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Triggers2_RERM.Views;

namespace Triggers2_RERM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Categorias();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
