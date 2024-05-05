using Biblioteca_Clase_3;
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

            Boligrafo boliAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("Boligrafo 1:");
            Console.WriteLine($"Color: {boliAzul.GetColor()}");
            Console.WriteLine($"Tinta restante: {boliAzul.GetTinta()}");

            Console.WriteLine("\nBoligrafo 2:");
            Console.WriteLine($"Color: {boliRojo.GetColor()}");
            Console.WriteLine($"Tinta restante: {boliRojo.GetTinta()}");

            string dibujo;
            boliAzul.Pintar(3, out dibujo);
            Console.ForegroundColor = boliAzul.GetColor();
            Console.WriteLine($"\n{dibujo}");
            Console.WriteLine($"Tinta restante: {boliAzul.GetTinta()}");
            boliAzul.Recargar();
            Console.WriteLine($"Tinta restante: {boliAzul.GetTinta()}");
            Console.ResetColor();

            short gasto = 6;
            bool pudoPintar = boliRojo.Pintar(gasto, out dibujo);

            if (pudoPintar)
            {
                Console.ForegroundColor = boliRojo.GetColor();
                Console.WriteLine($"\n{dibujo}");
                Console.WriteLine($"Se intento gastar {gasto} unidades de tinta.");
                Console.WriteLine($"Tinta restante: {boliRojo.GetTinta()}");
                boliRojo.Recargar();
                Console.WriteLine($"Tinta restante: {boliRojo.GetTinta()}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = boliRojo.GetColor();
                Console.WriteLine($"\n{dibujo}");
                Console.WriteLine($"Se intento gastar {gasto} unidades de tinta y no se pudo completar el dibujo por falta de tinta, se recargará el boligrafo.");
                boliRojo.Recargar();
                Console.ResetColor();
            }


            Console.Write("\nOprima cualquier boton para concluir...");
            Console.ReadKey();
        }
    }
}
