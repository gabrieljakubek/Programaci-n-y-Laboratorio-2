using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Pluma
    {
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;

        #region Constructor

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cant) : this(marca)
        {
            this._cantidad = cant;
        }

        public Pluma(string marca, int cant, Tinta tin) : this(marca, cant)
        {
            this._tinta = tin;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            string retorno = "";
            if (this._tinta != null)
            {
                retorno += "El la marca de la pluma es ";
                retorno += this._marca;
                retorno += ", hay una cantidad de ";
                retorno += this._cantidad;
                retorno += " y su tinta es ";
                retorno += Tinta.Mostrar(this._tinta);
            }
            else
            {
                retorno += "Error!!! No tiene tinta asignada!!!";
            }
            return retorno;
        }

        #endregion

        #region Sobrecarga

        public static implicit operator string(Pluma a)
        {
            string retorno = "";
            retorno = a.Mostrar();
            return retorno;
        }

        public static bool operator == (Pluma a, Tinta b)
        {
            bool retorno = false;
            if (a._tinta == b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pluma a, Tinta b)
        {
            return !(a == b);
        }

        public static Pluma operator +(Pluma a, Tinta b)
        {
            if (a._tinta==b)
            {
                a._cantidad += 10;
                if (a._cantidad>100)
                {
                    a._cantidad =100;
                }
            }
            return a;
        }

        public static Pluma operator -(Pluma a, Tinta b)
        {
            if (a._tinta == b)
            {
                a._cantidad -= 15;
                if (a._cantidad < 0)
                {
                    a._cantidad = 0;
                }
            }
            return a;
        }
        #endregion

    }
}
