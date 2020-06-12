using FurnitureShop3d.Models;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureShop3d.DataStore
{
    public class FurnitureStore
    {
        public static List<Furniture> GetAllFurnitures()
        {
            List<Furniture> furnitures = new List<Furniture>
            {
                new Furniture
                {
                    Id = 1,
                    Name = "Janet",
                    Price = "$599",
                    Categoty = CategoryStore.GetAllCategories().Where(c=>c.Id ==2).FirstOrDefault(),
                    Image = "blue.png",
                    Description = @"Meet Janet- a dainty lounge chair 
                                    that will up the glam quotient of any
                                    space. Use this comfy design as
                                    extra seating to park your guets in.
                                    Or as a study chair to think deep
                                    thoughts in.",
                    Colors = new List<string>(){ "#06696F", "#CA6E25", "#328AA8", "#B31F23" }
                },
                new Furniture
                {
                    Id = 2,
                    Name = "Morgen",
                    Price = "$649",
                    Categoty = CategoryStore.GetAllCategories().Where(c=>c.Id ==2).FirstOrDefault(),
                    Image = "pulpe.png",
                    Description = @"Inspired by the construction of high-
                                    performance Ski boots, Stuttgart-
                                    based designers designed the
                                    Morgen Lounge Chair in layers to
                                    deliver a premium experience of
                                    comfort.",
                    Colors = new List<string>(){ "#328AA8", "#06696F", "#CA6E25", "#B31F23" }
                },
                new Furniture
                {
                    Id = 3,
                    Name = "Carven",
                    Price = "$619",
                    Categoty = CategoryStore.GetAllCategories().Where(c=>c.Id ==3).FirstOrDefault(),
                    Image = "orange.png",
                    Description = @"Delightfully Danish. The Carven
                                    Lounge Chair blends classic Mid-
                                    Century details with a chic
                                    contrasting colour scheme to create
                                    a stylish, inviting lounge chair.
                                    comfort.",
                    Colors = new List<string>(){ "#CA6E25", "#06696F", "#328AA8", "#B31F23" }
                },
                new Furniture
                {
                    Id = 4,
                    Name = "Rochelle",
                    Price = "$729",
                    Categoty = CategoryStore.GetAllCategories().Where(c=>c.Id ==3).FirstOrDefault(),
                    Image = "red.png",
                    Description = @"Wing your way to confort. The
                                    Rochelle Wing Chair, the perfect
                                    spot for an afternoon snooze also
                                    lets you sink in, while the enclosing
                                    wings let you create a cozy cocoon.
                                    around you.",
                    Colors = new List<string>(){ "#B31F23", "#CA6E25", "#06696F", "#328AA8" }
                }
            };

            return furnitures;
        }
    }
}
