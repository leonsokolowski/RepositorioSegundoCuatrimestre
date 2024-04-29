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
            Calculadora calculadora = new Calculadora();
            string continuacion;
            Console.WriteLine("CALCULADORA");

            do
            {
                Console.Write("Ingrese el primer numero: ");
                double operando1 = Double.Parse(Console.ReadLine());
                Console.Write("Ingrese la operación: ");
                string operacion = Console.ReadLine();
                Console.Write("Ingrese el segundo numero: ");
                double operando2 = Double.Parse(Console.ReadLine());

                Console.WriteLine($"Resultado: {calculadora.Calcular(operando1, operando2, operacion)}");
                Console.Write("\nDesea continuar (S/N): ");
                continuacion = (Console.ReadLine()).ToUpper();

            } while (Validador.ValidadorRespuesta(continuacion));

            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
