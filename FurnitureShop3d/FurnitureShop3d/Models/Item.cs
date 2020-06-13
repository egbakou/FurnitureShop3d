using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FurnitureShop3d.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public List<Variation> Variations { get; set; }
    }
}
