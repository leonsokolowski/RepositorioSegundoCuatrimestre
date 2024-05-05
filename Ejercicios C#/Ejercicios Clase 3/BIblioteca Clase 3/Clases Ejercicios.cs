using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Clase_3
{
    #region EJERCICIO 1
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
    #endregion

    #region EJERCICIO 2
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
    #endregion

    #region EJERCICIO 3

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
    #endregion

    #region EJERCICIO 4
    public class Boligrafo
    {
        #region Atributos
        protected const short cantidadMaximaTinta = 100;
        protected ConsoleColor color;
        protected short tinta;
        #endregion

        #region Constructor
        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        #endregion

        #region Propiedades
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        protected void SetTinta(short cantidad)
        {
            if (cantidad >= 0 && cantidad <= cantidadMaximaTinta)
            {
                this.tinta = cantidad;
            }
        }
        #endregion

        #region Metodos
        public void Recargar()
        {
            SetTinta(cantidadMaximaTinta);
            Console.WriteLine("Tinta recargada");
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            if (gasto > 0 && gasto <= this.tinta)
            {
                short tintaRestante = (short)(tinta - (short)gasto);
                SetTinta (tintaRestante);

                dibujo = new string('*', gasto);
                return true;
            }
            else
            {
                dibujo = new string('*', tinta);
                return false;
            }
        }
        #endregion
    }
    #endregion

    #region EJERCICIO 5
    public class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Constructor
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Propiedades
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        #endregion
    }

    public class Rectangulo
    {
        #region Atributos
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        #endregion

        #region Constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }
        #endregion

        #region Metodos
        public float CalcularBase()
        {
            float baseRectangulo = Math.Abs(vertice2.GetX() - vertice1.GetX());
            return baseRectangulo;
        }
        public float CalcularAltura()
        {
            float alturaRectangulo = Math.Abs(vertice2.GetY() - vertice3.GetY());
            return alturaRectangulo;
        }
        public float CalcularArea()
        {
            if (this.area == 0)
            {
                this.area = CalcularBase() * CalcularAltura();
            }
            return this.area;
        }

        public float CalcularPerimetro()
        {
            if (this.perimetro  == 0)
            {
                this.perimetro = (CalcularBase() + CalcularAltura()) / 2;
            }
            return this.perimetro;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Datos del Rectángulo:");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }
        #endregion
    }

    #endregion

    #region EJERCICIO 6
    public class Mascota
    {
        #region Atributos
        protected string especie;
        protected string nombre;
        protected DateTime fechaDeNacimiento;
        protected string vacuna;
        #endregion

        #region Constructor
        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        #endregion

        #region Propiedades
        public string Especie { get { return this.especie; } set { this.especie = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public DateTime FechaDeNacimiento { get { return this.fechaDeNacimiento; } set { this.fechaDeNacimiento = value; } }
        public string Vacuna { get { return this.vacuna; } set { this.vacuna = value; } }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            string infoMascota = $"Nombre: {Nombre}\nEspecie: {Especie}\nFecha de nacimiento: {FechaDeNacimiento.ToShortDateString()}";
            string infoVacuna;
            if (string.IsNullOrEmpty(Vacuna))
            {
                infoVacuna = "\nNo tiene vacunas aplicadas.";
            }
            else
            {
                infoVacuna = $"\nVacuna: {Vacuna}";
            }
            return infoMascota + infoVacuna;
        }
        #endregion
    }

    public class Cliente
    {
        #region Atributos
        protected string domicilio;
        protected string nombre;
        protected string apellido;
        protected int telefono;
        protected Mascota mascota;
        #endregion

        #region Constructor
        public Cliente(string nombre, string apellido, string domicilio, int telefono, Mascota mascota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascota = mascota;
        }
        #endregion

        #region Propiedades
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Domicilio { get { return this.domicilio; } set { this.domicilio = value; } }
        public int Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public Mascota Mascota { get { return this.mascota; } set { this.mascota = value; } }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            string infoCliente = $"Nombre: {Nombre}\nEspecie: {Apellido}\nDomicilio: {Domicilio}\nTelefono: {telefono}\nEs dueño de:\n{Mascota.Mostrar()}";
            return infoCliente;
        }
        #endregion

    }

    #endregion
}
