using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string _nombre;
        private decimal _precio;
        private int _cantidad;
        #endregion

        #region Propiedades
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public decimal Precio { get { return _precio; } set { _precio = value; } }

        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        #endregion

        #region Constructores
        public Producto(string nombre, decimal precio, int cantidad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }
        #endregion

        #region Metodos
        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Cantidad en stock: {Cantidad}");
            return sb.ToString();
        }
        #endregion
    }
}
