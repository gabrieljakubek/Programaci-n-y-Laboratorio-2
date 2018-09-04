using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            double numA = 0;
            double numB = 0;
            double resultado = 0;
            string operacion = "";
            string respuesta = "";
            bool continuar = true;

            do
            {
                Console.Write("Ingrese el primer numero: ");
                numA = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numB = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el tipo de operacion a realizar (+ - * /): ");
                operacion = Console.ReadLine();
                resultado = Calculadora.Calcular(numA, numB, operacion);
                if (operacion == "/" && resultado == 0)
                {
                    Console.WriteLine("Error!!!! No se puede dividir por 0!!!");
                }
                else
                {
                    Calculadora.Mostrar(resultado);
                }
                Console.Write("Desea constinua calculado? S/N ");
                respuesta = Console.ReadLine().ToUpper();
                continuar = Validacion.ValidaS_N(respuesta);
                Console.Clear();
            } while (continuar == true);
        }
    }
}
