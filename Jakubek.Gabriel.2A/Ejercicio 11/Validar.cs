using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool respuesta = true;

            if (valor < min || valor > max)
            {
                respuesta = false;
            }

            return respuesta;
        }
    }
}
