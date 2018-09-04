using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numA, double numB, string oper)
        {
            double resultado = 0;
            bool comprobar = true;
            if (oper == "+")
            {
                resultado = numA + numB;
            }
            else if (oper == "-")
            {
                resultado = numA - numB;
            }
            else if (oper == "*")
            {
                resultado = numA * numB;
            }
            else
            {
                comprobar = Validar(numB);
                if (comprobar == true)
                {
                    resultado = numA / numB;
                }
            }

            return resultado;
        }

        private static bool Validar(double numB)
        {
            bool chequeo = true;
            if (numB == 0)
            {
                chequeo = false;
            }
            return chequeo;
        }

        public static void Mostrar(double num)
        {
            Console.WriteLine("El resultado de la operacion es: {0}", num);
        }
    }
}
