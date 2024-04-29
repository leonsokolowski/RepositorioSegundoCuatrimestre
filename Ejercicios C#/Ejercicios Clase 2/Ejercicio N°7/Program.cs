using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°7";

            Console.Write("Ingrese la longitud del lado base de su triangulo rectangulo: ");
            double ladoBase = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese la longitud de la altura de su triangulo rectangulo: ");
            double altura = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Hipotenusa calculada: {CalculadoraDeHipotenusas.CalcularHipotenusas(ladoBase, altura)}");
            
            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
