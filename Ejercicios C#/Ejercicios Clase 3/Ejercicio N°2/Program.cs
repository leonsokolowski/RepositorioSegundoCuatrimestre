using Biblioteca_Clase_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°2";

            Persona persona1 = new Persona("Wanda", new DateTime(2001, 05, 25), 43170431);
            Persona persona2 = new Persona("Leon", new DateTime(2005, 04, 21), 46581750);
            Persona persona3 = new Persona("Alejandra", new DateTime(1969, 12, 8), 21156776);

            Console.WriteLine("Seleccionando 3 personas...");
            Console.WriteLine("Datos de las personas:\n");
            persona1.MostrarDatos();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            persona2.MostrarDatos();
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            persona3.MostrarDatos();


            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
