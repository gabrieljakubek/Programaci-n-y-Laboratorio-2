using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cosa
    {
        public string cadena;
        public double numero;
        public DateTime fecha;

        #region Constructor
        public Cosa()
        {
            this.cadena = "Sin valor";
            this.numero = 1.9;
            this.fecha = DateTime.Now;
        }

        public Cosa(string c) : this()
        {
            this.cadena = c;

        }

        public Cosa(string caden, double num) : this(caden)
        {
            this.numero = num;
        }

        public Cosa(string caden, double num, DateTime dia) : this(caden, num)
        {
            this.fecha = dia;
        }

        #endregion

        #region Metodos 
        /// <summary>
        /// Muestra un objeto
        /// </summary>
        /// <param name="elemento">El objeto qué se desea mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Cosa elemento)
        {
            string retorno = "";
            retorno = elemento.Mostrar();
            return retorno;
        }

        /// <summary>
        /// Concatena los datos del objeto
        /// </summary>
        /// <returns>Retorna los datos concatenados del objeto</returns>
        private string Mostrar()
        {
            string retorno = "";
            retorno += this.cadena + " " + this.numero.ToString() + " " + this.fecha.ToShortDateString();
            return retorno;
        }

        public void EstablecerValor(string caden)
        {
            this.cadena = caden;
        }

        public void EstablecerValor(DateTime dia)
        {
            this.fecha = dia;
        }

        public void EstablecerValor(double num)
        {
            this.numero = num;
        }
        #endregion
    }
}
