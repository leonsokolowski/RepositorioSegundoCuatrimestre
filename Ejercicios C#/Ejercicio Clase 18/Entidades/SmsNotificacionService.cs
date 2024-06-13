using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SmsNotificacionService : INotificacionService
    {
        public event EventHandler<NotificacionEventArgs> NotificacionRecibida;

        public void Notificar(string mensaje)
        {
            NotificacionRecibida.Invoke(this, new NotificacionEventArgs($"SMS: {mensaje}"));
        }
    }
}
