using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillo;
        }
        #region Constructores
        public Tinta(ConsoleColor a) : this()
        {
            this._color = a;
        }

        //public Tinta(ETipoTinta b) : this()
        //{
        //    this._tipo = b;
        //}

        public Tinta(ConsoleColor a, ETipoTinta b) : this(a)
        {
            this._tipo = b;
        }
        #endregion

        #region Metodos

        public static string Mostrar(Tinta a)
        {
            string retorno="";
            retorno = a.Mostrar();
            return retorno;
        }
        
        private string Mostrar ()
        {
            string retorno = "";
            retorno = "El color es: " + this._color.ToString() + " y el tipo es: " + this._tipo.ToString();
            return retorno;
        }

        #endregion

        #region Sobrecargas

        public static bool operator == (Tinta a, Tinta b)
        {
            bool retorno= false;

            if (a._tipo == b._tipo && a._color == b._color)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            bool retorno = !(a == b);
            return retorno;
        }
            #endregion
        }
}
