using Biblioteca_Clase_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°6";

            Cliente cliente1 = new Cliente("Juan", "Perez", "Peron 4171", 1546489698, new Mascota("Perro", "Toby", new DateTime(2020, 5, 10)));
            Cliente cliente2 = new Cliente("León", "Sokolowski", "Atuel 668", 1536461905, new Mascota("Gato", "Momo", new DateTime(2020, 9, 15)) {Vacuna = "Triple Felina"});
            Cliente cliente3 = new Cliente("Jorge", "García", "Caseros 1600", 1589456327, new Mascota("Gato", "Charly", new DateTime(2018, 4, 26)));

            Console.WriteLine(cliente1.Mostrar());
            Console.WriteLine(cliente2.Mostrar());
            Console.WriteLine(cliente3.Mostrar());

            Console.Write("\nOprima cualquier boton para concluir...");
            Console.ReadKey();
        }
    }
}
