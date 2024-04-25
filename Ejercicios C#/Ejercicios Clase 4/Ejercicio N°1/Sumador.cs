namespace Biblioteca
{
    //Ejercicio N°1
    public class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Metodos
        public Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;   
        }

        public Sumador () : this (0) 
        {}

        public long Sumar (long numero1, long  numero2)
        {
            this.cantidadSumas ++;
            return numero1 + numero2;
        }

        public string Sumar (string texto1, string texto2)
        {
            this.cantidadSumas ++;
            return texto1 + texto2;

        }
        
        #endregion
    }
}
