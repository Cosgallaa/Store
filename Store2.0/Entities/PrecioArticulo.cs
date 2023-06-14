using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2._0.Entities
{
    class PrecioArticulo
    {
            public double precioTotal(Cliente customer)
            {
                double total = 0;

               
                foreach (Articulo articulo in customer.Articles)
                    {
                        total += articulo.Price;
                    }

                return total;
            }
        
    }
}

