using FurnitureShop3d.Services;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace FurnitureShop3d.ViewModels
{
    public class SeatingDetailsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<ItemsViewModel> Items { get; set; }
        public ItemsViewModel SelectedItem { get; set; }

        public SeatingDetailsViewModel(ItemsViewModel selectedItemVM)
        {
            var items = DataStore.Items.Where(i => i.Name != selectedItemVM.Name);
            var selectedItem = DataStore.Items
                .Where(i => i.Name.Equals(selectedItemVM.Name))
                .First();
            Items = new ObservableRangeCollection<ItemsViewModel>();
            foreach (var item in items)
            {
                Items.Add(new ItemsViewModel(item));
            }
            Items.Insert(0, new ItemsViewModel(selectedItem));
        }

    }
}
