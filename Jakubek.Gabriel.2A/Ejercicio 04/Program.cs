using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Int32 i;
            Int32 j;
            Int32 perfecto = 10000;
            Int32 mitad;
            Int32 total = 0;

            Console.Title = "Ejercicio 04";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Los cuatro primeros numeros perfectos son: ");
            for (i = 2; i <= perfecto; i++)
            {
                mitad = i / 2;
                for (j = 1; j <= mitad; j++)
                {
                    if (i % j == 0)
                    {
                        total += j;
                    }
                }
                if (total == i)
                {
                    Console.Write("{0} ", i);
                }
                total = 0;
            }
            Console.ReadLine();
        }
    }
}
