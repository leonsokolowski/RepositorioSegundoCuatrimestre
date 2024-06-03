using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comerciante
    {
        #region Atributos
        private string _apellido;
        private string _nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Popriedad publica de lectura y escritura para el atributo _apellido de la clase Comerciate.
        /// </summary>
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        /// <summary>
        /// Popriedad publica de lectura y escritura para el atributo _nombre de la clase Comerciate.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor publico de instancia por defecto de la clase Comerciante
        /// </summary>
        public Comerciante() { }

        /// <summary>
        /// Constructor publico de instancia de la clase Comerciante.
        /// Inicializara los atributos _nombre y _apellido.
        /// </summary>
        /// <param name="nombre">Parametro que refiere al nombre del comerciante.</param>
        /// <param name="apellido">Parametro que refiere al apellido del comerciante.</param>
        public Comerciante(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador de igualdad.
        /// Devuelve un booleano. Sera true en caso de que el nombre y apellido de los dos comerciantes sean iguales. False caso contrario.
        /// </summary>
        /// <param name="c1">Parametro que refiere al comerciante número 1.</param>
        /// <param name="c2">Parametro que refiere al comerciante número 2.</param>
        /// <returns></returns>
        public static bool operator ==(Comerciante c1, Comerciante c2)
        {
            return c1.Nombre == c2.Nombre && c1.Apellido == c2.Apellido;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad.
        /// Devuelve un booleano. Sera true en caso de que el nombre y apellido de los dos comerciantes sean diferentes. False caso contrario.
        /// </summary>
        /// <param name="c1">Parametro que refiere al comerciante número 1.</param>
        /// <param name="c2">Parametro que refiere al comerciante número 2.</param>
        /// <returns></returns>
        public static bool operator !=(Comerciante c1, Comerciante c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del operador de conversión al tipo de dato string.
        /// Devuelve un string que contiene el nombre y el apellido del comerciante.
        /// </summary>
        /// <param name="comerciante">Parametro que refiere al comerciante.</param>
        public static implicit operator string(Comerciante comerciante)
        {
            return $"{comerciante.Nombre}, {comerciante.Apellido}";
        }
        #endregion

    }
}
