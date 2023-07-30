using System;

namespace Fluxo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] vetorLinhas = Console.ReadLine().Split(' ');

                for (int w = 0; w < n; w++)
                {
                    matriz[i, w] = int.Parse(vetorLinhas[w]);
                    
                }
            }

            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine("\nNegative numbers: ");

            for (int i = 0; i < n; i++)
            {
                if (matriz[i, i] < 0)
                {
                    Console.Write(matriz[i, i] + " ");
                }
            }
        }
    }
}