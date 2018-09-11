using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafo;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            Console.ForegroundColor = ConsoleColor.DarkGray;

            ConsoleColor color;
            short tinta;
            int gastar = 0;
            string chequeo;
            bool comprobacion = false;

            color = ConsoleColor.Blue;
            tinta = 100;
            Boligrafo.Boligrafo boligrafo1 = new Boligrafo.Boligrafo(color, tinta);

            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo1.GetColor(), boligrafo1.GetTinta());

            color = ConsoleColor.Red;
            tinta = 50;
            Boligrafo.Boligrafo boligrafo2 = new Boligrafo.Boligrafo(color, tinta);

            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo2.GetColor(), boligrafo2.GetTinta());

            gastar = 110;
            comprobacion = boligrafo1.Pintar(gastar, out chequeo);
            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo1.GetColor(), boligrafo1.GetTinta());

            boligrafo1.Recarga();
            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo1.GetColor(), boligrafo1.GetTinta());

            comprobacion = boligrafo2.Pintar(gastar, out chequeo);
            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo2.GetColor(), boligrafo2.GetTinta());

            boligrafo2.Recarga();
            Console.WriteLine("El color del boligrafo es {0} y tiene {1} de tinta", boligrafo2.GetColor(), boligrafo2.GetTinta());

            Console.ReadLine();
        }
    }
}
