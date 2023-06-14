using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2._0.Entities
{
    class Cliente
    {
     
            public string Nombre { get; set; }
            public string Email { get; set; }
            public int NumerodeArticles { get; set; }
            public List<Articulo> Articles { get; set; }

            public Cliente(string name, string email, int numberOfArticles)
            {
                Nombre = name;
                Email = email;
                NumerodeArticles = numberOfArticles;
                Articles = new List<Articulo>();
            }

            public void AgregarArticulo(Articulo article)
            {
                Articles.Add(article);
            }
        
    }
}
