using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Comercio
    {
        #region Atributos
        protected int _cantidadDeEmpleados = 0;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _cantidadDeEmpleados. De ser 0, lo instanciará como un número aleatorio del 1 al 100 utilizando el atributo _generadorDeEmpleados.
        /// </summary>
        public int CantidadDeEmpleados
        {
            get
            {
                if (_cantidadDeEmpleados == 0)
                {
                    return _generadorDeEmpleados.Next(1, 101);
                }
                else
                {
                    return _cantidadDeEmpleados;
                }
            }
            set { _cantidadDeEmpleados = value; }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _comerciante.
        /// </summary>
        public Comerciante Comerciante
        {
            get { return _comerciante; }
            set { _comerciante = value; }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _nombre.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Propiedad pública de lectura y escritura para el atributo _precioAlquiler.
        /// </summary>
        public float PrecioAlquiler
        {
            get { return _precioAlquiler; }
            set { _precioAlquiler = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estático de la clase Comercio.
        /// Inicializara el atributo de la clase Random _generadorDeEmpleados.
        /// </summary>
        static Comercio()
        {
            _generadorDeEmpleados = new Random();

        }

        /// <summary>
        /// Constructor publico de instancia por defecto de la clase Comercio.
        /// </summary>
        public Comercio() { }

        /// <summary>
        /// Constructor publico de instancia de la clase Comercio.
        /// Inicializara los atributos _nombre, _comerciante y _precioAlquiler.
        /// </summary>
        /// <param name="nombre">Parametro que refiere al nombre del comercio.</param>
        /// <param name="comerciante">Parametro que refiere al comerciante que ejerce en el comercio.</param>
        /// <param name="precioAlquiler">Parametro que refiere al precio de alquiler del comercio.</param>
        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            _nombre = nombre;
            _comerciante = comerciante;
            _precioAlquiler = precioAlquiler;
        }

        /// <summary>
        /// Constructor publico de instancia de la clase Comercio.
        /// Instanciará el objeto comerciante con los parametros de nombre y apellido.
        /// </summary>
        /// <param name="precioAlquiler">Parametro que refiere al precio de alquiler del comercio.</param>
        /// <param name="nombreComercio">Parametro que refiere al nombre del comercio.</param>
        /// <param name="nombre">Parametro que refiere al nombre del comerciante.</param>
        /// <param name="apellido">Parametro que refiere al apellido del comerciante.</param>
        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this(nombreComercio, new Comerciante(nombre, apellido), precioAlquiler)
        {
            
            _comerciante.Nombre = nombre;
            _comerciante.Apellido = apellido;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo privado de instancia de la clase Comercio.
        /// Devuelve un string que contiene toda la información de la clase.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            return $"Nombre: {Nombre}\nComerciante: {(string)Comerciante}\nCantidad de empleados: {CantidadDeEmpleados}\nPrecio Alquiler: {PrecioAlquiler}";
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador de igualdad.
        /// Devuelve un booleano.Sera true en caso de que el nombre del comercio y los comerciantes de los dos comercios sean iguales. False caso contrario.
        /// </summary>
        /// <param name="c1">Parametro que refiere al comercio número 1.</param>
        /// <param name="c2">Parametro que refiere al comercio número 2.</param>
        /// <returns></returns>
        public static bool operator ==(Comercio c1, Comercio c2)
        {
            return c1.Nombre == c2.Nombre && c1.Comerciante == c2.Comerciante;
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad.
        /// Devuelve un booleano.Sera true en caso de que el nombre del comercio y los comerciantes de los dos comercios sean diferentes. False caso contrario.
        /// </summary>
        /// <param name="c1">Parametro que refiere al comercio número 1.</param>
        /// <param name="c2">Parametro que refiere al comercio número 2.</param>
        /// <returns></returns>
        public static bool operator !=(Comercio c1, Comercio c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Sobrecarga del operador de conversión al tipo de dato string.
        /// Devuelve un el metodo Mostrar de la clase Comercio.
        /// </summary>
        /// <param name="comercio|">Parametro que refiere al comercio.</param>
        public static explicit operator string(Comercio comercio)
        {
            return comercio.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del metodo Equals.
        /// Devuelve un booleano. True en caso de que los dos objetos sean del mismo tipo y si el objeto pasado parametro es igual al objeto que llama al metodo. False caso contrario.
        /// </summary>
        /// <param name="obj">Parametro que refiere a un objeto de cualquier clase.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Comercio comercio && comercio == this;
        }


        #endregion
    }
}
