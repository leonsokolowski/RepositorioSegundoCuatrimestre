using Biblioteca_Clase_3;
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

            Punto vertice1 = new Punto(1, 1);
            Punto vertice3 = new Punto(7, 4);

            Rectangulo rectangulo = new Rectangulo(vertice1, vertice3);

            rectangulo.MostrarDatos();

            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
