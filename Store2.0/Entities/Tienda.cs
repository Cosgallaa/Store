using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2._0.Entities
{
     class Tienda
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su correo: ");
            string correo = Console.ReadLine();

            Console.WriteLine($"Bienvenido(a) {nombre} ({correo})");

            Console.Write("¿Cuántos artículos va a comprar? ");
            int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

            Cliente customer = new Cliente(nombre, correo, cantidadArticulos);

            for (int i = 1; i <= cantidadArticulos; i++)
            {
                Console.WriteLine($"Artículo #{i}");
                Console.Write("Ingrese el nombre del artículo: ");
                string nombreArticulo = Console.ReadLine();
                Console.Write("Ingrese el precio del artículo: ");
                double precioArticulo = Convert.ToDouble(Console.ReadLine());

                Articulo article = new Articulo(nombreArticulo, precioArticulo);
                customer.AgregarArticulo(article);
            }

            PrecioArticulo priceCalculator = new PrecioArticulo();
            double total = priceCalculator.precioTotal(customer);

            Console.WriteLine("El total a pagar es: $" + total);

            if (total > 8000)
            {
                Console.WriteLine("¡Tiene la opción de 3 meses sin intereses!");
            }

            else if (total > 10000)
            {
                Console.WriteLine("¡Tiene un descuento adicional del 30%!");
                total *= 0.7;
                Console.WriteLine("¡Tiene la opción de hasta 12 meses sin intereses!" + total );
            }
            else if (total > 5000 )
            {
                Console.WriteLine("¡Tiene un descuento del 10%!");
                total *= 0.9;

            }

            Console.WriteLine("Gracias por su compra. El total a pagar es: $" + total);

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
     }
}

