using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5
{
    internal class Program
    {
        /// <summary>
        /// 1. Crea una clase llamada "Caja" que tenga tres propiedades: "ancho", "alto" y "profundidad", y una propiedad adicional llamada "volumen" que 
        /// calcula y devuelve el volumen de la caja (ancho * alto * profundidad).
        /// </summary>
        public class Caja
        {
            public double Ancho { get; set; }
            public double Alto { get; set; }
            public double Profundidad { get; set; }

            public double Volumen
            {
                get { return Ancho * Alto * Profundidad; }
            }
        }
        /// <summary>
        /// 2. En el programa principal, crea un arreglo de objetos de tipo "Caja" para almacenar las cajas que el usuario va a ingresar.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numCajas = 0;
            Console.Write("¿Cuántas cajas deseas ingresar?: ");
            numCajas = Convert.ToInt32(Console.ReadLine());

            Caja[] cajas = new Caja[numCajas];


            /// 3. Utiliza un loop para que el usuario pueda ingresar las dimensiones de cada caja y almacenarlas en el arreglo de objetos.
            for (int i = 0; i < numCajas; i++)
            {
                Console.WriteLine("Ingresa las dimensiones de la caja {0}:", i + 1);
                Console.Write("Ancho: ");
                double ancho = Convert.ToDouble(Console.ReadLine());
                Console.Write("Alto: ");
                double alto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Profundidad: ");
                double profundidad = Convert.ToDouble(Console.ReadLine());

                cajas[i] = new Caja { Ancho = ancho, Alto = alto, Profundidad = profundidad };
            }
            /// 4. Utiliza otro loop para sumar los volúmenes de todas las cajas.
            double totalVolumen = 0;
            for (int i = 0; i < numCajas; i++)
            {
                totalVolumen += cajas[i].Volumen;
            }
            /// 5. Calcula el volumen promedio dividiendo el total de volumen entre el número de cajas.
            double volumenPromedio = totalVolumen / numCajas;

            /// 6. Muestra los resultados al usuario.
            Console.WriteLine("El total de volumen de las cajas es: {0}", totalVolumen);
            Console.WriteLine("El volumen promedio de las cajas es: {0}", volumenPromedio);
            Console.ReadKey();
        }
    }
}