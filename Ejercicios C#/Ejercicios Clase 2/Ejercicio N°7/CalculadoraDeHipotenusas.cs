using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    internal class CalculadoraDeHipotenusas
    {
        public static double CalcularHipotenusas(double ladoBase, double altura)
        {
            double hipotenusa;

            hipotenusa = Math.Sqrt(Math.Pow(ladoBase, 2) + Math.Pow(altura, 2));

            return hipotenusa;
        }
        
    }
}
