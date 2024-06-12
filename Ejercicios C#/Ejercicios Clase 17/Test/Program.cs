using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermercado supermercado = new Supermercado();
            supermercado.AgregarProducto(new Producto("Leche", 2.5m, 50));
            supermercado.AgregarProducto(new Producto("Pan", 1.0m, 100));
            supermercado.AgregarProducto(new Producto("Huevos", 3.0m, 30));
            Console.WriteLine("Información de productos antes de actualizar precios:");
            supermercado.MostrarProductos();

            supermercado.ActualizarPrecios(producto => producto.Precio * 1.1m);
            Console.WriteLine("Información de productos después de actualizar precios:");

            supermercado.MostrarProductos();
            Console.ReadKey();
        }
    }
}
