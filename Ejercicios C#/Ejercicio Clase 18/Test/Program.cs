using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear servicios de notificación
            INotificacionService servicioEmail = new EmailNotificacionService();
            INotificacionService servicioSms = new SmsNotificacionService();
            // Crear gestores de notificación
            NotificacionManager gestorEmail = new NotificacionManager(servicioEmail);
            NotificacionManager gestorSms = new NotificacionManager(servicioSms);
            // Enviar notificaciones
            gestorEmail.EnviarNotificacion("¡Tienes un nuevo correo electrónico!");
            gestorSms.EnviarNotificacion("¡Tienes un nuevo SMS!");
            // Suscribirse a eventos adicionales usando lambdas
            servicioEmail.NotificacionRecibida += (sender, e) =>
            {
                Console.WriteLine($"Manejo adicional para correo electrónico: {e.Mensaje}");
            };

            servicioSms.NotificacionRecibida += (sender, e) =>
            {
                Console.WriteLine($"Manejo adicional para SMS: {e.Mensaje}");
            };
            // Enviar más notificaciones
            gestorEmail.EnviarNotificacion("¡Otra notificación de correo electrónico!");
            gestorSms.EnviarNotificacion("¡Otra notificación de SMS!");
            Console.ReadKey();
        }
    }
}
