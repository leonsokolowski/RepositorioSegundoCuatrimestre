using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    internal class Validador
    {
        public static bool ValidadorRespuesta(string respuesta)
        {
            bool continuar = false;

            if (respuesta == "S")
            {
                continuar = true;
            }
            else if (respuesta == "N")
            {
                continuar = false;
            }

            return continuar;
        }
    }
}
