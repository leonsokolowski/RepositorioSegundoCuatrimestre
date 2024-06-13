using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotificacionEventArgs : EventArgs
    {
        private string _mensaje;

        public string Mensaje { get { return _mensaje; } set { _mensaje = value; } }

        public NotificacionEventArgs(string mensaje)
        {
            _mensaje = mensaje;
        }
    }
}
