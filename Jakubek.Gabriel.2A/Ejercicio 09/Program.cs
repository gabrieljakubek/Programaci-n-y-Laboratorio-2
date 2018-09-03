using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            string buffer;
            bool chequeo = false;
            Int32 cantidad = 0;
            Int32 asteriscos = 1;
            Int32 i = 0;
            Int32 j = 0;

            Console.Title = "Ejercicio 09";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese el numero maximo de columnas que desea generar:");
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out cantidad);
            while (chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros y que sean mayores a 0");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese el numero maximo de columnas que desea generar:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out cantidad);
            }
            for (i = 0; i < cantidad; i++)
            {
                for (j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                asteriscos += 2;
                Console.WriteLine("");
            }
            
            Console.ReadLine();
        }
    }
}
