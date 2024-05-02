using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clase_3
{
    //EJERCICIO 1
    public class Cuenta
    {
        #region Atributos
        private string titular;
        private decimal cantidad;
        #endregion

        #region Constructor
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        #endregion

        #region Metodos
        public string DevolverTitular()
        {
            return this.titular;
        }

        public decimal DevolverCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"-----------------------------------------\nTitular = {this.titular}\nCantidad = {this.cantidad}\n-----------------------------------------\n";
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
                Console.WriteLine("Transferencia recibida");
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }

        }
        #endregion
    }

    //EJERCICIO 2
    public class Persona
    {
        #region Atributos
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;
        #endregion

        #region Constructor
        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }
        #endregion

        #region Metodos
        private int CalcularEdad()
        {
            DateTime fechaHoy = DateTime.Today;

            if (this.fechaNacimiento > fechaHoy)
            {
                Console.WriteLine("La fecha de nacimiento ingresada no es valida porque todavía no ocurrio");
                return -1;
            }
            else
            {
                int edad = fechaHoy.Year - this.fechaNacimiento.Year;
                if (fechaHoy.Month > fechaNacimiento.Month)
                {
                    edad--;
                }
                return edad;
            }
        }

        private string CalcularMayoriaEdad()
        {
            if (CalcularEdad() > 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

        public void MostrarDatos()
        {
            string mensaje = $"Nombre: {this.nombre}\nEdad: {CalcularEdad()}\nFecha de nacimiento: {this.fechaNacimiento}\nDNI: {this.dni}\n{CalcularMayoriaEdad()}";
            Console.WriteLine(mensaje);
        }
        #endregion
    }

    //EJERCICIO 3

    public class Estudiante
    {
        #region Atributos
        protected string apellido;
        protected string nombre;
        protected string legajo;
        protected int notaPrimerParcial;
        protected int notaSegundoParcial;
        protected static Random random = new Random();
        #endregion

        #region Constructor
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        #endregion 
        
        #region Metodos
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private double CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            if ((this.notaPrimerParcial >= 4 && this.notaPrimerParcial <= 10) && (this.notaSegundoParcial >= 4 && this.notaSegundoParcial <= 10))
            {
                return random.Next(6, 10);
            }
            return -1;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota del Final: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            Console.WriteLine(sb.ToString());
        }
        #endregion 
    }

}
