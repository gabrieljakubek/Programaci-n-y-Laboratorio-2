using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 00";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string nombre;
            int edad;
            Console.Write("Hola Mundo!!!");
            Console.ReadLine();
            Console.Write("Ingrese su Nombre:");
            nombre = Console.ReadLine();
            Console.Write("Su nombre es: {0}", nombre);
            Console.ReadLine();
            Console.Write("Ingrese su Edad:");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Su edad es: {0}", edad);
            Console.ReadLine();
        }
    }
}
