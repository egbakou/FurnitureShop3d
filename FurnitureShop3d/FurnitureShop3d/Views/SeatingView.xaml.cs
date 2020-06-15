using FurnitureShop3d.ViewModels;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FurnitureShop3d.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeatingView : ContentPage
    {
        private SeatingViewModel viewModel;

        public SeatingView()
        {
            InitializeComponent();
            BindingContext = viewModel = new SeatingViewModel();
            SelectAllFilter();
        }
       
        private void SelectAllFilter()
        {
            SelectCategory(filterBox.Children[0], null);
        }
        private void SelectCategory(object sender, EventArgs e)
        {
            var view = sender as View;
            var parent = view.Parent as StackLayout;

            foreach (var child in parent.Children)
            {
                VisualStateManager.GoToState(child, "Normal");
                ChangeTextColor(child, "#707070");
            }

            VisualStateManager.GoToState(view, "Selected");
            ChangeTextColor(view, "#FFFFFF");
        }

        private void ChangeTextColor(View child, string hexColor)
        {
            var txtCtrl = child.FindByName<Label>("categoryName");

            if (txtCtrl != null)
                txtCtrl.TextColor = Color.FromHex(hexColor);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var item = (sender as View).BindingContext as ItemsViewModel;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, item.Name);
            await Navigation.PushAsync(new SeatingDetailsView(item));
        }
    }
    

}