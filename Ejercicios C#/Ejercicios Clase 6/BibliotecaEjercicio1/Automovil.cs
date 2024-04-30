using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio1
{
    public class Automovil : VehiculoTerrestre
    {
        #region Atributos
        protected int cantidadPasajeros;
        #endregion

        #region Constructor
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
        #endregion

        #region Propiedades
        public int Pasajeros { get { return this.cantidadPasajeros; } set { this.cantidadPasajeros = value; } }

        #endregion

        #region Metodos
        public void MostrarDatosAutomovil()
        {
            MostrarDatos();
            MostrarMarchas();
            Console.WriteLine($"Cantidad máxima de pasajeros: {Pasajeros}");
        }
        #endregion
    }
}
