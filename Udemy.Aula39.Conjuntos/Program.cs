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

            A.Add(5);
            A.Add(8);
            A.Add(9);
            A.Add(3);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int a in A) {
                Console.WriteLine(a);
            }

            Console.WriteLine("Digite um valor inteiro");
            int N = int.Parse(Console.ReadLine());

            if (A.Contains(N))
            {
                Console.WriteLine("O conjunto A CONTÉM o valor " + N);
            } else {
                Console.WriteLine("O conjunto A NÃO CONTÉM o valor " + N);
            }

            C = A;
            A.UnionWith(B);
            B.ExceptWith(C);

                
            Console.ReadLine();



        }
    }
}
