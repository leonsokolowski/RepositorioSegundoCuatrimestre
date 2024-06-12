using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supermercado
    {
        #region Atributos
        private List<Producto> _productos;
        #endregion

        #region Propiedades
        public List<Producto> Productos { get { return _productos; } set { _productos = value; } }
        #endregion

        #region Constructores
        public Supermercado()
        {
            _productos = new List<Producto>();
        }
        #endregion

        #region Metodos
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void ActualizarPrecios(Func<Producto, decimal> actualizarPrecio)
        {
            foreach(var producto in _productos)
            {
                producto.Precio = actualizarPrecio(producto);
            }
        }

        public void MostrarProductos()
        {
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.MostrarInformacion());
            }
        }
        #endregion
    }
}
