using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesModeloPP
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        #region Constructor
        public Camion(string patente, EMarcas marcas, byte cantRuedas, float tara) : base(patente, cantRuedas, marcas)
        {
            this._tara = tara;
        }
        public Camion(Vehiculo vehiculo, float tara) : this(vehiculo.GetPatente, vehiculo.GetMarcas, vehiculo.CantRuedas, tara)
        { }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar() + this._tara);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
