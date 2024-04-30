using BibliotecaEjercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°1";

            Furgon furgon = new Furgon(4, 4, Colores.Negro, 5, 500);
            Automovil auto = new Automovil(4, 4, Colores.Rojo, 5, 5);
            Ciclomotor ciclomotor = new Ciclomotor(4, 2, Colores.Azul, 5);

            furgon.MostrarDatosFurgon();
            auto.MostrarDatosAutomovil();
            ciclomotor.MostrarDatosCiclomotor();


            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
