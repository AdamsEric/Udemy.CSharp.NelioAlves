using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int m, n, busca;
            string[] dimensoes, linha;

            dimensoes = Console.ReadLine().Split(' ');

            m = int.Parse(dimensoes[0]);
            n = int.Parse(dimensoes[1]);

            matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            busca = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] == busca)
                    {
                        //Esquerda
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        //Acima
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }
                        //Direita
                        if (j + 1 < n)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        //Abaixo
                        if (i + 1 < m)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
