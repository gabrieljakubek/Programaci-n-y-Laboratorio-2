using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase07
{
    class Tempera
    {
        #region Atributos
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;
        #endregion

        #region Cosntructor
        public Tempera(sbyte cantidad, ConsoleColor color, string marca)
        {
            this._cantidad = cantidad;
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno;
            retorno = "La cantidad es de " + this._cantidad;
            retorno += " el color es " + this._color;
            retorno += " y la marca es " + this._marca;
            return retorno;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator string(Tempera temp)
        {
            return temp.Mostrar();
        }

        public static explicit operator sbyte(Tempera temp)
        {
            return temp._cantidad;
        }

        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            bool retorno = false;
            if (temp1._color == temp2._color && temp1._marca == temp2._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp, sbyte cant)
        {
            temp._cantidad += cant;
            return temp;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            Tempera temp3 = new Tempera(temp1._cantidad, temp1._color, temp1._marca);
            if (temp1 == temp2)
            {
                temp3 += temp2._cantidad;
            }
            return temp3;
        }
        #endregion

    }
}
