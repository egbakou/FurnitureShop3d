using FurnitureShop3d.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "ThemeFontRegular")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "ThemeFontMedium")]
[assembly: ExportFont("NunitoSans-Bold.ttf", Alias = "ThemeFontBold")]
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
