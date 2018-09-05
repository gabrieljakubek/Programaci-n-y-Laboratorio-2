using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            double valorHora;
            int antiguedad;
            int cantidaHorasMes;
            double totalBruto=0;
            double totalNeto=0;
            string nombreEmpleado;
            int i;

            valorHora = 445;
            antiguedad = 20;
            cantidaHorasMes = 176;
            nombreEmpleado = "Carlos Sanchez";
            for(i=1;i<=antiguedad;i++)
            {
                totalBruto += (cantidaHorasMes * valorHora);
            }
            totalBruto *= 150;
            totalNeto = totalBruto - (totalBruto * 0.13);
            Console.WriteLine("El empleado {0}", nombreEmpleado);
            Console.WriteLine("Cuenta con una antiguedad de {0}", antiguedad);
            Console.WriteLine("Su valor/hora es de ${0}", valorHora);
            Console.WriteLine("Se le pagara en bruto el monto de ${0:#,###}", totalBruto);
            Console.WriteLine("Se le pagara en neto el monto de ${0:#,###}", totalNeto);

            Console.ReadLine();
        }
    }
}
