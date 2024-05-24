using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

            double numeroIngresado;
            
            do
            {
                Console.WriteLine("Ingrese un número: ");
                numeroIngresado = double.Parse(Console.ReadLine());

                if (numeroIngresado <= 0 )
                {
                    Console.WriteLine("ERROR.¡Reingresar número!: ");
                    numeroIngresado = double.Parse(Console.ReadLine());
                }
            } while (numeroIngresado <= 0);
           

            double numeroCuadrado = (double)Math.Pow(numeroIngresado, 2);
            double numeroCubico = (double)Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El cuadrado de {0:#,###.00} es {1:#,###.00} y el cubo es {2:#,###.00}", numeroIngresado, numeroCuadrado, numeroCubico);
            //Console.WriteLine($"El cuadrado de {numeroIngresado:#,###.00} es {numeroCuadrado:#,###.00} y el cubo es {numeroCubico:#,###.00}");
            Console.Write("\nOprima cualquier boton para concluir");

            Console.ReadKey();





        }
    }
}
