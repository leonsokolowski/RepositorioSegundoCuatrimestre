using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC = System.Console;

namespace Ejercicio_N_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";

            Random random = new Random();
            string continuacion;
            int suma = 0;
            int numero;

            do
            {
                numero = random.Next(100);
                SC.WriteLine($"Numero a sumar: {numero}");
                suma += numero;
                SC.WriteLine($"Sumatoria: {suma}");
                SC.Write("Desea continuar (S/N): ");
                continuacion = (SC.ReadLine()).ToUpper();
                
            }while (Validador.ValidadorRespuesta(continuacion));

            SC.Write("\nPulse cualquier tecla para concluir");
            SC.ReadKey();
        }
    }
}
