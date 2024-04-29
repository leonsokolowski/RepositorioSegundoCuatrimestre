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
            string figura;
            
            Console.WriteLine("CALCULADORA DE AREAS");
            do
            {
                Console.Write("Ingrese la figura de la que desea calcular el area, cuadrado (CD), triangulo (T) o circulo (CC): ");
                figura = Console.ReadLine().ToUpper();
            } while (figura != "CD" && figura != "T" && figura != "CC");

            switch (figura)
            {
                case "CD":
                    Console.Write("Ingrese la longitud de lado de su cuadrado: ");
                    double longitudLado = Double.Parse(Console.ReadLine());
                    Console.Write($"El area de su cuadrado es de: {CalculadoraDeAreas.CalcularAreaCuadrado(longitudLado)}");
                    break;
                
                case "T":
                    Console.Write("Ingrese la longitud de base de su triangulo: ");
                    double ladoBase = Double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la longitud de altura de su triangulo: ");
                    double altura = Double.Parse(Console.ReadLine());
                    Console.Write($"El area de su triangulo es de: {CalculadoraDeAreas.CalcularAreaTriangulo(ladoBase, altura)}");
                    break;

                case "CC":
                    Console.Write("Ingrese la longitud de radio de su circulo: ");
                    double radio = Double.Parse(Console.ReadLine());
                    Console.Write($"El area de su circulo es de: {CalculadoraDeAreas.CalcularAreaCirculo(radio)}");
                    break;

            }

            Console.Write("\nOprima cualquier boton para concluir");
            Console.ReadKey();
        }
    }
}
