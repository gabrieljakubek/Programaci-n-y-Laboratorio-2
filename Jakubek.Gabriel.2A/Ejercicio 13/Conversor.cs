using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        /*public static string DecimalBinario(double numeroBase)
        {
            string retorno = "";
            int numero = 0;
            int i;
            bool flag = true;
            char digitoBina;
            string binarioInverso = "";
            numero = (int)numeroBase;

            while (flag)
            {
                binarioInverso = binarioInverso + (numero % 2);
                numero /= 2;
                if (numero == 1)
                {
                    binarioInverso = binarioInverso + numero;
                    flag = false;
                }
            }

            for (i = binarioInverso.Length - 1; i >= 0; i--)
            {
                digitoBina = binarioInverso[i];
                retorno += digitoBina;
            }

            return retorno;
        }*/
        

        public static string DecimalBinario(double numero)
        {
            string retorno = "";
            int numeroAux = 0;
            int i;
            bool flag = true;
            char digitoBina;
            string binarioInverso = "";
            numeroAux = (int)numero;

            while (flag)
            {
                if (numeroAux % 2 == 0 || numeroAux % 2 == 0)
                {
                    binarioInverso = binarioInverso + (numeroAux % 2);
                    numeroAux /= 2;
                    if (numeroAux == 1)
                    {
                        binarioInverso = binarioInverso + numeroAux;
                        flag = false;
                    }
                }
                else
                {
                    binarioInverso = "osrevni rolaV";
                    flag = false;
                }
            }

            for (i = binarioInverso.Length - 1; i >= 0; i--)
            {
                digitoBina = binarioInverso[i];
                retorno += digitoBina;
            }

            return retorno;
        }
        public static double BinarioDecimal(string binario)
        {
            double retorno = 0;
            int i;
            int j;
            int cantidad = 0;
            int potem = 0;
            int acumulador = 0;

            for (i = binario.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    cantidad = (binario.Length - 1) - i;
                    potem = 1;
                    for(j=1;j<=cantidad;j++)
                    {
                        potem *= 2;
                    }
                    acumulador += potem;

                }
            }
            retorno = acumulador;
            return retorno;
        }
    }
}
