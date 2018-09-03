using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            double numero = 15;
            string retorno = "";

            Console.Title = "Ejercicio 13";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("El numero {0} en binario es: ", numero);
            retorno = Conversor.DecimalBinario(numero);
            Console.Write("{0}", retorno);

            Console.Read();
        }
    }
}
