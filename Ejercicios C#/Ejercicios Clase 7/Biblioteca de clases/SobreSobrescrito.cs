using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class SobreSobrescrito : Sobrescrito
    {
        #region Propiedades
        public override string miPropiedad { get { return miAtributo; } }
        #endregion

        #region Metodos
        public override string MiMetodo()
        {
            return miPropiedad;
        }
        #endregion
    }
}
