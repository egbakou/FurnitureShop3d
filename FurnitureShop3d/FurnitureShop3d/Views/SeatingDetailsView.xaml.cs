using FurnitureShop3d.ViewModels;
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
    public partial class SeatingDetailsView : ContentPage
    {
        public SeatingDetailsView(ItemsViewModel item)
        {
            InitializeComponent();
            BindingContext = new SeatingDetailsViewModel(item);
        }

        private async void OnCoverFlowViewItemAppeared(PanCardView.CardsView view, PanCardView.EventArgs.ItemAppearedEventArgs args)
        {
            if (view.SelectedIndex != 0)
            {
                var frame = view.CurrentView as Frame;
                var stackLayout = frame.Children[0] as StackLayout;
                await stackLayout.Children[0].ScaleTo(1.1, 200, Easing.CubicInOut);
                await stackLayout.Children[0].ScaleTo(1, 500, Easing.CubicIn);
            }
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var variation = (sender as View).BindingContext as VariationViewModel;
            var item = coverFlowView.SelectedItem as ItemsViewModel;
            ((ItemsViewModel)coverFlowView.SelectedItem).VariationSelectedExecute(variation);
        }
    }
}