using Biblioteca_de_clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Ejercicio Nro 01: Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();
            Console.WriteLine(objetoSobrescrito.ToString());
            Console.WriteLine("----------------------------------------------");
            string objeto = "Siumba";
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.MiMetodo());
            Console.ReadKey();
        }
    }
}
