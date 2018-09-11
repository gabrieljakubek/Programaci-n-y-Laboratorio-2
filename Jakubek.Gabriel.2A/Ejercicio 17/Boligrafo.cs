using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    class Boligrafo
    {
        #region Atributos
        private readonly short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;
        #endregion

        #region Constructores

        public Boligrafo()
        {
            this._tinta = 100;
            this._color = ConsoleColor.Black;
        }

        public Boligrafo(short tinta) : this()
        {
            this._tinta = tinta;
        }

        public Boligrafo(ConsoleColor color, short tinta) : this(tinta)
        {
            this._color = color;
        }
        #endregion

        #region Metodos
        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            int i = 0;
            dibujo = "";
            if (this._tinta > 0)
            {
                if (gasto > this._tinta)
                {
                    for (i = 0; i < this._tinta; i++)
                    {
                        dibujo += "*";
                    }
                    this._tinta = 0;
                }
                else
                {
                    for (i = 0; i < gasto; i++)
                    {
                        dibujo += "*";
                    }
                    this._tinta -= (short)gasto;
                }
                Console.ForegroundColor = this._color;
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else
            {
                Console.WriteLine("Recargue la tinta del boligrafo!!!");
            }
            return retorno;
        }

        public void Recarga()
        {
            this.SetTinta(this._tinta);
        }

        private void SetTinta(short tinta)
        {
            if (tinta < 100)
            {
                this._tinta = 100;
            }
        }
        #endregion

    }
}
