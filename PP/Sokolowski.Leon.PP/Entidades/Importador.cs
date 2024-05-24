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
        public EPaises PaisOrigen
        {
            get { return _paisOrigen; }
            set { _paisOrigen = value; }
        }
        #endregion

        #region Constructores
        public Importador() { }
        public Importador(string nombreComecio, float precioAlquiler, Comerciante comerciante, EPaises paisOrigen) : base(nombreComecio, comerciante, precioAlquiler)
        {
            _paisOrigen = paisOrigen;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            return $"{(string)this}\nTipo: {PaisOrigen}";
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Importador i1, Importador i2)
        {
            return i1 == i2 && i1.PaisOrigen == i2.PaisOrigen;
        }

        public static bool operator !=(Importador i1, Importador i2)
        {
            return !(i1 == i2);
        }

        public static implicit operator EPaises(Importador importador)
        {
            return importador.PaisOrigen;
        }
        #endregion

    }
}
