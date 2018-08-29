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
            Int32 controlUno = 0;
            Int32 controlDos = 0;
            Int32 centroNumerico = 0;

            Console.Title = "Ejercicio 05";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese el numero maximo para hallar el centro numerico:");
            buffer = Console.ReadLine();
            chequeo = int.TryParse(buffer, out numero);
            while (chequeo == false || numero <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros y que sean mayores a 0");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese el numero maximo para hallar el centro numerico:");
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
            }
           // while (chequeo == true)
            //{
                for (i = 1; i <=numero; i++)
                {
                    controlUno += i;
                    controlDos = 0;
                    for (j = numero; j >=1; j--)
                    {
                        controlDos += j;
                        if (controlUno == controlDos)
                        {
                            centroNumerico = i+1;
                            Console.WriteLine("El centro numerico de {0} es {1}", numero, centroNumerico);
                            chequeo = false;
                        }
                    }
                    if(chequeo==false)
                    {
                        break;
                    }
                //}
            }
            Console.ReadLine();
        }
    }
}
