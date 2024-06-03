using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            return Convert.ToString(numeroEntero, 2);
        }

        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            return Convert.ToInt32(numeroBinario, 2);
        }
    }
}
