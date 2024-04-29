using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°3";

            Console.WriteLine("Ingrese un numero decimal: ");
            int decimalIngresado = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Su numero convertido es: {Conversor.ConvertirDecimalABinario(decimalIngresado)}");

            Console.WriteLine("\nIngrese un numero binario: ");
            int binarioIngresado = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Su numero convertido es: {Conversor.ConvertirBinarioADecimal(binarioIngresado)}");

            Console.Write("\nPresione cualquier tecla para concluir");
            Console.ReadKey();
        }
    }
}
