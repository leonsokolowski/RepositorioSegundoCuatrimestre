using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°5";

            Console.WriteLine("Ingrese un númeoro: ");
            int numero;

            while (int.TryParse(Console.ReadLine(), out numero))
            {
                for (int centro = 1; centro < numero; centro++)
                {
                    int sumaAntes = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAntes += i;
                    }
                    int sumaDespues = 0;
                    for (int j = centro + 1; j <= sumaAntes; j++)
                    {
                        if ((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                            break;

                        sumaDespues += j;
                        
                    }

                    if(sumaAntes == sumaDespues)
                    {
                        Console.WriteLine($"Es un centro númerico {centro}");
                    }
                   
                }
            }
            Console.WriteLine("No es un numero");
            Console.ReadKey();
        }
    }
}
