using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    internal class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado;

            areaCuadrado = Math.Pow(longitudLado, 2);

            return areaCuadrado;
        }

        public static double CalcularAreaTriangulo(double ladoBase, double altura)
        {
            double areaTriangulo;

            areaTriangulo = 0.5 * ladoBase * altura;

            return areaTriangulo;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double areaCirculo;
            
            areaCirculo = Math.Pow(radio, 2) * Math.PI;

            return areaCirculo;
        }
    }
}
