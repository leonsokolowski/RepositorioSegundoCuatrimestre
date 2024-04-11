using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SC = System.Console;
namespace Ejercicio_N_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SC.Title = "Ejercicio N°5";


            SC.WriteLine("Ingrese un numero: ");

            if (int.TryParse(SC.ReadLine(), out int numero))
            {
                string tablaMultiplicar = ObtenerTablaMultiplicar(numero);
                SC.WriteLine(tablaMultiplicar);
            }
            else
            {
                SC.WriteLine("ERROR! Ingrese un numero entero valido.");
            }

            SC.ReadKey();
        }
        #region "Metodos"
        public static string ObtenerTablaMultiplicar(int numero)
        {
            StringBuilder tabla = new StringBuilder();

            tabla.AppendLine($"Tabla de multiplicar del numero {numero}");

            for (int i = 1 ; i <= 10; i++)
            {
                int resultado = numero * i;
                tabla.AppendLine($"{numero} * {i} = {resultado}");

            }

            return tabla.ToString();
        }
        #endregion
    }
}
