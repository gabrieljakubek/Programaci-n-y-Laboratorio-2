using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesModeloPP
{
    class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        #region Constructores
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }
        static Lavadero()
        {
            bool flag = false;
            Random aleatorio = new Random();
            Lavadero._precioAuto = aleatorio.Next(150, 565);
            do
            {
                Lavadero._precioCamion = aleatorio.Next(150, 565);
                Lavadero._precioMoto = aleatorio.Next(150, 565);
                if (Lavadero._precioAuto != Lavadero._precioCamion && Lavadero._precioAuto != Lavadero._precioMoto && Lavadero._precioCamion != Lavadero._precioMoto)
                {
                    flag = true;
                }
            } while (flag == false);
        }

        public Lavadero(string razonSocial) : this()
        {
            this._razonSocial = razonSocial;
        }
        #endregion

        #region Propiedad
        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this._razonSocial + " " + Lavadero._precioAuto + " " + Lavadero._precioCamion + " " + Lavadero._precioMoto);
                sb.AppendLine(this.Vehiculos);
                return sb.ToString();
            }
        }

        public string Vehiculos
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Vehiculo vehiculo in this._vehiculos)
                {
                    sb.AppendLine(vehiculo.ToString());
                }
                return sb.ToString();
            }
        }
        #endregion

        #region Metodos
        public double MostrarTotalFacturado()
        {
            double retorno = 0;
            retorno = this.MostrarTotalFacturado(EVehiculos.Autos) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
            return retorno;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double retorno = 0;
            int contAutos = 0;
            int contCamion = 0;
            int contMotos = 0;
            foreach (Vehiculo item in this._vehiculos)
            {
                if (item is Auto)
                {
                    contAutos++;
                }
                else if (item is Camion)
                {
                    contCamion++;
                }
                else if (item is Moto)
                {
                    contMotos++;
                }
            }
            switch (vehiculos)
            {
                case EVehiculos.Autos:
                    {
                        retorno = contAutos * Lavadero._precioAuto;
                    }
                    break;
                case EVehiculos.Camion:
                    {
                        retorno = contCamion * Lavadero._precioCamion;
                    }
                    break;
                case EVehiculos.Moto:
                    {
                        retorno = contMotos * Lavadero._precioMoto;
                    }
                    break;
                default:
                    break;
            }
            /*if (vehiculos == EVehiculos.Autos)
            {
                retorno = contAutos * Lavadero._precioAuto;
            }
            else if (vehiculos == EVehiculos.Camion)
            {
                retorno = contCamion * Lavadero._precioCamion;
            }
            else if (vehiculos == EVehiculos.Moto)
            {
                retorno = contMotos * Lavadero._precioMoto;
            }*/
            return retorno;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
          return string.Compare(v1.GetPatente, v2.GetPatente); 
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(Enum.GetName(typeof(EMarcas), v1.GetMarcas), Enum.GetName(typeof(EMarcas), v2.GetMarcas));
        }
        #endregion

        #region Sobrecarga 
        public static bool operator ==(Lavadero lav, Vehiculo veh)
        {
            bool retorno = false;
            foreach (Vehiculo item in lav._vehiculos)
            {
                if (item == veh)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Lavadero lav, Vehiculo veh)
        {
            return !(lav == veh);
        }

        public static int operator ==(Vehiculo veh, Lavadero lav)
        {
            int retorno = -1;
            for (int i = 0; i < lav._vehiculos.Count; i++)
            {
                if (veh == lav._vehiculos[i])
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public static int operator !=(Vehiculo veh, Lavadero lav)
        {
            return veh == lav;
        }

        public static Lavadero operator +(Lavadero lav, Vehiculo v)
        {
            if (lav != v)
            {
                lav._vehiculos.Add(v);
            }
            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo v)
        {
            int aux;
            aux = v == lav;
            if (aux>-1)
            {
                lav._vehiculos.RemoveAt(aux);
            }
            return lav;
        }
        #endregion
    }
}
