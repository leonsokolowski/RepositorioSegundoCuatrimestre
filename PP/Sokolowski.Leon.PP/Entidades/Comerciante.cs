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
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion

        #region Constructores
        public Comerciante() { }

        public Comerciante(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Comerciante c1, Comerciante c2)
        {
            return c1.Nombre == c2.Nombre && c1.Apellido == c2.Apellido;
        }

        public static bool operator !=(Comerciante c1, Comerciante c2)
        {
            return !(c1 == c2);
        }

        public static implicit operator string(Comerciante comerciante)
        {
            return $"{comerciante.Nombre}, {comerciante.Apellido}";
        }
        #endregion

    }
}
