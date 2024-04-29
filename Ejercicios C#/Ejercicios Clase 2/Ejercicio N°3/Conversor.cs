using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_3
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";

            if (numeroEntero == 0)
            {
                return "0";
            }

            while (numeroEntero > 0)
            {
                int resto = numeroEntero % 2;
                numeroBinario = resto + numeroBinario;
                numeroEntero /= 2;
            }
            return numeroBinario;
        }
        
        public static int ConvertirBinarioADecimal (int numeroBinario)
        {
            int numeroDecimal = 0;
            int potencia = 0;

            while (numeroBinario != 0)
            {
                int digito = numeroBinario % 10;
                numeroDecimal += digito * (int)Math.Pow(2, potencia);
                numeroBinario /= 10;
                potencia ++;
                
            }
            return numeroDecimal;
        }
        
    }
}
