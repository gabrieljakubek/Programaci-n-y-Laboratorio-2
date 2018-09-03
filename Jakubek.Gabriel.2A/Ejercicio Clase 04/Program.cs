using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_04
{
    class Ejercicio_Clase_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Clase 04";
            Cosa elemento = new Cosa();
            Console.WriteLine(Cosa.Mostrar(elemento));
            //elemento.cadena = "Hola Mundo!!!";
            //elemento.numero = 4567446514;
            //elemento.fecha = DateTime.Now;
            elemento.EstablecerValor("Lolo");
            Console.WriteLine(Cosa.Mostrar(elemento));
            elemento.EstablecerValor(45454213);
            Console.WriteLine(Cosa.Mostrar(elemento));
            elemento.EstablecerValor(DateTime.MinValue);
            Console.WriteLine(Cosa.Mostrar(elemento));
            Cosa elementoDos = new Cosa("Lalala");
            Console.WriteLine(Cosa.Mostrar(elementoDos));
            Console.ReadLine();
        }
    }
}
