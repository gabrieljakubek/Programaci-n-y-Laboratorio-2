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
            int numero;
            string buffer = "";
            int total = 0;
            int maximo = 0;
            int minimo = 0;
            bool esNumero = true;
            float promedio;
            double cuadrado = 0;
            double cubo = 0;
            int acumulador = 0;
            int perfecto = 10000;
            int mitad = 0;


            Console.Title = "Ejercicio 01";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ingrese {0} numeros", j);
            for(i=1; i<=j; i++)
            {
                Console.Write("Ingrese el numero {0}:", i);
                buffer = Console.ReadLine();
                esNumero = int.TryParse(buffer, out numero);
                while (esNumero == false) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Ingrese el numero {0}:", i);
                    buffer = Console.ReadLine();
                    esNumero = int.TryParse(buffer, out numero);
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

            Console.Write("Ingrese un numero mayor que 0:");
            //numero = int.Parse(Console.ReadLine());
            buffer = Console.ReadLine();
            esNumero = int.TryParse(buffer, out numero);
            /*while (esNumero == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero:");
                buffer = Console.ReadLine();
                esNumero = int.TryParse(buffer, out numero);
            }*/
            while (numero <= 0 || esNumero == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!! Reingresar solamente numero!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero mayo que 0:");
                buffer = Console.ReadLine();
                esNumero = int.TryParse(buffer, out numero);
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El numero es {0}, al cuadrado dá {1} y al cubo dá {2}", numero, cuadrado, cubo);

            Console.Write("Ingrese un numero mayor que 1:");
            buffer = Console.ReadLine();
            esNumero = int.TryParse(buffer, out numero);
            while (esNumero ==false || numero<=1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numero");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Reingrese un numero mayor que 1:");
                buffer = Console.ReadLine();
                esNumero = int.TryParse(buffer, out numero);
            }
            Console.Write("Los numeros primos son: ");
            do
            {
                for (i = 2; i<=numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador++;
                    }
                }
                if (acumulador == 1 || numero ==2)
                {
                    Console.Write("{0} ", numero);
                }
                numero--;
                acumulador = 0;
            } while (numero > 1);
            Console.WriteLine("");

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
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
