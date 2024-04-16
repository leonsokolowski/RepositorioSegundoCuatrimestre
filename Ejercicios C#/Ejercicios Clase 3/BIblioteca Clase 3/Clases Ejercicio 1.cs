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

        #region Metodos
        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }


        #endregion
    }

}
