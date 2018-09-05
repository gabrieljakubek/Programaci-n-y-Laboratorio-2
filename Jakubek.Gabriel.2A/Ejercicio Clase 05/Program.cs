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
            Console.ReadLine();
        }
    }
}
