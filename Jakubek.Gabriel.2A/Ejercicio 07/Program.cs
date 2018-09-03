using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcion_Ejercicio_07;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            string buffer;
            Int32 anoNa;
            Int32 diaNa;
            Int32 mesNa;
            Int32 totalDias = 0;

            Console.Title = "Ejercicio 07";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese su ano de nacimiento:");
            buffer = Console.ReadLine();
            anoNa = Funciones.ChequeoAno(buffer);
            Console.Write("Ingrese su mes de nacimiento:");
            buffer = Console.ReadLine();
            mesNa = Funciones.ChequeoMes(buffer);
            Console.Write("Ingrese su dia de nacimiento:");
            buffer = Console.ReadLine();
            diaNa = Funciones.ChequeoDia(buffer);
            
            Console.WriteLine("La fecha ingresada es: {0:##}/{1:##}/{2:####}", diaNa, mesNa, anoNa);
            totalDias = Funciones.calculoDias(anoNa, mesNa, diaNa);
            Console.WriteLine("Usted vivio {0} dias hasta hoy!!!!", totalDias);
            Console.ReadLine();

        }
    }
}
