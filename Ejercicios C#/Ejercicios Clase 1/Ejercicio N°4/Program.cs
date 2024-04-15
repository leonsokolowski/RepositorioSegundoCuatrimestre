using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°4";
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.

            long numero = 1;
            int cantidadNumerosPerfectos = 0;

            Console.WriteLine("Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros\r\npositivos (excluido el mismo) que son divisores del número.\nLos primeros 4 números perfectos son:\n");

            while (cantidadNumerosPerfectos < 4)
            { 
                int sumaDivisores = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }
            
                if (sumaDivisores == numero)
                {
                    Console.WriteLine(numero);
                    cantidadNumerosPerfectos++;
                }
                
                numero++;
            }
            Console.Write("\nPulse cualquier tecla para concluir");
            Console.ReadKey();
        }
    }
}
