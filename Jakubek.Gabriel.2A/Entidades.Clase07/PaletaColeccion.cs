using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clase07
{
    public class PaletaColeccion
    {
        #region Atributos
        private List<Tempera> _colores;
        private int _cantMaximaElementos;
        #endregion

        #region Constructores
        private PaletaColeccion(int num)
        {
            this._cantMaximaElementos = num;
            this._colores = new List<Tempera>(_cantMaximaElementos);

        }

        private PaletaColeccion() : this(5)
        {

        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            int i = 1;
            string retorno = "";
            retorno += "La cantidad maxima es de " + this._cantMaximaElementos + "\r\n";
            foreach (Tempera temp in this._colores)
            {
                if (!object.Equals(temp, null))
                {
                    //retorno += "La tempera " + i + " es:\n";
                    retorno += temp;
                    retorno += "\r\n";
                }
                i++;
            }
            return retorno;
        }

        public static explicit operator string(PaletaColeccion palet)
        {
            return palet.Mostrar();
        }

        public static implicit operator PaletaColeccion(int cant)
        {
            return new PaletaColeccion(cant);
        }

        public static int ordenarColor(PaletaColeccion pal1, PaletaColeccion pal2)
        {
            int retorno = 0;
            if (pal1._colores == pal2._colores)
            { retorno = 0; }
            return retorno;
        }

        #endregion

        #region Sobrecargas
        public static bool operator ==(PaletaColeccion PaletaColeccion, Tempera tempera)
        {
            bool retorno = false;

            foreach (Tempera temp in PaletaColeccion._colores)
            {
                if (temp == tempera)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(PaletaColeccion PaletaColeccion, Tempera tempera)
        {
            return !(PaletaColeccion == tempera);
        }

        public static int operator ==(Tempera tempera, PaletaColeccion PaletaColeccion)
        {
            int retorno = -1;

            foreach (Tempera temp in PaletaColeccion._colores)
            {
                retorno++;
                if (temp == tempera)
                {
                    break;
                }
            }
            if (PaletaColeccion._colores.Count == retorno)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int operator !=(Tempera tempera, PaletaColeccion PaletaColeccion)
        {
            return tempera == PaletaColeccion;
        }

        public static PaletaColeccion operator +(PaletaColeccion pal, Tempera temp)
        {

            if (pal == temp)
            {
                pal._colores[temp == pal] += temp;
            }
            else
            {
                if (pal._colores.Count < pal._cantMaximaElementos)
                {
                    pal._colores.Add(temp);
                }
            }
            return pal;
        }

        public static PaletaColeccion operator -(PaletaColeccion pal, Tempera temp)
        {
            sbyte aux1;
            sbyte aux2;
            if (pal == temp)
            {
                aux1 = (sbyte)pal._colores[temp == pal];
                aux2 = (sbyte)temp;
                if (aux1 - aux2 <= 0)
                {
                    pal._colores.Remove(pal._colores[temp == pal]);
                    //pal._colores.RemoveAt(temp == pal);
                }
                else
                {
                    pal._colores[temp == pal] += (sbyte)(aux2 * (-1));
                }
            }
            return pal;
        }
        #endregion

        #region Indexacion

        public Tempera this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < this._cantMaximaElementos)
                {
                    return this._colores[indice];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (indice >= 0 && indice < this._cantMaximaElementos)
                {
                    this._colores[indice] = value;
                }
            }
        }

        #endregion

    }
}
