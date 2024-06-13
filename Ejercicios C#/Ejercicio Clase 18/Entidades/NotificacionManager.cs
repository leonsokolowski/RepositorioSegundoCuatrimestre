using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NotificacionManager
    {
        private readonly INotificacionService _notificacionService;

        public NotificacionManager (INotificacionService inotificacionService)
        {
            _notificacionService = inotificacionService;
            _notificacionService.NotificacionRecibida += ManejarNotificacion;
        }

        private void ManejarNotificacion(object obj, NotificacionEventArgs e)
        {
            Console.WriteLine($"Notificacion Recibida {e.Mensaje}");
        }

        public void EnviarNotificacion(string mensaje)
        {
            _notificacionService.Notificar(mensaje);
        }
    }
}
