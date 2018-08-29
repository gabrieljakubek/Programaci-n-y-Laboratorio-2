using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            string buffer;
            bool chequeo = true;
            Int32 numero = 0;

            Console.Title = "Ejercicio 06";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese un año para saber si es bisiesto o no:");
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out numero);
            while (chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ingrese un año para saber si es bisiesto o no:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
            }
            numero = int.Parse(buffer);

            if (numero % 4 == 0 && (numero % 100 != 0 || numero % 400 == 0))
            {
                Console.Write("El año {0} es bisiesto!!!", numero);
            }
            else
            {
                Console.Write("El año {0} no es bisiesto!!!", numero);
            }
            Console.ReadLine();
        }
    }
}
