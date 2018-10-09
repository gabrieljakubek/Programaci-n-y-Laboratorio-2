using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesModeloPP
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos):base(patente,cantRuedas,marca)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public Auto(string patente, EMarcas marcas, int cantidadAsientos):this(patente,4,marcas,cantidadAsientos)
        { }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar() + " " + this._cantidadAsientos);
            return sb.ToString();
        }
    }
}
