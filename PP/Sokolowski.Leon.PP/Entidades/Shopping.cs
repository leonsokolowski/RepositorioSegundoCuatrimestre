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
        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set { }
        }

        public List<Comercio> Comercios
        {
            get { return this._comercios; }
            set { }
        }

        public double PrecioDeExportadores
        {
            get { return ObtenerPrecio(EComercios.Exportador); }
            set { }
        }

        public double PrecioDeImportadores
        {
            get { return ObtenerPrecio(EComercios.Importador); }
            set { }
        }

        public double PrecioTotal
        {
            get { return ObtenerPrecio(EComercios.Ambos); }
            set { }
        }
        #endregion

        #region Constructores
        private Shopping()
        {
            _comercios = new List<Comercio>();
        }

        private Shopping(int capacidadMaxima) : this()
        {
            _capacidadMaxima = capacidadMaxima;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Shopping shopping)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad del shopping:{shopping.CapacidadMaxima.ToString()}");
            sb.AppendLine($"Total de importadores: {shopping.PrecioDeImportadores}");
            sb.AppendLine($"Total de exportadores: {shopping.PrecioDeExportadores}");
            sb.AppendLine($"Total: {shopping.PrecioTotal}");
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
            }
            return sb.ToString();
        }

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

        public void SerializarShopping(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shopping));

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                xmlSerializer.Serialize(streamWriter, this);
            }
        }

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
        public static implicit operator Shopping(int capacidad)
        {
            return new Shopping(capacidad);
        }

        public static bool operator ==(Shopping shopping, Comercio comercio)
        {
            return shopping._comercios.Contains(comercio);
        }

        public static bool operator !=(Shopping shopping, Comercio comercio)
        {
            return !(shopping == comercio);
        }

        public static Shopping operator +(Shopping shopping, Comercio comercio)
        {
            if (shopping != comercio && shopping._comercios.Count < shopping.CapacidadMaxima)
            {
                shopping._comercios.Add(comercio);
                return shopping;
            }
            else
            {
                return shopping;
            }
        }
        #endregion
    }
}
