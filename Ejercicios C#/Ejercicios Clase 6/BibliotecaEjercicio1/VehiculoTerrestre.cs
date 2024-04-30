using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio1
{
    public class VehiculoTerrestre
    {
        #region Atributos
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;
        protected short cantidadMarchas;
        #endregion

        #region Constructores
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas) : this(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
        }

        #endregion

        #region Propiedades
        public short Ruedas { get { return this.cantidadRuedas; } set { this.cantidadRuedas = value; } }
        public short Puertas { get { return this.cantidadPuertas; } set { this.cantidadPuertas = value; } }
        public Colores Color { get { return this.color; } set { this.color = value; } }
        public short Marchas { get { return this.cantidadMarchas; } set { this.cantidadMarchas = value; } }
        #endregion

        #region Metodos
        public void MostrarDatos()
        {
            Console.WriteLine($"Cantidad de ruedas: {Ruedas}.\nCantidad de puertas: {Puertas}.\nColor: {Color}");
        }

        public void MostrarMarchas()
        {
            Console.WriteLine($"Cantidad de marchas: {Marchas}");
        }
        #endregion
    }
}
