using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clase_4
{
    public class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Constructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        { }
        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns>
        public long Sumar(long numero1, long numero2)
        {
            this.cantidadSumas++;
            return numero1 + numero2;
        }

        public string Sumar(string texto1, string texto2)
        {
            this.cantidadSumas++;
            return texto1 + texto2;

        }
        #endregion

        #region Propiedades
        public int Cantidad
        {
            get
            {
                return this.cantidadSumas;
            }
            set
            {
                this.cantidadSumas = value;
            }
        }

        #endregion

        #region Conversores
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return (int)sumador1 + (int)sumador2;
        }

        public static bool operator | (Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
        #endregion
    }

}
