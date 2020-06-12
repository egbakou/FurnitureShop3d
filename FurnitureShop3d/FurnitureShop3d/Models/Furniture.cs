using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FurnitureShop3d.Models
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Category Categoty { get; set; }
        public List<string> Colors { get; set; }
    }
}
