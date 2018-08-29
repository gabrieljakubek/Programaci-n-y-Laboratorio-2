using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Int32 i;
            Int32 acumulador = 0;
            string buffer;
            bool chequeo = true;
            Int32 numero;

            Console.Title = "Ejercicio 03";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese un numero mayor que 1:");
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out numero);
            while (chequeo == false || numero <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero mayor que 1:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
            }
            Console.Write("Los numeros primos son: ");
            do
            {
                for (i = 2; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador++;
                    }
                }
                if (acumulador == 1 || numero == 2)
                {
                    Console.Write("{0} ", numero);
                }
                numero--;
                acumulador = 0;
            } while (numero > 1);
            Console.ReadLine();

        }
    }
}
