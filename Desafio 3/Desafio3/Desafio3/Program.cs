using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double sum = 0;
            double grado = 0;

            while (true)
            {
                Console.Write("Ingrese la calificación del estudiante (1-10): ");
                string input = Console.ReadLine();

                if (input == "fin")
                {
                    break;
                }

                if (double.TryParse(input, out grado) && grado >= 1 && grado <= 10)
                {
                    sum += grado;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido entre 1 y 10, o escriba 'fin' para terminar.");
                }
            }

            if (contador > 0)
            {
                double promedio = sum / contador;
                Console.WriteLine("El promedio del estudiante es: {0}", promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }
        }
    }
}
