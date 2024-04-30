using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicio1
{
    public class Furgon : VehiculoTerrestre
    {
        #region Atributos
        protected int pesoCarga;
        #endregion

        #region Constructores
        public Furgon(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base (cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }
        #endregion

        #region Propiedades
        public int PesoCarga {get{return this.pesoCarga;} set{this.pesoCarga = value;}}
        #endregion

        #region Metodos
        public void MostrarDatosFurgon() 
        {
            MostrarDatos();
            MostrarMarchas();
            Console.WriteLine($"Peso de carga máximo: {PesoCarga}kg");
        }
        #endregion
    }
}
