using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Clase_3;

namespace Ejercicio_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°1";

            //Primer ejemplo
            Cuenta primeraCuenta = new Cuenta("Leon", 500);

            Console.WriteLine(primeraCuenta.Mostrar());

            primeraCuenta.Ingresar(200);
            Console.WriteLine(primeraCuenta.Mostrar());

            primeraCuenta.Retirar(200);
            Console.WriteLine(primeraCuenta.Mostrar());

            //Segundo ejemplo
            Cuenta segundaCuenta = new Cuenta("Rocio", 1000);

            Console.WriteLine(segundaCuenta.Mostrar());

            segundaCuenta.Ingresar(10000);
            Console.WriteLine(segundaCuenta.Mostrar());

            segundaCuenta.Retirar(6000);
            Console.WriteLine(segundaCuenta.Mostrar());



            Console.ReadKey();
        }
    }
}
