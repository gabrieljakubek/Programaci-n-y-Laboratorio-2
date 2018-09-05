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
            double numero = 54;
            string retorno = "";

            Console.Title = "Ejercicio 13";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("El numero {0} en binario es: ", numero);
            retorno = Conversor.DecimalBinario(numero);
            Console.WriteLine("{0}", retorno);

            retorno = "1111";

            Console.Write("El codigo binario {0} representa al decimal: ", retorno);
            numero = Conversor.BinarioDecimal(retorno);
            Console.Write("{0}", numero);

            Console.Read();
        }
    }
}
