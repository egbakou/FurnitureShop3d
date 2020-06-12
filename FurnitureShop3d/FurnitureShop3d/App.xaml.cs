using FurnitureShop3d.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("Anton-Regular.ttf", Alias = "AntonRegularFont")]
[assembly: ExportFont("BreeSerif-Regular.ttf", Alias = "BreeSerifRegularFont")]
[assembly: ExportFont("Hind-Light.ttf", Alias = "HindLightFont")]
[assembly: ExportFont("Hind-Regular.ttf", Alias = "HindRegularFont")]
namespace FurnitureShop3d
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SeatingView());
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
