using FurnitureShop3d.Models;
using MvvmHelpers;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FurnitureShop3d.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private string name;
        private string image;
        private string price;
        private string description;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public string Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }

        public IList<VariationViewModel> Variations { get; set; }

        public Command VariationSelectedCommand { get; set; }

        public ItemsViewModel(Item item)
        {
            Name = item.Name;
            Image = item.Variations.FirstOrDefault()?.Image;
            Price = item.Price;
            Description = item.Description;

            // instantiate our collection of Variations
            Variations = new ObservableRangeCollection<VariationViewModel>();
            foreach (var variation in item.Variations)
            {
                Variations.Add(new VariationViewModel(variation));
            }

            // set the first variation as the selected one
            var firstVariation = Variations.FirstOrDefault();
            firstVariation.IsSelected = true;

            VariationSelectedCommand = new Command<VariationViewModel>(VariationSelectedExecute);
        }

        private void VariationSelectedExecute(VariationViewModel obj)
        {
            foreach (var item in Variations)
            {
                item.IsSelected = false;
            }
            obj.IsSelected = true;
            this.Image = obj.Image;
        }
    }
}
