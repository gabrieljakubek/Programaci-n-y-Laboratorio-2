using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            string buffer;
            bool chequeo = false;
            Int32 numero;
            Int32 i;
            Int32 j;

            Console.Title = "Ejercicio 05";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese el numero maximo para hallar los centros numericos posibles:");
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out numero);
            while (chequeo == false || numero <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros y que sean mayores a 0");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese el numero maximo para hallar los centro numerico:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
            }
            if (numero >= 8)
            {
                Console.WriteLine("Los centros numericos son:");
                for (j = 1; j <= numero; j++)
                {
                    for (i = 1; i < j; i++)
                    {
                        if (i * (i - 1) / 2 == (j - i) * (j + i + 1) / 2) //(2 * Math.Pow(i, 2) == j * (j + 1))
                        {
                            Console.WriteLine("Del numero {0} es el {1}", j, i);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error!!!! no se halla ningun centro numerico!!!");
            }

            Console.ReadLine();
        }
    }
}
