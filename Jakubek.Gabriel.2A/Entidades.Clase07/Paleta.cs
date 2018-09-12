using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clase07
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _colores;
        private int _cantMaximaElementos;
        #endregion

        #region Constructores
        private Paleta(int num)
        {
            this._cantMaximaElementos = num;
            this._colores = new Tempera[_cantMaximaElementos];

        }

        private Paleta() : this(5)
        {

        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            int i = 1;
            string retorno = "";
            retorno += "La cantidad maxima es de " + this._cantMaximaElementos + "\n";
            foreach (Tempera temp in this._colores)
            {
                retorno += "La tempera " + i + " es:\n";
                retorno += temp;
                retorno += "\n";
                i++;
            }
            return retorno;
        }

        public static explicit operator string(Paleta palet)
        {
            return palet.Mostrar();
        }

        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant);
        }

        private int ObtenerIndice()
        {
            int i = 0;
            foreach (Tempera temp in this._colores)
            {

                if (object.Equals(temp, null))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        private int ObtenerIndice(Tempera temp)
        {
            int i = 0;
            foreach (Tempera temp1 in this._colores)
            {

                if (!object.Equals(temp, null) && temp1 == temp)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }


        #endregion

        #region Sobrecargas
        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;

            foreach (Tempera temp in paleta._colores)
            {
                if (!object.Equals(temp, null) && temp == tempera)
                {
                    retorno = true;
                    break;
                }
            }
            /*for(int i=0; i<paleta._cantMaximaElementos;i++)
            {
                if (paleta._colores.GetValue(i)!=null)
                {
                    if (paleta._colores[i] == tempera)
                    {
                        retorno = true;
                        break;
                    }
                }
            }*/
            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta pal, Tempera temp)
        {
            int indice;
            if (pal == temp)
            {
                indice = pal.ObtenerIndice(temp);
                pal._colores[indice] += temp;
            }
            else
            {
                indice = pal.ObtenerIndice();
                if (indice != -1)
                {
                    pal._colores[indice] = temp;
                }
            }

            /*for(i=0; i<pal._cantMaximaElementos;i++)
            {
                if (pal._colores[i]==temp)
                {
                    pal._colores[i] += temp;
                    break;
                }
            }*/

            return pal;
        }

        public static Paleta operator -(Paleta pal, Tempera temp)
        {
            int indice;
            sbyte aux1;
            sbyte aux2;
            if (pal == temp)
            {
                indice = pal.ObtenerIndice(temp);
                aux1 = (sbyte)pal._colores[indice];
                aux2 = (sbyte)temp;
                if (aux1 - aux2 <= 0)
                {
                    pal._colores[indice] = null;
                }
                else
                {
                    pal._colores[indice] += (sbyte)(aux2 * (-1));
                }
            }
            return pal;
        }
        #endregion
    }
}
