using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace Ejercicio_N_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();

            Console.WriteLine(Conversor.ConvertirBinarioADecimal("1010"));

            Console.ReadKey();
        }
    }
}
