using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRA_B4_FOTOKIOSK.models
{
    public class KioskProduct
    {
        public string Name { get; set; }
        public double Price { get; set; } // Toegevoegd
        public string Description { get; set; } // Toegevoegd

        public KioskProduct(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - €{Price:F2} - {Description}";
        }
    }

}
