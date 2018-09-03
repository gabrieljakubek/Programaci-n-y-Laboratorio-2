using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double a)
        {
            string retorno ="";
            while(a!=1)
            {
                retorno = retorno + a % 2;
                a = a/2;
                if (a==1)
                {
                    retorno += a;
                }
            }
            return retorno;
        }

        public static double BinarioDecimal(string b)
        {
            double retorno = 0;

            return retorno;
        }
    }
}
