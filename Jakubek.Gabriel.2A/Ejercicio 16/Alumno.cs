using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region Atributos
        private int _nota1;
        private int _nota2;
        private int _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            Random aleatorio = new Random();
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = aleatorio.Next(4, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(int notaUno, int notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostra()
        {
            Console.WriteLine("Número de legajo {0}", this.legajo);
            Console.WriteLine("El nombre y apellido es {0} {1}", this.nombre, this.apellido);
            Console.WriteLine("Su primer y segunda nota son {0} y {1}", this._nota1, this._nota2);
            if (this._notaFinal != -1)
            {
                Console.WriteLine("Su nota final es {0}", this._notaFinal);
            }
            else
            {
                Console.WriteLine("Alumno desaprovado!!!");
            }
        }

        #endregion
    }
}
