using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importador : Comercio
    {
        #region Atributos
        private EPaises _paisOrigen;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _paisOrigen.
        /// </summary>
        public EPaises PaisOrigen
        {
            get { return _paisOrigen; }
            set { _paisOrigen = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructo publico de instancia por defecto de la clase Importador.
        /// </summary>
        public Importador() { }

        /// <summary>
        /// Constructor publico de instancia de la clase Importador.
        /// Inicializara el atributo _paisOrigen y heredara los demas atributos de la clase Comercio.
        /// </summary>
        /// <param name="nombreComecio">Parametro que refiere al nombre del comercio.</param>
        /// <param name="precioAlquiler">Parametro que refiere al precio de alquiler del comercio.</param>
        /// <param name="comerciante">Parametro que refiere al comerciante que ejerce en el comercio.</param>
        /// <param name="paisOrigen">Parametro que refiere al pais de origen del comercio importador.</param>
        public Importador(string nombreComecio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen) : base(nombreComecio, comerciante, precioAlquiler)
        {
            _paisOrigen = paisOrigen;
        }
        #endregion

        /// <summary>
        /// Metodo publico de instancia de la clase Importador.
        /// Devuelve un string con todos la informacion de la clase.
        /// </summary>
        /// <returns></returns>
        #region Metodos
        public string Mostrar()
        {
            return $"{(string)this}\nPaís de Origen: {PaisOrigen}";
        }
        #endregion

        /// <summary>
        /// Sobrecarga del operador de igualdad.
        /// Devuelve un booleano. Sera True si los comercios y el pais de origen de la clase Importador son iguales. False caso contrario.
        /// </summary>
        /// <param name="i1">Parametro que refiere al importador numero 1.</param>
        /// <param name="i2">Parametro que refiere al importador numero 2.</param>
        /// <returns></returns>
        #region Sobrecargas
        public static bool operator ==(Importador i1, Importador i2)
        {
            return i1 == i2 && i1.PaisOrigen == i2.PaisOrigen;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad.
        /// Devuelve un booleano. Sera True si los comercios y el pais de origen de la clase Importador son diferentes. False caso contrario.
        /// </summary>
        /// <param name="i1">Parametro que refiere al importador numero 1.</param>
        /// <param name="i2">Parametro que refiere al importador numero 2.</param>
        /// <returns></returns>
        public static bool operator !=(Importador i1, Importador i2)
        {
            return !(i1 == i2);
        }

        /// <summary>
        /// Sobrecarga del operador de conversion al tipo de dato EPaises.
        /// Devuelve el valor de la propiedad PaisOrigen de la clase Importador. 
        /// </summary>
        /// <param name="importador"></param>
        public static implicit operator EPaises(Importador importador)
        {
            return importador.PaisOrigen;
        }
        #endregion

    }
}
