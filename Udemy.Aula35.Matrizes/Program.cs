using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int N, contador = 0;

            N = int.Parse(Console.ReadLine());

            matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contador++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NÚMEROS NEGATIVOS: " + contador);

            Console.ReadLine();
        }
    }
}
