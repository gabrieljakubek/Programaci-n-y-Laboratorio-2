using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int notaUno = 0;
            int notaDos = 0;
            int legajo = 0;
            string nombre = "";
            string apellido = "";


            Alumno alumUno = new Alumno();
            notaUno = 4;
            notaDos = 6;
            legajo = 4581;
            nombre = "Jorge";
            apellido = "Sanchez";
            alumUno.nombre = nombre;
            alumUno.apellido = apellido;
            alumUno.legajo = legajo;
            alumUno.Estudiar(notaUno, notaDos);
            alumUno.CalcularFinal();
            Alumno alumDos = new Alumno();
            notaUno = 5;
            notaDos = 3;
            legajo = 4596;
            nombre = "Laura";
            apellido = "Lopez";
            alumDos.nombre = nombre;
            alumDos.apellido = apellido;
            alumDos.legajo = legajo;
            alumDos.Estudiar(notaUno, notaDos);
            alumDos.CalcularFinal();
            Alumno alumTres = new Alumno();
            notaUno = 8;
            notaDos = 9;
            legajo = 4612;
            nombre = "Samanta";
            apellido = "Mendez";
            alumTres.nombre = nombre;
            alumTres.apellido = apellido;
            alumTres.legajo = legajo;
            alumTres.Estudiar(notaUno, notaDos);
            alumTres.CalcularFinal();

            alumUno.Mostra();
            Console.WriteLine();
            alumDos.Mostra();
            Console.WriteLine();
            alumTres.Mostra();

            Console.ReadLine();

        }
    }
}
