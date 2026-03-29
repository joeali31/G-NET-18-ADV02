using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_ADV02.Class
{
    public class Product
    {
        public Product(int id, string name, string category, double price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
}
