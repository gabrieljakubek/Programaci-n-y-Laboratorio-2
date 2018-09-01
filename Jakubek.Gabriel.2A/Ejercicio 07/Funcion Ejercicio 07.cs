using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion_Ejercicio_07
{
    class Funciones
    {
        private static bool chequeo;
        private static Int32 ano;
        private static Int32 mes;
        private static Int32 dia;

        public static Int32 ChequeoDia(string bufferA)
        {
            Funciones.chequeo = int.TryParse(bufferA, out Funciones.dia);
            while (Funciones.chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ingrese su dia de nacimiento: ");
                bufferA = Console.ReadLine();
                Funciones.chequeo = int.TryParse(bufferA, out Funciones.dia);
            }
            return Funciones.dia;
        }

        public static Int32 ChequeoMes(string bufferA)
        {
            Funciones.chequeo = int.TryParse(bufferA, out Funciones.mes);
            while (Funciones.chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ingrese su mes de nacimiento: ");
                bufferA = Console.ReadLine();
                Funciones.chequeo = int.TryParse(bufferA, out Funciones.mes);
            }
            return Funciones.mes;
        }

        public static Int32 ChequeoAno(string bufferA)
        {
            Funciones.chequeo = int.TryParse(bufferA, out Funciones.ano);
            while (Funciones.chequeo == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!! Ingrese solamente numeros y solamente 4 digitos!!!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Ingrese su ano de nacimiento: ");
                bufferA = Console.ReadLine();
                Funciones.chequeo = int.TryParse(bufferA, out Funciones.ano);
            }
            return Funciones.ano;
        }

        private static Int32 ValidarFecha(string valiDia)
        {

            return Funciones.dia;
        }

        public static Int32 calculoDias(Int32 anoA, Int32 mesA, Int32 diaA)
        {
            Int32 diasTotales = 0;
            diasTotales += DiasAnoNacimiento(anoA, mesA, diaA);
            diasTotales += CompletarDiasVividos(anoA);
            diasTotales += DiasAnoActual(anoA, diaA);
            return diasTotales;
        }
        private static Int32 DiasAnoActual(Int32 anoA, Int32 mesA)
        {
            Int32 i;
            Int32 dias = 0;
            if (mesA == 1)
            {
                dias += DateTime.Now.Day;

            }
            else
            {
                for (i = 1; i < DateTime.Now.Month; i++)
                {
                    dias += DateTime.DaysInMonth(anoA, i);
                }
            }
            return dias;
        }

        private static Int32 DiasAnoNacimiento(Int32 anoA, Int32 mesA, Int32 diaA)
        {
            Int32 i;
            Int32 dias = 0;
            dias = DateTime.DaysInMonth(anoA, mesA) - diaA;
            for (i = mesA; i < 12; i++)
            {
                dias += DateTime.DaysInMonth(anoA, i);
            }
            return dias;
        }

        private static Int32 CompletarDiasVividos(Int32 anoA)
        {
            Int32 i;
            Int32 dias = 0;
            for (i = anoA + 1; i < DateTime.Now.Year; i++)
            {
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    dias += 366;
                }
                else
                {
                    dias += 365;
                }
            }
            return dias;
        }
    }
}
