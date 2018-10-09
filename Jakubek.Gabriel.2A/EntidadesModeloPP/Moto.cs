using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesModeloPP
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        #region Constructor
        public Moto(EMarcas marca, float cilindrada, string patente, byte cantRuedas) : base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public Moto(byte cantRuedas, EMarcas marca, float cilindrada, string patente):this(marca,cilindrada,patente,cantRuedas)
        { }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar() + this._cilindrada);
            return sb.ToString();
        }

        public override string ToString ()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
