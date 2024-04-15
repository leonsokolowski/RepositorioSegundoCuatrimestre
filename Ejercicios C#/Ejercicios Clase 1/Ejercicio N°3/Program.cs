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
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cierra la consola.
            Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.*/
            int numeroLimite;

            do
            {
                Console.Write("Ingrese un número mayor que 1: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numeroLimite))
                {
                    Console.WriteLine("Ingrese un número válido: ");
                }
            } while (numeroLimite <= 1);

            Console.WriteLine($"Los numeros primos desde el 2 hasta el {numeroLimite} son:");
            for (int i = 2; i <= numeroLimite; i++)
            {
                bool esPrimo = true;
                
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("Pulse cualquier tecla para concluir");
            Console.ReadKey();
        }
    }
}


