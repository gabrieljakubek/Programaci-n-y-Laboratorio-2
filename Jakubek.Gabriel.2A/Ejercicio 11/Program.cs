using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validar;

namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            int i;
            int j = 10;
            string buffer;
            bool chequeo = false;
            int numero;
            int maximo = 0;
            int minimo = 0;
            int total = 0;
            float promedio = 0;

            Console.Title = "Ejercicio 11";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese {0} numeros", j);
            for (i = 1; i <= j; i++)
            {
                Console.Write("Ingrese el numero {0} entre -100 y 100:", i);
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
                if (chequeo == true)
                {
                    chequeo = Validacion.Validar(numero, -100, 100);
                }
                while (chequeo == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!!! Ingrese solamente numeros entre -100 y 100!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Ingrese el numero {0} entre -100 y 100:", i);
                    buffer = Console.ReadLine();
                    chequeo = int.TryParse(buffer, out numero);
                    if (chequeo == true)
                    {
                        chequeo = Validacion.Validar(numero, -100, 100);
                    }
                }
                numero = int.Parse(buffer);
                if (i == 1)
                {
                    maximo = numero;
                    minimo = numero;
                    total = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    total += numero;
                }
            }
            promedio = total / (float)j;
            Console.WriteLine("El numero es Mayor es {0}, el menor es {1} y el promedio es {2:#,###.00}", maximo, minimo, promedio);
            Console.ReadLine();
        }
    }
}

