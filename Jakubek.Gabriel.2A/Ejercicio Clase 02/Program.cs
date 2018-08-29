using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 02";
            Sello.mensaje = "";
            Console.Write(Sello.Imprimir());
            Console.WriteLine("");
            Sello.Color = ConsoleColor.DarkGreen;
            Sello.ImprimirEnColor();
            Sello.Borrar();
            Console.Write(Sello.Imprimir());
            Console.ReadLine();
            
        }
    }
}
