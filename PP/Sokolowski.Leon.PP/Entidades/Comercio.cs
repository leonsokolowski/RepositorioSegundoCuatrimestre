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

        public Comerciante Comerciante
        {
            get { return _comerciante; }
            set { _comerciante = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public float PrecioAlquiler
        {
            get { return _precioAlquiler; }
            set { _precioAlquiler = value; }
        }
        #endregion

        #region Constructores
        static Comercio()
        {
            _generadorDeEmpleados = new Random();

        }

        public Comercio() { }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            _nombre = nombre;
            _comerciante = comerciante;
            _precioAlquiler = precioAlquiler;
        }
        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido) : this(nombreComercio, new Comerciante(nombre, apellido), precioAlquiler)
        {
            
            _comerciante.Nombre = nombre;
            _comerciante.Apellido = apellido;
        }

        #endregion

        #region Metodos
        private string Mostrar()
        {
            return $"Nombre: {Nombre}\nComerciante: {(string)Comerciante}\nCantidad de empleados: {CantidadDeEmpleados}\nPrecio Alquiler: {PrecioAlquiler}";
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Comercio c1, Comercio c2)
        {
            return c1.Nombre == c2.Nombre && c1.Comerciante == c2.Comerciante;
        }

        public static bool operator !=(Comercio c1, Comercio c2)
        {
            return !(c1 == c2);
        }

        public static explicit operator string(Comercio comercio)
        {
            return comercio.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Comercio comercio && comercio == this;
        }
        #endregion
    }
}
