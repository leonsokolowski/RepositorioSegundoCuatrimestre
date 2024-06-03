using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Importador))]
    [XmlInclude(typeof(Exportador))]
    public class Shopping
    {
        #region Atributos
        private int _capacidadMaxima;
        private List<Comercio> _comercios;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _capacidadMaxima.
        /// </summary>
        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set { _capacidadMaxima = value; }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura para el atributo _comercios.
        /// </summary>
        public List<Comercio> Comercios
        {
            get { return this._comercios; }
            set { }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura. Llama a metodo ObtenerPrecio para obtener el precio de alquiler sumado de todos los exportadores.
        /// </summary>
        public double PrecioDeExportadores
        {
            get { return ObtenerPrecio(EComercios.Exportador); }
            set { }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura. Llama a metodo ObtenerPrecio para obtener el precio de alquiler sumado de todos los importadores.
        /// </summary>
        public double PrecioDeImportadores
        {
            get { return ObtenerPrecio(EComercios.Importador); }
            set { }
        }

        /// <summary>
        /// Propiedad publica de lectura y escritura. Llama a metodo ObtenerPrecio para obtener el precio de alquiler sumado de todos los comercios.
        /// </summary>
        public double PrecioTotal
        {
            get { return ObtenerPrecio(EComercios.Ambos); }
            set { }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor privado de instancia por defecto de la clase Shopping.
        /// Inicializara el atributo _comercios.
        /// </summary>
        private Shopping()
        {
            _comercios = new List<Comercio>();
        }

        /// <summary>
        /// Constructor privado de instancia de la clase Shopping.
        /// Inicializara el atributo _capacidadMaxima.
        /// </summary>
        /// <param name="capacidadMaxima">Parametro que refiere a la capacidad maxima de comercios dentro del shopping.</param>
        private Shopping(int capacidadMaxima) : this()
        {
            _capacidadMaxima = capacidadMaxima;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo publico de instancia de la clase Mostrar.
        /// Devuelve un string con toda la informacion del shopping, incluida la de sus comercios.
        /// </summary>
        /// <param name="shopping">Parametro que hace referencia al shopping que se va a mostrar.</param>
        /// <returns></returns>
        public static string Mostrar(Shopping shopping)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nCapacidad del shopping:{shopping.CapacidadMaxima}");
            sb.AppendLine($"Total de importadores: ${shopping.PrecioDeImportadores}");
            sb.AppendLine($"Total de exportadores: ${shopping.PrecioDeExportadores}");
            sb.AppendLine($"Total: ${shopping.PrecioTotal}");
            sb.AppendLine("************************");
            sb.AppendLine("Listado de Comercios");
            sb.AppendLine("************************");
            foreach (Comercio comercio in shopping._comercios)
            {
                if (comercio is Exportador exportador)
                {
                    sb.AppendLine(exportador.Mostrar());
                }
                else if (comercio is Importador importador)
                {
                    sb.AppendLine(importador.Mostrar());
                }

                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// Metodo privado de instancia de la clase Shopping.
        /// Devuelve un double con la suma de todos los precios de los alquileres de los negocios que cumplan con ser del tipo que se pasa por parametro.
        /// </summary>
        /// <param name="tipo">Parametro que refiere a el tipo de comercio que se quiere analizar.</param>
        /// <returns></returns>
        private double ObtenerPrecio(EComercios tipo)
        {
            double precio = 0;
            switch (tipo)
            {
                case EComercios.Exportador:
                    foreach (Comercio comercio in _comercios)
                    {
                        if (comercio is Exportador exportador)
                        {
                            precio += exportador.PrecioAlquiler;
                        }
                    }
                    break;

                case EComercios.Importador:
                    foreach (Comercio comercio in _comercios)
                    {
                        if (comercio is Importador importador)
                        {
                            precio += importador.PrecioAlquiler;
                        }
                    }
                    break;
                case EComercios.Ambos:
                    foreach (Comercio comercio in _comercios)
                    {
                        if (comercio is Exportador exportador)
                        {
                            precio += exportador.PrecioAlquiler;
                        }
                        else if (comercio is Importador importador)
                        {
                            precio += importador.PrecioAlquiler;
                        }
                    }
                    break;
            }
            return precio;
        }

        /// <summary>
        /// Metodo publico de instancia de la clase Shopping.
        /// Crea un archivo con toda la información del shopping en un path específico.
        /// </summary>
        /// <param name="path">Parametro que referencia a ruta donde se creara el archivo.</param>
        public void GuardarShopping(string path)
        {
            if (!(File.Exists(path)))
            {
                using (FileStream fileStream = File.Create(path))
                {
                    fileStream.Close();
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(Mostrar(this));
            }
        }

        /// <summary>
        /// Metodo publico de instancia de la clase Shopping.
        /// Serializa la clase Shopping en un archivo Xml.
        /// </summary>
        /// <param name="path">Parametro que referencia a ruta donde se serializara el archivo.</param>
        public void SerializarShopping(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shopping));

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                xmlSerializer.Serialize(streamWriter, this);
            }
        }

        /// <summary>
        /// Metodo publico de instancia de la clase Shopping.
        /// Deserializa la clase Shopping en un archivo Xml.
        /// </summary>
        /// <param name="path">Parametro que referencia a ruta desde donde se deserializara el archivo.</param>
        public static Shopping DeserializarShopping(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shopping));

            using (StreamReader streamReader = new StreamReader(path))
            {
                return (Shopping)xmlSerializer.Deserialize(streamReader);
            }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador de conversion al tipo de dato Shopping.
        /// Devuelve un objeto de la clase Shopping. 
        /// </summary>
        /// <param name="capacidad">Parametro que refiere a la capacidad que recibira como parametro al momento de instanciar la clase Shopping.</param>
        public static implicit operator Shopping(int capacidad)
        {
            return new Shopping(capacidad);
        }

        /// <summary>
        /// Sobrecarga del operador de igualdad.
        /// Devuelve un booleano. Sera True si el comercio esta dentro de la lista de comercios de la clase Shopping. False caso contrario.
        /// </summary>
        /// <param name="shopping">Parametro que hace referencia al Shopping.</param>
        /// <param name="comercio">Parametro que hace referencia al Comercio.</param>
        /// <returns></returns>
        public static bool operator ==(Shopping shopping, Comercio comercio)
        {
            return shopping._comercios.Contains(comercio);
        }

        /// <summary>
        /// Sobrecarga del operador de desigualdad.
        /// Devuelve un booleano. Sera True si el comercio no esta dentro de la lista de comercios de la clase Shopping. False caso contrario.
        /// </summary>
        /// <param name="shopping">Parametro que hace referencia al Shopping.</param>
        /// <param name="comercio">Parametro que hace referencia al Comercio.</param>
        /// <returns></returns>
        public static bool operator !=(Shopping shopping, Comercio comercio)
        {
            return !(shopping == comercio);
        }

        /// <summary>
        /// Sobrecarga del operador de aumento.
        /// Devuelve un objeto de la clase Shopping. Añadirá al comercio a la lista de comercios siempre y cuando la lista no este completa y el comercio no se encuentre ya en la lista.
        /// </summary>
        /// <param name="shopping">Parametro que hace referencia al Shopping.</param>
        /// <param name="comercio">Parametro que hace referencia al Comercio.</param>
        /// <returns></returns>
        public static Shopping operator +(Shopping shopping, Comercio comercio)
        {
            if (shopping != comercio && shopping._comercios.Count < shopping.CapacidadMaxima)
            {
                shopping._comercios.Add(comercio);
                return shopping;
            }
            else if (shopping == comercio)
            {
                Console.WriteLine("El comercio ya esta en el shopping!!!");
                return shopping;
            }
            else
            {
                Console.WriteLine("No hay más lugar en el shopping!!!");
                return shopping;
            }
        }
        #endregion
    }
}
