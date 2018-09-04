using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            double ladoCuadr = 5;
            double baseTrian = 10;
            double alturaTrian = 4;
            double radioCirculo = 6;
            double resultado = 0;

            Console.Write("El area del cuadrado es de: ");
            resultado = CalculoDeArea.CalcularCuadrado(ladoCuadr);
            Console.WriteLine("{0}", resultado);
            Console.Write("El area del triangulo es de: ");
            resultado = CalculoDeArea.CalcularTriangulo(baseTrian, alturaTrian);
            Console.WriteLine("{0}", resultado);
            Console.Write("El area de un circulo es de: ");
            resultado = CalculoDeArea.CalcularCirculo(radioCirculo);
            Console.WriteLine("{0:#.##}", resultado);
            Console.ReadLine();
        }
    }
}
