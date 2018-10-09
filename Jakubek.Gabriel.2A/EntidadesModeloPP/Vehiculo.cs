using System;

namespace EntidadesModeloPP
{
    
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        #region Propiedades
        public string GetPatente
        {
            get
            {
                return this._patente;
            }
        }

        public byte CantRuedas
        {
            get
            {
                return this._cantRuedas;
            }
            set
            {
                this._cantRuedas = value;
            }

        }

        public EMarcas GetMarcas
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region
        public Vehiculo (string patente, byte cantRuedas, EMarcas eMarcas )
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = eMarcas;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar ()
        {
            return this._marca + " " + this._patente + " " + this._cantRuedas;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region  Sobrecargas
        public static bool operator == (Vehiculo ve1, Vehiculo ve2)
        {
            bool retorno = false;
            if (ve1._patente == ve2._patente && ve1._marca == ve2._marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Vehiculo ve1, Vehiculo ve2)
        {
            return !(ve1 == ve2);
        }
        #endregion
    }
}
