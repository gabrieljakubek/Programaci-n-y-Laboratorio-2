using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string buffer = "";
            bool chequeo = true;
            Int32 numero;
            double cuadrado = 0;
            double cubo = 0;

            Console.Write("Ingrese un numero mayor que 0:");
            //numero = int.Parse(Console.ReadLine());
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out numero);
            /*while (esNumero == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero:");
                buffer = Console.ReadLine();
                esNumero = int.TryParse(buffer, out numero);
            }*/
            while (numero <= 0 || chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!! Reingresar solamente numero!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero mayo que 0:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El numero es {0}, al cuadrado dá {1} y al cubo dá {2}", numero, cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
