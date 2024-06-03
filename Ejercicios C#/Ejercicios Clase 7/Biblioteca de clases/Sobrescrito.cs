using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public abstract class Sobrescrito
    {
        #region Atributos
        protected string miAtributo;
        #endregion

        #region Constructores
        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        #endregion

        #region Propiedades
        public abstract string miPropiedad {get;}
        #endregion

        #region Metodos
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }

        public abstract string MiMetodo();
        #endregion
    }

    
}
