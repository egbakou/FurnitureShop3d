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
    public partial class SeatingView : ContentPage
    {
        private SeatingViewModel viewModel;

        public SeatingView()
        {
            InitializeComponent();
            BindingContext = viewModel = new SeatingViewModel();
            SelectAllFilter();
        }

        //public List<PropertyType> PropertyTypeList => GetPropertyTypes();

        //private List<PropertyType> GetPropertyTypes()
        //{
        //    return new List<PropertyType>
        //    {
        //        new PropertyType { TypeName = "All" },
        //        new PropertyType { TypeName = "Office chairs" },
        //        new PropertyType { TypeName = "Reclainers" },
        //        new PropertyType { TypeName = "Loungue chairs" },
        //        new PropertyType { TypeName = "Office" }
        //    };
        //}

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
            var txtCtrl = child.FindByName<Label>("PropertyTypeName");

            if (txtCtrl != null)
                txtCtrl.TextColor = Color.FromHex(hexColor);
        }
    }

    public class PropertyType
    {
        public string TypeName { get; set; }
    }

}