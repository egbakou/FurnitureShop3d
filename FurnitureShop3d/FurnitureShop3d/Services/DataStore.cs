/*
DataStore.cs
13/06/2020 07:04:24
Kodjo Laurent Egbakou
*/

using FurnitureShop3d.Models;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureShop3d.Services
{
    public static class DataStore
    {
        static DataStore()
        {
            List<Item> furnitures = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Janet",
                    Price = "$599",
                    Category = "Office Chairs, Recliners",
                    Image = "blue.png",
                    Description = "Meet Janet- a dainty lounge chair that will up the glam quotient of any space. Use this comfy design as extra seating to park your guets in. Or as a study chair to think deep thoughts in.",
                    Variations = new List<Variation>()
                    {
                        new Variation () { ColorHex="#06696F", Image="blue" },
                        new Variation () { ColorHex="#328AA8", Image="pulpe" },
                        new Variation () { ColorHex="#CA6E25", Image="orange" },
                        new Variation () { ColorHex="#B31F23", Image="red" }
                    }
                },
                new Item
                {
                    Id = 2,
                    Name = "Morgen",
                    Price = "$649",
                    Category = "Recliners, Recliners, Office",
                    Image = "pulpe.png",
                    Description = "Inspired by the construction of high-performance Ski boots, Stuttgart-based designers designed the Morgen Lounge Chair in layers to deliver a premium experience of comfort.",
                    Variations = new List<Variation>()
                    {
                        new Variation () { ColorHex="#328AA8", Image="pulpe" },
                        new Variation () { ColorHex="#06696F", Image="blue" },
                        new Variation () { ColorHex="#CA6E25", Image="orange" },
                        new Variation () { ColorHex="#B31F23", Image="red" }
                    }
                },
                new Item
                {
                    Id = 3,
                    Name = "Carven",
                    Price = "$619",
                    Category = "Office Chairs, Recliners, Loungue chairs, Office",
                    Image = "orange.png",
                    Description = "Delightfully Danish. The Carven Lounge Chair blends classic Mid-Century details with a chic contrasting colour scheme to create a stylish, inviting lounge chair. comfort.",
                    Variations = new List<Variation>()
                    {
                        new Variation () { ColorHex="#CA6E25", Image="orange" },
                        new Variation () { ColorHex="#328AA8", Image="pulpe" },
                        new Variation () { ColorHex="#06696F", Image="blue" },
                        new Variation () { ColorHex="#B31F23", Image="red" }
                    }
                },
                new Item
                {
                    Id = 4,
                    Name = "Rochelle",
                    Price = "$729",
                    Category = "Office Chairs, Recliners, Loungue chairs, Office",
                    Image = "red.png",
                    Description = "Wing your way to confort. The Rochelle Wing Chair, the perfect spot for an afternoon snooze also lets you sink in, while the enclosing wings let you create a cozy cocoon. around you.",
                    Variations = new List<Variation>()
                    {
                        new Variation () { ColorHex="#B31F23", Image="red" },
                        new Variation () { ColorHex="#CA6E25", Image="orange" },
                        new Variation () { ColorHex="#328AA8", Image="pulpe" },
                        new Variation () { ColorHex="#06696F", Image="blue" },
                    }
                }
            };

            Items = new List<Item>(furnitures);
        }

        public static List<Item> Items;

        public static List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category() {CategoryName = "All"},
                new Category() {CategoryName = "Office Chairs"},
                new Category() {CategoryName = "Recliners"},
                new Category() {CategoryName = "Loungue chairs"},
                new Category() {CategoryName = "Office"}
            };
            return categories;
        }

        internal static IEnumerable<Item> GetItemsForCategory(string obj)
        {
            if (obj.Equals("All"))
                return Items;
            else
                return Items.Where(n => n.Category.Contains(obj));
        }
      
    }
}
