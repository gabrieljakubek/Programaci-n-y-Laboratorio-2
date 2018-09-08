using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    internal class Tinta
    {
        #region Atributos
        private ConsoleColor _color;
        private ETipoTinta _tipo;
        #endregion

        #region Constructores
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.ConBrillo;
        }

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
            string retorno = "Sin Tinta";
            if(!object.Equals(a, null)) //(a!=null) no funciona, preguntar
            {
                retorno = a.Mostrar();
            }
            return retorno;
        }

        private string Mostrar()
        {
            string retorno = "";
            retorno += "El color es: ";
            retorno += this._color.ToString();
            retorno += " y el tipo es: ";
            retorno += this._tipo.ToString();
            return retorno;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Tinta a, Tinta b)
        {
            bool retorno = false;
            if (!object.Equals(a, null) && !object.Equals(b, null))
            {
                if (a._tipo == b._tipo && a._color == b._color)
                {
                    retorno = true;
                }
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
