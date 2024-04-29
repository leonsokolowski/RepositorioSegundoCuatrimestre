using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clase_3
{
    //----------------------------------------------------------------------------------------------------------------
    //Ejercicio 1
    public class Cuenta
    {
        #region Atributos
        private string titular;
        private decimal cantidad;
        #endregion

        #region Metodos
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

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
    //----------------------------------------------------------------------------------------------------------------
    //Ejercicio 2
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

}
