using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26_Mostrar20NumerosyLuegoDeFormaDecreciente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[20];

            int tam, i, j, aux;


            Console.WriteLine("Ingrese el tamaño del vector: ");
            tam = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < tam; i++)
            {
                Console.WriteLine("X[" + (i + 1) + "]: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < tam; i++)
            {
                for (j = i + 1; j < tam; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
            Console.WriteLine(" \nVector ordenado de mayor a menor: ");
            for (i = 0; i < tam; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
