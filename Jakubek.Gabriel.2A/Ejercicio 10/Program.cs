using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            string buffer;
            bool chequeo = false;
            Int32 cantidad = 0;
            Int32 asteriscos = 1;
            Int32 espacios = 0;
            Int32 i = 0;
            Int32 j = 0;
            Int32 k = 0;
            Console.Title = "Ejercicio 10";
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
            //espacios += (cantidad - 1);
            espacios += cantidad;
            for (i = 0; i < cantidad; i++)
            {
                for (k=espacios;k>0;k--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                espacios--;
                asteriscos += 2;
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
