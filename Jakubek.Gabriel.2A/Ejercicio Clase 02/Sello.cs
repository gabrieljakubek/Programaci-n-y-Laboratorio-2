using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Sello
    {
        public static string mensaje;

        public static ConsoleColor Color;

        public static string Imprimir()
        {

            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = ("");
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.Color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            int i;
            string texto;
            string linea = "";
            if ( Sello.TryParse(mensaje, out texto))
            {
                Sello.mensaje = texto;
                for (i = 0; i < mensaje.Length + 2; i++)
                {
                    linea += "*";
                }
                linea += "\n";
                linea += "*";
                linea += Sello.mensaje;
                linea += "*";
                linea += "\n";
                for (i = 0; i < mensaje.Length + 2; i++)
                {
                    linea += "*";
                }
            }
            else
            {
                linea = "Error!!!! Mensaje vacio!!!!";
            }
            return linea;
        }

        private static bool TryParse(string a, out string b)
        {
            bool chequeo = false;
            b = "";
            if(a.Length != 0)
            {
                chequeo = true;
                b = a;
            }
            return chequeo;
        }

    }
}
