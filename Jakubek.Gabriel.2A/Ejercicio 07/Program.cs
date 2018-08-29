using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class PrEjercicio_07
    {
        static void Main(string[] args)
        {
            string buffer;
            bool chequeo = true;
            Int32 i;
            DateTime nacimiento;

            Console.Title = "Ejercicio 07";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Ingrese su dia de nacimiento:");
            buffer = Console.ReadLine();
            chequeo = DateTime.TryParse(buffer, out nacimiento);
            while (chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ingrese su dia de nacimiento:");
                buffer = Console.ReadLine();
                chequeo = DateTime.TryParse(buffer, out nacimiento);
            }
            
            for (nacimiento;)
            {

            }

        }
    }
}
