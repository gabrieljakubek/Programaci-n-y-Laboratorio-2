using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double l)
        {
            double cuadrado = 0;
            cuadrado = l * l;
            return cuadrado;
        }

        public static double CalcularTriangulo(double b, double a)
        {
            double triangulo = 0;
            triangulo = (b * a) / 2;
            return triangulo;
        }

        public static double CalcularCirculo(double r)
        {
            double circulo = 0;
            circulo = Math.PI * Math.Pow(r,2);
            return circulo;
        }
    }
}
