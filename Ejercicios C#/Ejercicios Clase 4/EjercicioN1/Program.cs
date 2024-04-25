using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Clase_4;

namespace EjercicioN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(1);

            long resultadoSumador = sumador.Sumar(2, 2);
            string concatenadoSumador = sumador.Sumar("Hola", "mundo");

            long cantidadSumasTotal = sumador + sumador2;
            bool igualdadCantidadSumas = sumador | sumador2;
            
            Console.WriteLine(concatenadoSumador);
            Console.WriteLine(resultadoSumador);
            Console.WriteLine(sumador.Cantidad);
            Console.WriteLine(cantidadSumasTotal);
            Console.WriteLine(igualdadCantidadSumas);

            Console.ReadKey();
        }
    }
}
