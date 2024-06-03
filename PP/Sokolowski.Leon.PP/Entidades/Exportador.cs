using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador : Comercio
    {
        #region Atributos
        private ETipoProducto _tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _tipo.
        /// </summary>
        public ETipoProducto Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo publico de instancia por defecto de la clase Exportador.
        /// </summary>
        public Exportador() { }

        /// <summary>
        /// Constructor publico de instancia de la clase Exportador.
        /// Inicializara el atributo _tipo y heredara los demas atributos de la clase Comercio.
        /// </summary>
        /// <param name="nombreComecio">Parametro que refiere al nombre del comercio.</param>
        /// <param name="precioAlquiler">Parametro que refiere al precio de alquiler del comercio.</param>
        /// <param name="comerciante">Parametro que refiere al comerciante que ejerce en el comercio.</param>
        /// <param name="tipo">Parametro que refiere al tipo de mercado al que exportara.</param>
        public Exportador(string nombreComecio, float precioAlquiler, Comerciante comerciante, ETipoProducto tipo) : base(nombreComecio, comerciante, precioAlquiler)
        {
            _tipo = tipo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo publico de instancia de la clase Exportador.
        /// Devuelve un string con todos la informacion de la clase.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            return $"{(string)this}\nTipo: {Tipo}";
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador de igualdad.
        /// Devuelve un booleano. Sera True si los comercios y el tipo de la clase Exportador son iguales. False caso contrario.
        /// </summary>
        /// <param name="e1">Parametro que refiere al exportador numero 1.</param>
        /// <param name="e2">Parametro que refiere al exportador numero 2.</param>
        /// <returns></returns>
        public static bool operator ==(Exportador e1, Exportador e2)
        {
            return e1 == e2 && e1.Tipo == e2.Tipo;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad.
        /// Devuelve un booleano. Sera True si los comercios y el tipo de la clase Exportador son diferentes. False caso contrario.
        /// </summary>
        /// <param name="e1">Parametro que refiere al exportador numero 1.</param>
        /// <param name="e2">Parametro que refiere al exportador numero 2.</param>
        /// <returns></returns>
        public static bool operator !=(Exportador e1, Exportador e2)
        {
            return !(e1 == e2);
        }

        /// <summary>
        /// Sobrecarga del operador de conversion al tipo de dato ETipoProducto.
        /// Devuelve el valor del atributo _tipo de la clase Exportador. 
        /// </summary>
        /// <param name="exportador"></param>
        public static implicit operator ETipoProducto(Exportador exportador)
        {
            return exportador._tipo;
        }
        #endregion

    }
}
