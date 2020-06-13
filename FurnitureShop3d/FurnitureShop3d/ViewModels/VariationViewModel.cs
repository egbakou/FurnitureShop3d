using FurnitureShop3d.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureShop3d.ViewModels
{
    public class VariationViewModel : BaseViewModel
    {
        private Variation _variation;
        private string _colorHex;
        private string _image;
        public bool _isSelected;

        public VariationViewModel(Variation variation)
        {
            _variation = variation;
            _colorHex = variation.ColorHex;
            _image = variation.Image;
            IsSelected = false;
        }

        public string ColorHex
        {
            get { return _colorHex; }
            set { SetProperty(ref _colorHex, value); }
        }

        public string Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        public bool IsSelected
        {
            get { return _isSelected; }
            set { SetProperty(ref _isSelected, value); }
        }
    }
}