using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°8";
            Console.Write("Ingrese la fecha desde la que se calculará (dd/mm/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                int diasTranscurridos = CalcularDiasTranscurridos(fecha);
                Console.WriteLine($"Días transcurridos desde {fecha} hasta ahora: {diasTranscurridos}");
            }
            else
            {
                Console.WriteLine("Error en el ingreso de la fecha");
            }

            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }

        static int CalcularDiasTranscurridos(DateTime fecha)
        {
            TimeSpan diferencia = DateTime.Now - fecha;
            return diferencia.Days;
        }
    }
}
