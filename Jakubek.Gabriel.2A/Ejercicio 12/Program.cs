using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Int32 acumulador = 0;
            string chequeo = "";
            bool respuesta = false;

            Console.Title = "Ejercicio 12";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            do
            {
                acumulador += 1;
                Console.WriteLine("{0}", acumulador);
                Console.Write("Desea continuar? S/N ");
                chequeo = Console.ReadLine().ToUpper();
                respuesta = ValidarRespuesta.ValidaS_N(chequeo);

            } while (respuesta == true);
        }
    }
}
