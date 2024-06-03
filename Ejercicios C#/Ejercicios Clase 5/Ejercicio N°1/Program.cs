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
            Console.WriteLine("¡Números Locos!");

            Random random = new Random();
            
            int[] matrizEnteros = new int[20];

            int numero;

            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                do
                {
                    numero = random.Next(-100, 100);
                }
                while (numero == 0);

                matrizEnteros[i] = numero;
            }

            Console.WriteLine("\nVector como fue ingresado:\n");
            foreach (int integranteMatriz in matrizEnteros)
            {
                Console.WriteLine(integranteMatriz);
            }

            Console.WriteLine("\nPositivos ordenados decrecientemente:\n");
            Array.Sort(matrizEnteros, (x, y) => y.CompareTo(x));

            foreach (int integranteMatriz in matrizEnteros)
            {
                if (integranteMatriz > 0 )
                {
                    
                    Console.WriteLine(integranteMatriz);
                }  
            }
            

            Console.WriteLine("\nNegativos ordenados crecientemente:\n");
            Array.Sort(matrizEnteros);
            
            foreach (int integranteMatriz in matrizEnteros)
            {
                if (integranteMatriz < 0)
                {
                    
                    Console.WriteLine(integranteMatriz);
                }

            }
            
            Console.ReadKey();
        }
    }
}
