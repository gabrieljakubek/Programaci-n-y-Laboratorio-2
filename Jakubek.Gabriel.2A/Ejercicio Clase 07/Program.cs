using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 07";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            sbyte cantidad;
            ConsoleColor color;
            string marca;
            sbyte cantRetorno;
            string tempDatos;


            cantidad = 10;
            color = ConsoleColor.DarkMagenta;
            marca = "bic";
            Tempera tempera1 = new Tempera(cantidad, color, marca);

            cantidad = 50;
            color = ConsoleColor.DarkYellow;
            marca = "Pelican";
            Tempera tempera2 = new Tempera(cantidad, color, marca);

            tempDatos = tempera1;
            cantRetorno = (sbyte)tempera1;
            Console.WriteLine(tempDatos);

            Console.ReadLine();
        }
    }
}
