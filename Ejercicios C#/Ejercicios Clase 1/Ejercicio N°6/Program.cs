using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°6";
            //Escribir un programa que determine si un año es bisiesto.

            Console.WriteLine("Para determinar todos los años bisiestos en un rango...");
            
            Console.WriteLine("Ingrese un año de inicio: ");
            int añoInicio = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un año de fin: ");
            int añoFinal = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Estos son todos los años bisiestos entre el {añoInicio} y el {añoFinal}\n");

            for (int i = añoInicio; i <= añoFinal; i++)
            {
                if ((i % 4 == 0)  && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("\nPresione cualquier tecla para concluir");
            Console.ReadKey();
        }
    }
}
