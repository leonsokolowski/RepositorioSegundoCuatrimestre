using Biblioteca_Clase_3;
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

            Estudiante estudiante1 = new Estudiante("Sokolowski", "León", "115702");
            estudiante1.SetNotaPrimerParcial(8);
            estudiante1.SetNotaSegundoParcial(4);

            Estudiante estudiante2 = new Estudiante("Sanchez", "Jorge", "123987");
            estudiante2.SetNotaPrimerParcial(2);
            estudiante2.SetNotaSegundoParcial(2);

            Estudiante estudiante3 = new Estudiante("Zunini", "Matias", "115630");
            estudiante3.SetNotaPrimerParcial(6);
            estudiante3.SetNotaSegundoParcial(4);

            Console.WriteLine("Eligiendo 3 alumnos al azar para mostrar datos:\n");
            estudiante1.Mostrar();
            Console.WriteLine("");
            estudiante2.Mostrar();
            Console.WriteLine("");
            estudiante3.Mostrar();


            Console.Write("Oprima cualquier boton para concluir...");
            Console.ReadKey();
        }
    }
}
