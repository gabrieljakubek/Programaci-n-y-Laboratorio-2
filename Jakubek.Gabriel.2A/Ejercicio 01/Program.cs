using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            int i;
            int j = 5;
            int numero = 0;
            string buffer = "";
            int total = 0;
            int maximo = 0;
            int minimo = 0;
            bool chequeo = true;
            float promedio;

            Console.Title = "Ejercicio 01";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese {0} numeros", j);
            for(i=1; i<=j; i++)
            {
                Console.Write("Ingrese el numero {0}:", i);
                buffer = Console.ReadLine();
                chequeo = int.TryParse(buffer, out numero);
                while (chequeo == false) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Ingrese el numero {0}:", i);
                    buffer = Console.ReadLine();
                    chequeo = int.TryParse(buffer, out numero);
                } 
                numero = int.Parse(buffer);
                if(i==1)
                {
                    maximo = numero;
                    minimo = numero;
                    total = numero; 
                }
                else if(numero>0)
                {
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }
                    else if(numero < minimo)
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
