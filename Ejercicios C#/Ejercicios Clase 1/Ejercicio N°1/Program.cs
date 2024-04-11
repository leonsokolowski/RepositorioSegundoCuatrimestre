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
            Console.Title = "Ejercicio N°1";
            // Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            int numeroIngresado = 0;
            int numeroMayor = 0;
            int numeroMenor = 0;
            int sumaNumeros = 0;
            float promedio;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                sumaNumeros += numeroIngresado;

                if (i == 0)
                {
                    numeroMayor = numeroIngresado;
                    numeroMenor = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > numeroMayor)
                    {
                        numeroMayor = numeroIngresado;
                    }
                    else if (numeroIngresado < numeroMenor)
                    {
                        numeroMenor = numeroIngresado;
                    }
                }
                
            }
            promedio = (float)(sumaNumeros) / 5;

            Console.WriteLine("\nEl numero mayor es: {0}", numeroMayor);
            Console.WriteLine("El numero menor {0}", numeroMenor);
            Console.WriteLine("El promedio es {0:#,###.00}", promedio);
            Console.Write("\nOprima cualquier boton para concluir");

            Console.ReadKey();

        }

    }
}
