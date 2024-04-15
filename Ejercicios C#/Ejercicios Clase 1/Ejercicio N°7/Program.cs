using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°7";
            //Calcular recibo de sueldo

            Console.WriteLine("Ingrese la cantidad de empleados: ");
            int cantidadEmpleados = Int32.Parse(Console.ReadLine());
            int recibosCalculados = 0;

            while (recibosCalculados < cantidadEmpleados)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el valor de hora trabajada de ese empleado: ");
                double valorHora = Double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los años de antigüedad del empleado: ");
                int añosAntigüedad = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes del empleado: ");
                int horasTrabajadas = Int32.Parse(Console.ReadLine());

                double total = (valorHora * horasTrabajadas) + (añosAntigüedad * 150);
                double sueldoFinal = total - ((total * 13) / 100);

                Console.WriteLine($"El sueldo que le corresponde al empleado {nombre}, integrante de la empresa hace {añosAntigüedad}, por trabajar {horasTrabajadas} horas, cotizadas en {valorHora} por hora, es de:\n${sueldoFinal}");
               
            }

            Console.Write("\nPulse cualquier tecla para concluir...");
            Console.ReadKey();
        }
    }
}
