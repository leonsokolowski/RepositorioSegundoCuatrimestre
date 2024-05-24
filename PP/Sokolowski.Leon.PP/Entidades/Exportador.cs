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
        public ETipoProducto Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        #endregion

        #region Constructores
        public Exportador() { }

        public Exportador(string nombreComecio, float precioAlquiler, Comerciante comerciante, ETipoProducto tipo) : base(nombreComecio, comerciante, precioAlquiler)
        {
            _tipo = tipo;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            return $"{(string)this}\nTipo: {Tipo}";
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Exportador e1, Exportador e2)
        {
            return e1 == e2 && e1.Tipo == e2.Tipo;
        }

        public static bool operator !=(Exportador e1, Exportador e2)
        {
            return !(e1 == e2);
        }

        public static implicit operator ETipoProducto(Exportador exportador)
        {
            return exportador._tipo;
        }
        #endregion

    }
}
