using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio1
{
    public class Ciclomotor : VehiculoTerrestre
    {
        #region Atributos
        protected short cilindrada;
        #endregion

        #region Constructores
        public Ciclomotor(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Propiedades
        public short Cilindrada { get { return this.cilindrada; } set { this.cilindrada = value; } }
        #endregion

        #region Metodos
        public void MostrarDatosCiclomotor()
        {
            MostrarDatos();
            Console.WriteLine($"La cilindrada es de: {Cilindrada}");
        }
        #endregion
    }
}
