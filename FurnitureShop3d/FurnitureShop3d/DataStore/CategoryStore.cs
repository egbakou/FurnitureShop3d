using FurnitureShop3d.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureShop3d.DataStore
{
    public class CategoryStore
    {
        public static List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "All"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Office Chairs"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Recliners"
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Loungue chairs"
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Office"
                }
            };

            return categories;
        }
    }
}
