using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC = System.Console;

namespace Ejercicio_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio N°1";

            int rangoMaximo = 100;
            int rangoMinimo = -100;
            int maximo = 0;
            int minimo = 0;
            int suma = 0;
            double promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                SC.WriteLine("Ingrese un numero mayor a -100 y menor a 100: ");
                int numero = Int32.Parse(Console.ReadLine());

                if (Validador.Validar(numero, rangoMinimo, rangoMaximo))
                {
                    if (maximo == 0 || numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (minimo == 0 || numero < minimo)
                    {
                        minimo = numero;
                    }

                    suma += numero;

                }
                else
                {
                    SC.WriteLine("Numero fuera de rango");
                    i--;
                }
            }

            promedio = (float)(suma) / 10;

            SC.WriteLine("\nEl número máximo de los 10 numeros ingresados es {0}", maximo);
            SC.WriteLine("El número mínimo es {0}", minimo);
            SC.WriteLine("El promedio de los números ingresados es {0: #,###.00}", promedio);

            Console.Write("\nOprima cualquier boton para concluir");

            Console.ReadKey();
        }
    }
}
