using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarRespuesta
{
    class Validar
    {
        public static bool ValidaS_N (string c)
        {
            bool respuesta = false;
            if (c=="S")
            {
                respuesta = true;
            }
            return respuesta;
        }

    }
}
