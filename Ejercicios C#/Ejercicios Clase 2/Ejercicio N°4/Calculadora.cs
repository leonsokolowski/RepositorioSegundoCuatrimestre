using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    internal class Calculadora
    {
        public double Calcular(double numero1, double numero2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (Validar(numero2) == false)
                    {
                        Console.WriteLine("Error, division por 0");
                        resultado = 0;
                        break;
                    }    
                    else
                    {
                        resultado = numero1 / numero2;
                        break;
                    }
                default:
                    Console.WriteLine("Error, no es una operacion valida");
                    resultado = 0;
                    break;
            }

            return resultado;
        }

        private bool Validar(double numero2)
        {
            if (numero2 != 0)
                return true;
            
            return false;
        }
    }
}
