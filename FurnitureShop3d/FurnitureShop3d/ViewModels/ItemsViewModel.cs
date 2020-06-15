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

        // behaviors
        private double _position;
        private double _rotation;
        private double _scale;

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

        public double Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        public double Rotation
        {
            get { return _rotation; }
            set { SetProperty(ref _rotation, value); }
        }

        public double Scale
        {
            get { return _scale; }
            set { SetProperty(ref _scale, value); }
        }

        public IList<VariationViewModel> Variations { get; set; }

        public Command VariationSelectedCommand { get; set; }

        public ItemsViewModel(Item item)
        {
            Name = item.Name;
            Image = item.Variations.FirstOrDefault()?.Image;
            Price = item.Price;
            Description = item.Description;

            Scale = 1;

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

        public void VariationSelectedExecute(VariationViewModel obj)
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
