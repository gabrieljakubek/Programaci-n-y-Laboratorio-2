using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Ejercicio_Clase_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 05";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Tinta lapicera = new Tinta();
            Console.WriteLine(Tinta.Mostrar(lapicera));
            lapicera = new Tinta(ConsoleColor.DarkGray);
            Console.WriteLine(Tinta.Mostrar(lapicera));
            lapicera = new Tinta(ConsoleColor.DarkCyan, ETipoTinta.China);
            Console.WriteLine(Tinta.Mostrar(lapicera));
            lapicera = new Tinta();
            Tinta lapicera2 = new Tinta();
            Console.WriteLine("Son iguales? {0}", lapicera == lapicera2);
            lapicera2 = new Tinta(ConsoleColor.DarkMagenta, ETipoTinta.Comun);
            Console.WriteLine("Son iguales? {0}", lapicera == lapicera2);
            Pluma pluma1 = new Pluma("Pelican", 0, lapicera2);
            Pluma pluma2 = new Pluma("Fabercastle", 22);

            Console.WriteLine(pluma2);
            pluma2 -= lapicera;
            Console.WriteLine(pluma2);

            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 += lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            Console.WriteLine();
            pluma1 -= lapicera2;
            Console.WriteLine(pluma1);
            Console.WriteLine();
            pluma1 -= lapicera;
            Console.WriteLine(pluma1);
            

            Console.ReadLine();
        }
    }
}
