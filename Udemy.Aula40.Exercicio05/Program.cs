using System;
using System.Collections.Generic;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> U = new HashSet<int>();
            int N;

            Console.Write("Quantos alunos possui o curso A? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso B? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < N; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui o curso C? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            U.UnionWith(A);
            U.UnionWith(B);
            U.UnionWith(C);

            Console.WriteLine("Total de alunos: " + U.Count);
            Console.ReadLine();
        }
    }
}