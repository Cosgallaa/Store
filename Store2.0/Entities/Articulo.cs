using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2._0.Entities
{
    class Articulo
    {
            public string Name { get; set; }
            public double Price { get; set; }

            public Articulo(string name, double price)
            {
                Name = name;
                Price = price;
            }
        
    }
}

