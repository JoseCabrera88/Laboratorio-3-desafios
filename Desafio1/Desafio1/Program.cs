//Escribe un programa que solicite al usuario que ingrese un número entero positivo y muestre todos los números
//pares desde 1 hasta el número ingresado. Si el número actual no es par, el programa debe continuar con el siguiente número sin imprimir nada.

using System;


namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números pares hasta {0} son:", numero);

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        
    }
}
