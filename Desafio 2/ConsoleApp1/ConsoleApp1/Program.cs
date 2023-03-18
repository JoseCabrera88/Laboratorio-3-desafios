using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("No es un número primo.");
                return;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("No es un número primo.");
                    return;
                }
            }

            Console.WriteLine("Es un número primo.");

            Console.ReadKey();
        }
    }
}

